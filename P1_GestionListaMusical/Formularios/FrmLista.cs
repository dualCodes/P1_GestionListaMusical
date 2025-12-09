using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmLista : Form
    {
        private readonly ListaRepository _listaRepo = new ListaRepository();
        private readonly CancionRepository _cancionRepo = new CancionRepository();
        private Lista _lista;
        private int _listaIdActual = 0;

        public FrmLista(int? id)
        {
            InitializeComponent();

            if (id.HasValue)
            {
                _listaIdActual = id.Value;
                _lista = _listaRepo.ObtenerPorId(_listaIdActual);
                this.Text = "Editar Lista";
            }
            else
            {
                _lista = new Lista();
                this.Text = "Nueva Lista";
                tlpCuerpo.Enabled = false;
            }

            CargarDatosCabecera();
            CargarBiblioteca();

            if (_listaIdActual > 0)
            {
                CargarContenidoLista();
            }
        }

        private void CargarDatosCabecera()
        {
            txtNombre.Text = _lista.Nombre;
            txtDescripcion.Text = _lista.Descripcion;
            cboModo.SelectedItem = _lista.ModoReproduccion ?? "Secuencial";
        }

        private void CargarBiblioteca()
        {
            dgvDisponibles.DataSource = null;
            dgvDisponibles.DataSource = _cancionRepo.ObtenerTodas();
            OcultarIds(dgvDisponibles);
        }

        private void CargarContenidoLista()
        {
            dgvAsignadas.DataSource = null;
            dgvAsignadas.DataSource = _listaRepo.ObtenerCancionesDeLista(_listaIdActual);
            OcultarIds(dgvAsignadas);
        }

        private void OcultarIds(DataGridView dgv)
        {
            if (dgv.Columns.Contains("CancionID")) dgv.Columns["CancionID"].Visible = false;
            if (dgv.Columns.Contains("RutaArchivo")) dgv.Columns["RutaArchivo"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvDisponibles.CurrentRow != null)
            {
                var cancion = (Cancion)dgvDisponibles.CurrentRow.DataBoundItem;
                _listaRepo.AgregarCancionALista(_listaIdActual, cancion.CancionID);
                CargarContenidoLista();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvAsignadas.CurrentRow != null)
            {
                var cancion = (Cancion)dgvAsignadas.CurrentRow.DataBoundItem;
                _listaRepo.QuitarCancionDeLista(_listaIdActual, cancion.CancionID);
                CargarContenidoLista();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ponle un nombre a la lista.");
                return;
            }

            _lista.Nombre = txtNombre.Text;
            _lista.Descripcion = txtDescripcion.Text;
            _lista.ModoReproduccion = cboModo.SelectedItem?.ToString() ?? "Secuencial";

            if (_listaIdActual == 0)
            {
                _listaIdActual = _listaRepo.Insertar(_lista);
                _lista.ListaID = _listaIdActual;

                tlpCuerpo.Enabled = true;
                CargarContenidoLista();
            }
            else
            {
                _listaRepo.Actualizar(_lista);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}