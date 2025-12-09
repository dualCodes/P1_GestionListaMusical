using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmBrowCanciones : Form
    {
        private readonly CancionRepository _repository = new CancionRepository();

        public FrmBrowCanciones()
        {
            InitializeComponent();
        }

        private void FrmBrowCanciones_Load(object sender, EventArgs e)
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
            if (dgvDatos.Columns.Contains("CancionID"))
                dgvDatos.Columns["CancionID"].Visible = false;

            if (dgvDatos.Columns.Contains("Titulo"))
                dgvDatos.Columns["Titulo"].HeaderText = "Título";

            if (dgvDatos.Columns.Contains("RutaArchivo"))
                dgvDatos.Columns["RutaArchivo"].HeaderText = "Ruta del Archivo";

            if (dgvDatos.Columns.Contains("DuracionSegundos"))
            {
                dgvDatos.Columns["DuracionSegundos"].HeaderText = "Duración (s)";
                dgvDatos.Columns["DuracionSegundos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

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
                Cancion item = (Cancion)dgvDatos.CurrentRow.DataBoundItem;
                FrmCancion frm = new FrmCancion(item.CancionID);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCancion frm = new FrmCancion(null);
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
                if (MessageBox.Show("¿Eliminar canción?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cancion item = (Cancion)dgvDatos.CurrentRow.DataBoundItem;
                    _repository.Eliminar(item.CancionID);
                    CargarDatos();
                }
            }
        }
    }
}