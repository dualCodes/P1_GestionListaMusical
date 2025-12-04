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
                dgvDatos.DataSource = _repository.ObtenerTodas();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos.");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cancion item = (Cancion)dgvDatos.CurrentRow.DataBoundItem;
                    _repository.Eliminar(item.CancionID);
                    CargarDatos();
                }
            }
        }
    }
}