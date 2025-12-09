using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmBrowHorarios : Form
    {
        private readonly HorarioRepository _repository = new HorarioRepository();

        public FrmBrowHorarios()
        {
            InitializeComponent();
        }

        private void FrmBrowHorarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = _repository.ObtenerTodos();
                PersonalizarGrid();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos.");
            }
        }

        private void PersonalizarGrid()
        {
            dgvDatos.Columns["EventoID"].Visible = false;
            dgvDatos.Columns["ListaID"].Visible = false;
            dgvDatos.Columns["Excepciones"].Visible = false;
            dgvDatos.Columns["ReglaRRule"].Visible = false;

            dgvDatos.Columns["Nombre"].HeaderText = "Nombre del Evento";
            dgvDatos.Columns["EstaActivo"].HeaderText = "Activo";
            dgvDatos.Columns["InicioRegla"].HeaderText = "Hora Inicio";

            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;
            dgvDatos.AllowUserToResizeRows = false;
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditarRegistroActual();
            }
        }

        private void EditarRegistroActual()
        {
            if (dgvDatos.CurrentRow != null)
            {
                Horario item = (Horario)dgvDatos.CurrentRow.DataBoundItem;
                FrmHorario frm = new FrmHorario(item.EventoID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmHorario frm = new FrmHorario(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarRegistroActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Horario item = (Horario)dgvDatos.CurrentRow.DataBoundItem;
                    _repository.Eliminar(item.EventoID);
                    CargarDatos();
                }
            }
        }
    }
}