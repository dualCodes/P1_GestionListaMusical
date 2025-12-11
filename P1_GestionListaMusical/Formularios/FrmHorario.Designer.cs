namespace P1_GestionListaMusical.Formularios
{
    partial class FrmHorario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            dtpHora = new DateTimePicker();
            label4 = new Label();
            cboFrecuencia = new ComboBox();
            label3 = new Label();
            cboListas = new ComboBox();
            grpSemanal = new GroupBox();
            chkDomingo = new CheckBox();
            chkSabado = new CheckBox();
            chkViernes = new CheckBox();
            chkJueves = new CheckBox();
            chkMiercoles = new CheckBox();
            chkMartes = new CheckBox();
            chkLunes = new CheckBox();
            grpMensual = new GroupBox();
            label5 = new Label();
            numDiaMes = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grpSemanal.SuspendLayout();
            grpMensual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiaMes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Evento:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Hora de Inicio:";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(20, 95);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(100, 23);
            dtpHora.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 75);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Repetición:";
            // 
            // cboFrecuencia
            // 
            cboFrecuencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFrecuencia.FormattingEnabled = true;
            cboFrecuencia.Items.AddRange(new object[] { "Una sola vez", "Diario", "Semanal", "Mensual" });
            cboFrecuencia.Location = new Point(140, 95);
            cboFrecuencia.Name = "cboFrecuencia";
            cboFrecuencia.Size = new Size(220, 23);
            cboFrecuencia.TabIndex = 5;
            cboFrecuencia.SelectedIndexChanged += cboFrecuencia_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 135);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Lista a Reproducir:";
            // 
            // cboListas
            // 
            cboListas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboListas.FormattingEnabled = true;
            cboListas.Location = new Point(20, 155);
            cboListas.Name = "cboListas";
            cboListas.Size = new Size(340, 23);
            cboListas.TabIndex = 7;
            // 
            // grpSemanal
            // 
            grpSemanal.Controls.Add(chkDomingo);
            grpSemanal.Controls.Add(chkSabado);
            grpSemanal.Controls.Add(chkViernes);
            grpSemanal.Controls.Add(chkJueves);
            grpSemanal.Controls.Add(chkMiercoles);
            grpSemanal.Controls.Add(chkMartes);
            grpSemanal.Controls.Add(chkLunes);
            grpSemanal.Location = new Point(20, 190);
            grpSemanal.Name = "grpSemanal";
            grpSemanal.Size = new Size(340, 100);
            grpSemanal.TabIndex = 8;
            grpSemanal.TabStop = false;
            grpSemanal.Text = "Seleccionar Días";
            grpSemanal.Visible = false;
            // 
            // chkDomingo
            // 
            chkDomingo.AutoSize = true;
            chkDomingo.Location = new Point(155, 55);
            chkDomingo.Name = "chkDomingo";
            chkDomingo.Size = new Size(76, 19);
            chkDomingo.TabIndex = 6;
            chkDomingo.Text = "Domingo";
            chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            chkSabado.AutoSize = true;
            chkSabado.Location = new Point(85, 55);
            chkSabado.Name = "chkSabado";
            chkSabado.Size = new Size(65, 19);
            chkSabado.TabIndex = 5;
            chkSabado.Text = "Sábado";
            chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            chkViernes.AutoSize = true;
            chkViernes.Location = new Point(15, 55);
            chkViernes.Name = "chkViernes";
            chkViernes.Size = new Size(64, 19);
            chkViernes.TabIndex = 4;
            chkViernes.Text = "Viernes";
            chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            chkJueves.AutoSize = true;
            chkJueves.Location = new Point(245, 25);
            chkJueves.Name = "chkJueves";
            chkJueves.Size = new Size(60, 19);
            chkJueves.TabIndex = 3;
            chkJueves.Text = "Jueves";
            chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            chkMiercoles.AutoSize = true;
            chkMiercoles.Location = new Point(155, 25);
            chkMiercoles.Name = "chkMiercoles";
            chkMiercoles.Size = new Size(77, 19);
            chkMiercoles.TabIndex = 2;
            chkMiercoles.Text = "Miércoles";
            chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            chkMartes.AutoSize = true;
            chkMartes.Location = new Point(85, 25);
            chkMartes.Name = "chkMartes";
            chkMartes.Size = new Size(62, 19);
            chkMartes.TabIndex = 1;
            chkMartes.Text = "Martes";
            chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            chkLunes.AutoSize = true;
            chkLunes.Location = new Point(15, 25);
            chkLunes.Name = "chkLunes";
            chkLunes.Size = new Size(57, 19);
            chkLunes.TabIndex = 0;
            chkLunes.Text = "Lunes";
            chkLunes.UseVisualStyleBackColor = true;
            // 
            // grpMensual
            // 
            grpMensual.Controls.Add(label5);
            grpMensual.Controls.Add(numDiaMes);
            grpMensual.Location = new Point(20, 190);
            grpMensual.Name = "grpMensual";
            grpMensual.Size = new Size(340, 100);
            grpMensual.TabIndex = 9;
            grpMensual.TabStop = false;
            grpMensual.Text = "Configuración Mensual";
            grpMensual.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 40);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 1;
            label5.Text = "Ejecutar el día número:";
            // 
            // numDiaMes
            // 
            numDiaMes.Location = new Point(160, 38);
            numDiaMes.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numDiaMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDiaMes.Name = "numDiaMes";
            numDiaMes.Size = new Size(60, 23);
            numDiaMes.TabIndex = 0;
            numDiaMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(180, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 360);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(grpMensual);
            Controls.Add(grpSemanal);
            Controls.Add(cboListas);
            Controls.Add(label3);
            Controls.Add(cboFrecuencia);
            Controls.Add(label4);
            Controls.Add(dtpHora);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmHorario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Programar Horario";
            Load += FrmHorario_Load;
            grpSemanal.ResumeLayout(false);
            grpSemanal.PerformLayout();
            grpMensual.ResumeLayout(false);
            grpMensual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiaMes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFrecuencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboListas;
        private System.Windows.Forms.GroupBox grpSemanal;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.GroupBox grpMensual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDiaMes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}