namespace P1_GestionListaMusical.Formularios
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNavHorarios;
        private System.Windows.Forms.ToolStripButton btnNavCanciones;
        private System.Windows.Forms.ToolStripButton btnNavListas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnIniciar;
        private System.Windows.Forms.ToolStripButton btnDetener;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblReloj;
        private System.Windows.Forms.Timer uiTimer;

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
            this.components = new System.ComponentModel.Container();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNavHorarios = new System.Windows.Forms.ToolStripButton();
            this.btnNavCanciones = new System.Windows.Forms.ToolStripButton();
            this.btnNavListas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIniciar = new System.Windows.Forms.ToolStripButton();
            this.btnDetener = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.tsMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNavHorarios,
            this.btnNavCanciones,
            this.btnNavListas,
            this.toolStripSeparator1,
            this.btnIniciar,
            this.btnDetener});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 1;
            // 
            // btnNavHorarios
            // 
            this.btnNavHorarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavHorarios.Name = "btnNavHorarios";
            this.btnNavHorarios.Size = new System.Drawing.Size(57, 22);
            this.btnNavHorarios.Text = "Horarios";
            this.btnNavHorarios.Click += new System.EventHandler(this.btnNavHorarios_Click);
            // 
            // btnNavCanciones
            // 
            this.btnNavCanciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavCanciones.Name = "btnNavCanciones";
            this.btnNavCanciones.Size = new System.Drawing.Size(67, 22);
            this.btnNavCanciones.Text = "Canciones";
            this.btnNavCanciones.Click += new System.EventHandler(this.btnNavCanciones_Click);
            // 
            // btnNavListas
            // 
            this.btnNavListas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavListas.Name = "btnNavListas";
            this.btnNavListas.Size = new System.Drawing.Size(40, 22);
            this.btnNavListas.Text = "Listas";
            this.btnNavListas.Click += new System.EventHandler(this.btnNavListas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnIniciar
            // 
            this.btnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(42, 22);
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(51, 22);
            this.btnDetener.Text = "Detener";
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblReloj});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(118, 17);
            this.lblEstado.Text = "Sistema Preparado...";
            // 
            // lblReloj
            // 
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(667, 17);
            this.lblReloj.Spring = true;
            this.lblReloj.Text = "00:00:00";
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTimer
            // 
            this.uiTimer.Interval = 1000;
            this.uiTimer.Tick += new System.EventHandler(this.uiTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMenu);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Sistema de Timbre Musical";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}