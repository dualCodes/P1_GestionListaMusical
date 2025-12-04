using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmLista : Form
    {
        private readonly ListaRepository _repository = new ListaRepository();
        private Lista _lista;

        public FrmLista(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                _lista = _repository.ObtenerPorId(id.Value);
                CargarDatos();
            }
            else
            {
                _lista = new Lista();
            }
        }

        private void CargarDatos()
        {
            txtNombre.Text = _lista.Nombre;
            txtDescripcion.Text = _lista.Descripcion;
            cmbModo.Text = _lista.ModoReproduccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Nombre requerido");
                return;
            }

            _lista.Nombre = txtNombre.Text;
            _lista.Descripcion = txtDescripcion.Text;
            _lista.ModoReproduccion = cmbModo.Text;

            if (_lista.ListaID == 0)
                _repository.Insertar(_lista);
            else
                _repository.Actualizar(_lista);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}