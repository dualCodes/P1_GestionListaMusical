using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using P1_GestionListaMusical.Datos;
using P1_GestionListaMusical.Modelos;

namespace P1_GestionListaMusical.Formularios
{
    public partial class FrmHorario : Form
    {
        private readonly HorarioRepository _horarioRepo = new HorarioRepository();
        private readonly ListaRepository _listaRepo = new ListaRepository();
        private Horario _horario;

        public FrmHorario(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                _horario = _horarioRepo.ObtenerPorId(id.Value);
                this.Text = "Editar Evento";
            }
            else
            {
                _horario = new Horario
                {
                    EstaActivo = true,
                    InicioRegla = DateTime.Now
                };
            }
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            CargarComboListas();
            CargarDatos();
        }

        private void CargarComboListas()
        {
            cboListas.DataSource = _listaRepo.ObtenerTodas();
            cboListas.DisplayMember = "Nombre";
            cboListas.ValueMember = "ListaID";
        }

        private void CargarDatos()
        {
            txtNombre.Text = _horario.Nombre;
            chkActivo.Checked = _horario.EstaActivo;
            dtpHora.Value = _horario.InicioRegla;

            if (_horario.ListaID > 0) cboListas.SelectedValue = _horario.ListaID;

            InterpretarRegla(_horario.ReglaRRule);
        }

        private void cboFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cboFrecuencia.SelectedItem?.ToString();
            grpSemanal.Visible = (seleccion == "Semanal");
            grpMensual.Visible = (seleccion == "Mensual");
        }

        private void InterpretarRegla(string rrule)
        {
            if (string.IsNullOrEmpty(rrule))
            {
                cboFrecuencia.SelectedIndex = 0;
                return;
            }

            if (rrule.Contains("FREQ=DAILY"))
            {
                cboFrecuencia.SelectedIndex = 1;
            }
            else if (rrule.Contains("FREQ=MONTHLY"))
            {
                cboFrecuencia.SelectedIndex = 3;
                var match = Regex.Match(rrule, @"BYMONTHDAY=(\d+)");
                if (match.Success && int.TryParse(match.Groups[1].Value, out int dia))
                {
                    numDiaMes.Value = Math.Min(Math.Max(dia, 1), 31);
                }
            }
            else if (rrule.Contains("FREQ=WEEKLY"))
            {
                cboFrecuencia.SelectedIndex = 2;
                chkLunes.Checked = rrule.Contains("MO");
                chkMartes.Checked = rrule.Contains("TU");
                chkMiercoles.Checked = rrule.Contains("WE");
                chkJueves.Checked = rrule.Contains("TH");
                chkViernes.Checked = rrule.Contains("FR");
                chkSabado.Checked = rrule.Contains("SA");
                chkDomingo.Checked = rrule.Contains("SU");
            }
            else
            {
                cboFrecuencia.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || cboListas.SelectedValue == null)
            {
                MessageBox.Show("Faltan datos obligatorios.");
                return;
            }

            _horario.Nombre = txtNombre.Text;
            _horario.EstaActivo = chkActivo.Checked;
            _horario.ListaID = (int)cboListas.SelectedValue;

            var now = DateTime.Now;
            _horario.InicioRegla = new DateTime(now.Year, now.Month, now.Day,
                                                dtpHora.Value.Hour, dtpHora.Value.Minute, 0);

            _horario.ReglaRRule = GenerarRegla();

            if (_horario.EventoID == 0)
                _horarioRepo.Insertar(_horario);
            else
                _horarioRepo.Actualizar(_horario);

            DialogResult = DialogResult.OK;
        }

        private string GenerarRegla()
        {
            string seleccion = cboFrecuencia.SelectedItem?.ToString();

            if (seleccion == "Una sola vez") return string.Empty;

            if (seleccion == "Diario") return "FREQ=DAILY";

            if (seleccion == "Mensual")
            {
                return $"FREQ=MONTHLY;BYMONTHDAY={(int)numDiaMes.Value}";
            }

            if (seleccion == "Semanal")
            {
                var dias = new List<string>();
                if (chkLunes.Checked) dias.Add("MO");
                if (chkMartes.Checked) dias.Add("TU");
                if (chkMiercoles.Checked) dias.Add("WE");
                if (chkJueves.Checked) dias.Add("TH");
                if (chkViernes.Checked) dias.Add("FR");
                if (chkSabado.Checked) dias.Add("SA");
                if (chkDomingo.Checked) dias.Add("SU");

                if (dias.Count == 0) return string.Empty;
                return $"FREQ=WEEKLY;BYDAY={string.Join(",", dias)}";
            }

            return string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}