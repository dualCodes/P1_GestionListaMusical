using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Servicios;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmMain : Form
    {
        private readonly SchedulerService _schedulerService = new SchedulerService();
        private readonly AudioPlayerService _playerService = new AudioPlayerService();
        private readonly HorarioRepository _horarioRepo = new HorarioRepository();

        public FrmMain()
        {
            InitializeComponent();
            ConfigurarMDI();

            _schedulerService.Iniciar();
            ActualizarEstadoVisual(true);

            uiTimer.Start();
        }

        private void ConfigurarMDI()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.WhiteSmoke;
                    break;
                }
            }
        }

        private void btnNavHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBrowHorarios>();
        }

        private void btnNavCanciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBrowCanciones>();
        }

        private void btnNavListas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmBrowListas>();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _schedulerService.Iniciar();
            ActualizarEstadoVisual(true);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            _playerService.DetenerReproduccion();
            _schedulerService.Detener();

            ActualizarEstadoVisual(false);
        }

        private void ActualizarEstadoVisual(bool activo)
        {
            if (activo)
            {
                lblEstadoServicio.Text = " EN EJECUCIÓN ";
                lblEstadoServicio.BackColor = Color.SeaGreen;
                lblEstadoServicio.ForeColor = Color.White;

                btnIniciar.Enabled = false;
                btnDetener.Enabled = true;

                btnIniciar.BackColor = Color.FromArgb(25, 135, 84);
                btnDetener.BackColor = Color.FromArgb(220, 53, 69);
            }
            else
            {
                lblEstadoServicio.Text = " DETENIDO ";
                lblEstadoServicio.BackColor = Color.IndianRed;
                lblEstadoServicio.ForeColor = Color.White;

                btnIniciar.Enabled = true;
                btnDetener.Enabled = false;

                btnIniciar.BackColor = Color.FromArgb(25, 135, 84);
                btnDetener.BackColor = Color.Gray;

                lblSonando.Text = "SISTEMA INACTIVO";
                lblSonando.ForeColor = Color.Red;
                pbProgreso.Value = 0;
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            _playerService.DetenerReproduccion();
            _schedulerService.Detener();

            _schedulerService.Iniciar();
            ActualizarEstadoVisual(true);
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            ActualizarEstadoAudio();
            CalcularProximoEvento();
        }

        private void ActualizarEstadoAudio()
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");

            if (_playerService.IsPlaying)
            {
                lblSonando.Text = "REPRODUCIENDO AHORA...";
                lblSonando.ForeColor = Color.SeaGreen;
                pbProgreso.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                if (btnDetener.Enabled)
                {
                    lblSonando.Text = "En espera de evento...";
                    lblSonando.ForeColor = Color.DimGray;
                    pbProgreso.Style = ProgressBarStyle.Blocks;
                    pbProgreso.Value = 0;
                }
            }
        }

        private void CalcularProximoEvento()
        {
            try
            {
                var now = DateTime.Now;
                var horarios = _horarioRepo.ObtenerHorariosActivos();

                var proximo = horarios
                    .Where(h => h.InicioRegla.TimeOfDay > now.TimeOfDay)
                    .OrderBy(h => h.InicioRegla.TimeOfDay)
                    .FirstOrDefault();

                if (proximo != null)
                {
                    var falta = proximo.InicioRegla.TimeOfDay - now.TimeOfDay;
                    lblProximoEvento.Text = $"{proximo.InicioRegla:HH:mm} - {proximo.Nombre} (en {falta.Hours:00}:{falta.Minutes:00}:{falta.Seconds:00})";
                    lblProximoEvento.ForeColor = Color.Black;
                }
                else
                {
                    lblProximoEvento.Text = "Sin más eventos hoy";
                    lblProximoEvento.ForeColor = Color.Gray;
                }
            }
            catch { }
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    if (f.WindowState == FormWindowState.Minimized) f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _schedulerService.Detener();
            _playerService.DetenerReproduccion();
            base.OnFormClosed(e);
        }
    }
}