using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmCancion : Form
    {
        private readonly CancionRepository _repository = new CancionRepository();
        private Cancion _cancion;

        public FrmCancion(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                _cancion = _repository.ObtenerPorId(id.Value);
                CargarDatos();
            }
            else
            {
                _cancion = new Cancion();
            }
        }

        private void CargarDatos()
        {
            txtTitulo.Text = _cancion.Titulo;
            txtArtista.Text = _cancion.Artista;
            txtRuta.Text = _cancion.RutaArchivo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text) || string.IsNullOrEmpty(txtRuta.Text))
            {
                MessageBox.Show("Datos incompletos");
                return;
            }

            _cancion.Titulo = txtTitulo.Text;
            _cancion.Artista = txtArtista.Text;
            _cancion.RutaArchivo = txtRuta.Text;

            if (_cancion.CancionID == 0)
                _repository.Insertar(_cancion);
            else
                _repository.Actualizar(_cancion);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}