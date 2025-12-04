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
                dgvDatos.DataSource = _repository.ObtenerTodas();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos.");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Eliminar registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Lista item = (Lista)dgvDatos.CurrentRow.DataBoundItem;
                    _repository.Eliminar(item.ListaID);
                    CargarDatos();
                }
            }
        }
    }
}