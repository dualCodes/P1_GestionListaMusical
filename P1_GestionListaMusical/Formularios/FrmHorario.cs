using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmHorario : Form
    {
        private readonly HorarioRepository _repoHorario = new HorarioRepository();
        private readonly ListaRepository _repoLista = new ListaRepository();
        private Horario _horario;

        public FrmHorario(int? id)
        {
            InitializeComponent();
            CargarListas();
            if (id.HasValue)
            {
                _horario = _repoHorario.ObtenerPorId(id.Value);
                CargarDatos();
            }
            else
            {
                _horario = new Horario();
            }
        }

        private void CargarListas()
        {
            cmbLista.DataSource = _repoLista.ObtenerTodas();
            cmbLista.DisplayMember = "Nombre";
            cmbLista.ValueMember = "ListaID";
        }

        private void CargarDatos()
        {
            txtNombre.Text = _horario.Nombre;
            chkActivo.Checked = _horario.EstaActivo;
            dtpInicio.Value = _horario.InicioRegla;
            cmbLista.SelectedValue = _horario.ListaID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Nombre requerido");
                return;
            }

            _horario.Nombre = txtNombre.Text;
            _horario.EstaActivo = chkActivo.Checked;
            _horario.InicioRegla = dtpInicio.Value;
            _horario.ListaID = (int)cmbLista.SelectedValue;
            _horario.ReglaRRule = "FREQ=DAILY";

            if (_horario.EventoID == 0)
                _repoHorario.Insertar(_horario);
            else
                _repoHorario.Actualizar(_horario);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}