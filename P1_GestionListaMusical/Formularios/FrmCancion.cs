using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;
using System.IO;
using NAudio.Wave;

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
                this.Text = "Modificar Canción";
            }
            else
            {
                _cancion = new Cancion();
                this.Text = "Importar Audio";
            }
            CargarDatosFormulario();
        }

        private void CargarDatosFormulario()
        {
            txtTitulo.Text = _cancion.Titulo;
            txtArtista.Text = _cancion.Artista;
            txtRuta.Text = _cancion.RutaArchivo;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Audio|*.mp3;*.wav;*.wma";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = ofd.FileName;

                    if (string.IsNullOrEmpty(txtTitulo.Text))
                    {
                        txtTitulo.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                    }

                    try
                    {
                        using (var reader = new AudioFileReader(ofd.FileName))
                        {
                            _cancion.DuracionSegundos = (int)reader.TotalTime.TotalSeconds;
                        }
                    }
                    catch
                    {
                        _cancion.DuracionSegundos = 0;
                    }
                }
            }
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

            try
            {
                if (_cancion.CancionID == 0)
                    _repository.Insertar(_cancion);
                else
                    _repository.Actualizar(_cancion);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}