using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmBrowListas : Form
    {
        private readonly ListaRepository _repository = new ListaRepository();

        public FrmBrowListas()
        {
            InitializeComponent();
        }

        private void FrmBrowListas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = _repository.ObtenerTodas();
                PersonalizarGrid();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos.");
            }
        }

        private void PersonalizarGrid()
        {
            if (dgvDatos.Columns.Contains("ListaID"))
                dgvDatos.Columns["ListaID"].Visible = false;

            if (dgvDatos.Columns.Contains("Nombre"))
                dgvDatos.Columns["Nombre"].HeaderText = "Nombre de Lista";

            if (dgvDatos.Columns.Contains("Descripcion"))
                dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";

            if (dgvDatos.Columns.Contains("ModoReproduccion"))
                dgvDatos.Columns["ModoReproduccion"].HeaderText = "Modo de Reproducción";

            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.MultiSelect = false;
            dgvDatos.AllowUserToResizeRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                Lista item = (Lista)dgvDatos.CurrentRow.DataBoundItem;
                FrmLista frm = new FrmLista(item.ListaID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmLista frm = new FrmLista(null);
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
                if (MessageBox.Show("¿Eliminar lista?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Lista item = (Lista)dgvDatos.CurrentRow.DataBoundItem;
                    _repository.Eliminar(item.ListaID);
                    CargarDatos();
                }
            }
        }
    }
}