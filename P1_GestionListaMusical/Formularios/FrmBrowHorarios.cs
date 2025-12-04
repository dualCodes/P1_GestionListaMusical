using System;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;
using System.Collections.Generic;

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
                dgvDatos.DataSource = _repository.ObtenerHorariosActivos();
            }
            catch
            {
                MessageBox.Show("Error al cargar datos.");
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