using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmHorario : Form
    {
        private readonly HorarioRepository _horarioRepo = new HorarioRepository();
        private readonly ListaRepository _listaRepo = new ListaRepository();
        private Horario _horario;

        public FrmHorario(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                _horario = _horarioRepo.ObtenerPorId(id.Value);
                this.Text = "Editar Evento";
            }
            else
            {
                _horario = new Horario
                {
                    EstaActivo = true,
                    InicioRegla = DateTime.Now
                };
            }
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            CargarComboListas();
            CargarDatos();
        }

        private void CargarComboListas()
        {
            var listas = _listaRepo.ObtenerTodas();
            cboListas.DataSource = listas;
            cboListas.DisplayMember = "Nombre";
            cboListas.ValueMember = "ListaID";
        }

        private void CargarDatos()
        {
            txtNombre.Text = _horario.Nombre;
            dtpHora.Value = _horario.InicioRegla;

            if (_horario.ListaID > 0)
                cboListas.SelectedValue = _horario.ListaID;

            chkRepetir.Checked = !string.IsNullOrEmpty(_horario.ReglaRRule);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || cboListas.SelectedValue == null)
            {
                MessageBox.Show("Faltan datos obligatorios.");
                return;
            }

            _horario.Nombre = txtNombre.Text;
            _horario.ListaID = (int)cboListas.SelectedValue;

            DateTime fechaHoy = DateTime.Today;
            _horario.InicioRegla = new DateTime(fechaHoy.Year, fechaHoy.Month, fechaHoy.Day,
                                                dtpHora.Value.Hour, dtpHora.Value.Minute, 0);

            if (chkRepetir.Checked)
            {
                _horario.ReglaRRule = "FREQ=DAILY";
            }
            else
            {
                _horario.ReglaRRule = "";
            }

            if (_horario.EventoID == 0)
                _horarioRepo.Insertar(_horario);
            else
                _horarioRepo.Actualizar(_horario);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}