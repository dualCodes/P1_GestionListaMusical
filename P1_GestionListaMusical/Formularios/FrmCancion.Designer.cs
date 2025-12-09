namespace P1_GestionListaMusical.Formularios
{
    partial class FrmCancion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnBtns;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExaminar;

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
            this.pnBtns = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnData = new System.Windows.Forms.Panel();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBtns.SuspendLayout();
            this.pnData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBtns
            // 
            this.pnBtns.Controls.Add(this.btnCancelar);
            this.pnBtns.Controls.Add(this.btnGuardar);
            this.pnBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtns.Location = new System.Drawing.Point(0, 150);
            this.pnBtns.Name = "pnBtns";
            this.pnBtns.Size = new System.Drawing.Size(484, 50);
            this.pnBtns.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(260, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.btnExaminar);
            this.pnData.Controls.Add(this.txtRuta);
            this.pnData.Controls.Add(this.label3);
            this.pnData.Controls.Add(this.txtArtista);
            this.pnData.Controls.Add(this.label2);
            this.pnData.Controls.Add(this.txtTitulo);
            this.pnData.Controls.Add(this.label1);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 0);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(484, 150);
            this.pnData.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(400, 100);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(70, 23);
            this.btnExaminar.TabIndex = 6;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(100, 100);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(290, 23);
            this.txtRuta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ruta Archivo:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(100, 60);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(370, 23);
            this.txtArtista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artista:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(100, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(370, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // FrmCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 200);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCancion";
            this.Text = "Datos de Canción";
            this.pnBtns.ResumeLayout(false);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}