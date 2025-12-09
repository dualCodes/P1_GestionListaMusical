using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Servicios;

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
            AplicarEstiloModerno();

            _schedulerService.Iniciar();
            uiTimer.Start();
        }

        private void AplicarEstiloModerno()
        {
            tsMenu.Renderer = new MiRenderizadorModerno();

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
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            _playerService.DetenerReproduccion();
            _schedulerService.Detener();

            lblSonando.Text = "SILENCIO FORZADO";
            lblSonando.ForeColor = Color.Red;
            pbProgreso.Value = 0;
        }

        private void btnSaltar_Click(object sender, EventArgs e)
        {
            if (_playerService.IsPlaying)
            {
                _playerService.DetenerReproduccion();
            }
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            ActualizarEstadoAudio();
            CalcularProximoEvento();
        }

        private void ActualizarEstadoAudio()
        {
            if (_playerService.IsPlaying)
            {
                lblSonando.Text = "REPRODUCIENDO AHORA...";
                lblSonando.ForeColor = Color.Green;

                pbProgreso.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                lblSonando.Text = "En espera / Silencio";
                lblSonando.ForeColor = Color.DimGray;
                pbProgreso.Style = ProgressBarStyle.Blocks;
                pbProgreso.Value = 0;
            }
        }

        private void CalcularProximoEvento()
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
                lblProximoEvento.Text = $"{proximo.InicioRegla:HH:mm} - {proximo.Nombre} (en {falta.Hours:00}:{falta.Minutes:00})";
            }
            else
            {
                lblProximoEvento.Text = "Sin más eventos hoy";
            }
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
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

    public class MiRenderizadorModerno : ToolStripProfessionalRenderer
    {
        public MiRenderizadorModerno() : base(new MisColores()) { }
    }

    public class MisColores : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin => Color.FromArgb(26, 32, 40);
        public override Color ToolStripGradientMiddle => Color.FromArgb(26, 32, 40);
        public override Color ToolStripGradientEnd => Color.FromArgb(26, 32, 40);

        public override Color ButtonSelectedGradientBegin => Color.FromArgb(45, 55, 70);
        public override Color ButtonSelectedGradientMiddle => Color.FromArgb(45, 55, 70);
        public override Color ButtonSelectedGradientEnd => Color.FromArgb(45, 55, 70);
        public override Color ButtonSelectedBorder => Color.FromArgb(45, 55, 70);

        public override Color ButtonPressedGradientBegin => Color.FromArgb(60, 120, 200);
        public override Color ButtonPressedGradientMiddle => Color.FromArgb(60, 120, 200);
        public override Color ButtonPressedGradientEnd => Color.FromArgb(60, 120, 200);
        public override Color ButtonPressedBorder => Color.FromArgb(60, 120, 200);
    }
}