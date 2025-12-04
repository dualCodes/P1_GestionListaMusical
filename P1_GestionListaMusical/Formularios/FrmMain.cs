using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Servicios;
using System.Drawing;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmMain : Form
    {
        private readonly SchedulerService _schedulerService = new SchedulerService();
        private readonly AudioPlayerService _playerService = new AudioPlayerService();

        public FrmMain()
        {
            InitializeComponent();
            _schedulerService.Iniciar();
            uiTimer.Start();
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
            lblEstado.Text = "Planificador Iniciado";
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            _playerService.DetenerReproduccion();
            _schedulerService.Detener();
            lblEstado.Text = "Audio y Planificador Detenidos";
        }

        private void uiTimer_Tick(object sender, EventArgs e)
        {
            if (_playerService.IsPlaying)
            {
                lblEstado.Text = "Reproduciendo...";
                lblEstado.BackColor = Color.LightGreen;
            }
            else
            {
                lblEstado.BackColor = SystemColors.Control;
            }
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
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
            Form form = new T();
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