namespace P1_GestionListaMusical.Formularios
{
    partial class FrmLista
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
            pnTop = new Panel();
            cboModo = new ComboBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            pnBottom = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnCenter = new Panel();
            tlpCuerpo = new TableLayoutPanel();
            lblDisp = new Label();
            lblAsign = new Label();
            dgvDisponibles = new DataGridView();
            pnBotones = new Panel();
            btnQuitar = new Button();
            btnAgregar = new Button();
            dgvAsignadas = new DataGridView();
            pnTop.SuspendLayout();
            pnBottom.SuspendLayout();
            pnCenter.SuspendLayout();
            tlpCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibles).BeginInit();
            pnBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignadas).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(cboModo);
            pnTop.Controls.Add(label3);
            pnTop.Controls.Add(txtDescripcion);
            pnTop.Controls.Add(label2);
            pnTop.Controls.Add(txtNombre);
            pnTop.Controls.Add(label1);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(900, 100);
            pnTop.TabIndex = 0;
            // 
            // cboModo
            // 
            cboModo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModo.FormattingEnabled = true;
            cboModo.Items.AddRange(new object[] { "Secuencial", "Aleatorio" });
            cboModo.Location = new Point(80, 60);
            cboModo.Name = "cboModo";
            cboModo.Size = new Size(180, 23);
            cboModo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 63);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Modo:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(360, 20);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(527, 63);
            txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 23);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnGuardar);
            pnBottom.Controls.Add(btnCancelar);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 511);
            pnBottom.Name = "pnBottom";
            pnBottom.Size = new Size(900, 50);
            pnBottom.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(680, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.Location = new Point(790, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cerrar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnCenter
            // 
            pnCenter.Controls.Add(tlpCuerpo);
            pnCenter.Dock = DockStyle.Fill;
            pnCenter.Location = new Point(0, 100);
            pnCenter.Name = "pnCenter";
            pnCenter.Padding = new Padding(10);
            pnCenter.Size = new Size(900, 411);
            pnCenter.TabIndex = 1;
            // 
            // tlpCuerpo
            // 
            tlpCuerpo.ColumnCount = 3;
            tlpCuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlpCuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCuerpo.Controls.Add(lblDisp, 0, 0);
            tlpCuerpo.Controls.Add(lblAsign, 2, 0);
            tlpCuerpo.Controls.Add(dgvDisponibles, 0, 1);
            tlpCuerpo.Controls.Add(pnBotones, 1, 1);
            tlpCuerpo.Controls.Add(dgvAsignadas, 2, 1);
            tlpCuerpo.Dock = DockStyle.Fill;
            tlpCuerpo.Location = new Point(10, 10);
            tlpCuerpo.Name = "tlpCuerpo";
            tlpCuerpo.RowCount = 2;
            tlpCuerpo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpCuerpo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCuerpo.Size = new Size(880, 391);
            tlpCuerpo.TabIndex = 2;
            // 
            // lblDisp
            // 
            lblDisp.AutoSize = true;
            lblDisp.Dock = DockStyle.Fill;
            lblDisp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDisp.Location = new Point(3, 0);
            lblDisp.Name = "lblDisp";
            lblDisp.Size = new Size(404, 25);
            lblDisp.TabIndex = 0;
            lblDisp.Text = "Canciones Disponibles (Biblioteca)";
            lblDisp.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblAsign
            // 
            lblAsign.AutoSize = true;
            lblAsign.Dock = DockStyle.Fill;
            lblAsign.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAsign.Location = new Point(473, 0);
            lblAsign.Name = "lblAsign";
            lblAsign.Size = new Size(404, 25);
            lblAsign.TabIndex = 1;
            lblAsign.Text = "Contenido de la Lista";
            lblAsign.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgvDisponibles
            // 
            dgvDisponibles.AllowUserToAddRows = false;
            dgvDisponibles.AllowUserToDeleteRows = false;
            dgvDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisponibles.Dock = DockStyle.Fill;
            dgvDisponibles.Location = new Point(3, 28);
            dgvDisponibles.Name = "dgvDisponibles";
            dgvDisponibles.ReadOnly = true;
            dgvDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDisponibles.Size = new Size(404, 360);
            dgvDisponibles.TabIndex = 0;
            // 
            // pnBotones
            // 
            pnBotones.Controls.Add(btnQuitar);
            pnBotones.Controls.Add(btnAgregar);
            pnBotones.Dock = DockStyle.Fill;
            pnBotones.Location = new Point(413, 28);
            pnBotones.Name = "pnBotones";
            pnBotones.Size = new Size(54, 360);
            pnBotones.TabIndex = 1;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.None;
            btnQuitar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuitar.Location = new Point(7, 190);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(40, 40);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "<<";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(7, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(40, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = ">>";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAsignadas
            // 
            dgvAsignadas.AllowUserToAddRows = false;
            dgvAsignadas.AllowUserToDeleteRows = false;
            dgvAsignadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsignadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignadas.Dock = DockStyle.Fill;
            dgvAsignadas.Location = new Point(473, 28);
            dgvAsignadas.Name = "dgvAsignadas";
            dgvAsignadas.ReadOnly = true;
            dgvAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsignadas.Size = new Size(404, 360);
            dgvAsignadas.TabIndex = 2;
            // 
            // FrmLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 561);
            Controls.Add(pnCenter);
            Controls.Add(pnBottom);
            Controls.Add(pnTop);
            MinimumSize = new Size(600, 400);
            Name = "FrmLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editor de Lista";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            pnBottom.ResumeLayout(false);
            pnCenter.ResumeLayout(false);
            tlpCuerpo.ResumeLayout(false);
            tlpCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibles).EndInit();
            pnBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsignadas).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.TableLayoutPanel tlpCuerpo;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Panel pnBotones;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAsignadas;
        private System.Windows.Forms.Label lblAsign;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.ComboBox cboModo;
        private System.Windows.Forms.Label label3;
    }
}