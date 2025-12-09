namespace P1_GestionListaMusical.Formularios
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.pnSide = new System.Windows.Forms.Panel();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNavHorarios = new System.Windows.Forms.ToolStripButton();
            this.btnNavCanciones = new System.Windows.Forms.ToolStripButton();
            this.btnNavListas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIniciar = new System.Windows.Forms.ToolStripButton();
            this.btnDetener = new System.Windows.Forms.ToolStripButton();
            this.pnConsole = new System.Windows.Forms.Panel();
            this.pnControlesAudio = new System.Windows.Forms.Panel();
            this.btnSaltar = new System.Windows.Forms.Button();
            this.btnEmergencyStop = new System.Windows.Forms.Button();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblSonando = new System.Windows.Forms.Label();
            this.pnInfoEvento = new System.Windows.Forms.Panel();
            this.lblProximoEvento = new System.Windows.Forms.Label();
            this.lblTituloProximo = new System.Windows.Forms.Label();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.pnSide.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.pnConsole.SuspendLayout();
            this.pnControlesAudio.SuspendLayout();
            this.pnInfoEvento.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.lblTituloApp);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(220, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(730, 40);
            this.pnTop.TabIndex = 1;

            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloApp.Location = new System.Drawing.Point(15, 9);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(263, 21);
            this.lblTituloApp.Text = "SISTEMA DE GESTIÓN DE TIMBRES";

            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnSide.Controls.Add(this.tsMenu);
            this.pnSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSide.Location = new System.Drawing.Point(0, 0);
            this.pnSide.Name = "pnSide";
            this.pnSide.Padding = new System.Windows.Forms.Padding(0);
            this.pnSide.Size = new System.Drawing.Size(220, 530);
            this.pnSide.TabIndex = 0;

            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNavHorarios,
            this.btnNavCanciones,
            this.btnNavListas,
            this.toolStripSeparator1,
            this.btnIniciar,
            this.btnDetener});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tsMenu.Size = new System.Drawing.Size(220, 530);
            this.tsMenu.TabIndex = 0;

            // 
            // btnNavHorarios
            // 
            this.btnNavHorarios.AutoSize = false;
            this.btnNavHorarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnNavHorarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavHorarios.ForeColor = System.Drawing.Color.White;
            this.btnNavHorarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavHorarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnNavHorarios.Name = "btnNavHorarios";
            this.btnNavHorarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavHorarios.Size = new System.Drawing.Size(218, 50);
            this.btnNavHorarios.Text = "  Programación";
            this.btnNavHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHorarios.Click += new System.EventHandler(this.btnNavHorarios_Click);

            // 
            // btnNavCanciones
            // 
            this.btnNavCanciones.AutoSize = false;
            this.btnNavCanciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnNavCanciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavCanciones.ForeColor = System.Drawing.Color.White;
            this.btnNavCanciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavCanciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnNavCanciones.Name = "btnNavCanciones";
            this.btnNavCanciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavCanciones.Size = new System.Drawing.Size(218, 50);
            this.btnNavCanciones.Text = "  Audios";
            this.btnNavCanciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCanciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCanciones.Click += new System.EventHandler(this.btnNavCanciones_Click);

            // 
            // btnNavListas
            // 
            this.btnNavListas.AutoSize = false;
            this.btnNavListas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnNavListas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavListas.ForeColor = System.Drawing.Color.White;
            this.btnNavListas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavListas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnNavListas.Name = "btnNavListas";
            this.btnNavListas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavListas.Size = new System.Drawing.Size(218, 50);
            this.btnNavListas.Text = "  Listas";
            this.btnNavListas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavListas.Click += new System.EventHandler(this.btnNavListas_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);

            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = false;
            this.btnIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciar.ForeColor = System.Drawing.Color.LightGreen;
            this.btnIniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIniciar.Size = new System.Drawing.Size(218, 50);
            this.btnIniciar.Text = "  ARMAR SISTEMA";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            // 
            // btnDetener
            // 
            this.btnDetener.AutoSize = false;
            this.btnDetener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetener.ForeColor = System.Drawing.Color.Salmon;
            this.btnDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetener.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetener.Size = new System.Drawing.Size(218, 50);
            this.btnDetener.Text = "  DESARMAR";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);

            // 
            // pnConsole (Panel Inferior Grande)
            // 
            this.pnConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnConsole.Controls.Add(this.pnControlesAudio);
            this.pnConsole.Controls.Add(this.pnInfoEvento);
            this.pnConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnConsole.Location = new System.Drawing.Point(220, 440);
            this.pnConsole.Name = "pnConsole";
            this.pnConsole.Size = new System.Drawing.Size(730, 90);
            this.pnConsole.TabIndex = 2;

            // 
            // pnInfoEvento
            // 
            this.pnInfoEvento.Controls.Add(this.lblProximoEvento);
            this.pnInfoEvento.Controls.Add(this.lblTituloProximo);
            this.pnInfoEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInfoEvento.Location = new System.Drawing.Point(0, 0);
            this.pnInfoEvento.Name = "pnInfoEvento";
            this.pnInfoEvento.Size = new System.Drawing.Size(300, 88);
            this.pnInfoEvento.TabIndex = 0;

            // 
            // lblTituloProximo
            // 
            this.lblTituloProximo.AutoSize = true;
            this.lblTituloProximo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTituloProximo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloProximo.Location = new System.Drawing.Point(15, 20);
            this.lblTituloProximo.Name = "lblTituloProximo";
            this.lblTituloProximo.Size = new System.Drawing.Size(109, 15);
            this.lblTituloProximo.Text = "PRÓXIMO EVENTO:";

            // 
            // lblProximoEvento
            // 
            this.lblProximoEvento.AutoSize = true;
            this.lblProximoEvento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProximoEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblProximoEvento.Location = new System.Drawing.Point(15, 40);
            this.lblProximoEvento.Name = "lblProximoEvento";
            this.lblProximoEvento.Size = new System.Drawing.Size(185, 25);
            this.lblProximoEvento.Text = "--:-- Sin programar";

            // 
            // pnControlesAudio
            // 
            this.pnControlesAudio.Controls.Add(this.btnSaltar);
            this.pnControlesAudio.Controls.Add(this.btnEmergencyStop);
            this.pnControlesAudio.Controls.Add(this.pbProgreso);
            this.pnControlesAudio.Controls.Add(this.lblSonando);
            this.pnControlesAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlesAudio.Location = new System.Drawing.Point(300, 0);
            this.pnControlesAudio.Name = "pnControlesAudio";
            this.pnControlesAudio.Size = new System.Drawing.Size(428, 88);
            this.pnControlesAudio.TabIndex = 1;

            // 
            // lblSonando
            // 
            this.lblSonando.AutoSize = true;
            this.lblSonando.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonando.Location = new System.Drawing.Point(20, 15);
            this.lblSonando.Name = "lblSonando";
            this.lblSonando.Size = new System.Drawing.Size(95, 19);
            this.lblSonando.Text = "En silencio...";

            // 
            // pbProgreso
            // 
            this.pbProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgreso.Location = new System.Drawing.Point(20, 40);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(200, 10);
            this.pbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgreso.TabIndex = 1;

            // 
            // btnEmergencyStop
            // 
            this.btnEmergencyStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmergencyStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnEmergencyStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmergencyStop.ForeColor = System.Drawing.Color.White;
            this.btnEmergencyStop.Location = new System.Drawing.Point(320, 20);
            this.btnEmergencyStop.Name = "btnEmergencyStop";
            this.btnEmergencyStop.Size = new System.Drawing.Size(90, 40);
            this.btnEmergencyStop.TabIndex = 2;
            this.btnEmergencyStop.Text = "SILENCIO";
            this.btnEmergencyStop.UseVisualStyleBackColor = false;
            this.btnEmergencyStop.Click += new System.EventHandler(this.btnDetener_Click);

            // 
            // btnSaltar
            // 
            this.btnSaltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaltar.BackColor = System.Drawing.Color.White;
            this.btnSaltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaltar.Location = new System.Drawing.Point(230, 20);
            this.btnSaltar.Name = "btnSaltar";
            this.btnSaltar.Size = new System.Drawing.Size(75, 40);
            this.btnSaltar.TabIndex = 3;
            this.btnSaltar.Text = "Saltar >>";
            this.btnSaltar.UseVisualStyleBackColor = false;
            this.btnSaltar.Click += new System.EventHandler(this.btnSaltar_Click);

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
            this.ClientSize = new System.Drawing.Size(950, 530);
            this.Controls.Add(this.pnConsole);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnSide);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Sistema de Gestión Musical";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnSide.ResumeLayout(false);
            this.pnSide.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.pnConsole.ResumeLayout(false);
            this.pnControlesAudio.ResumeLayout(false);
            this.pnControlesAudio.PerformLayout();
            this.pnInfoEvento.ResumeLayout(false);
            this.pnInfoEvento.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNavHorarios;
        private System.Windows.Forms.ToolStripButton btnNavCanciones;
        private System.Windows.Forms.ToolStripButton btnNavListas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnIniciar;
        private System.Windows.Forms.ToolStripButton btnDetener;
        private System.Windows.Forms.Panel pnConsole;
        private System.Windows.Forms.Panel pnControlesAudio;
        private System.Windows.Forms.Button btnEmergencyStop;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblSonando;
        private System.Windows.Forms.Panel pnInfoEvento;
        private System.Windows.Forms.Label lblProximoEvento;
        private System.Windows.Forms.Label lblTituloProximo;
        private System.Windows.Forms.Button btnSaltar;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Timer uiTimer;
    }
}