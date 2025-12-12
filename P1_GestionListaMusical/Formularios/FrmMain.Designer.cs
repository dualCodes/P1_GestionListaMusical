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
            components = new System.ComponentModel.Container();
            pnSide = new Panel();
            btnDetener = new Button();
            btnIniciar = new Button();
            labelSeparador = new Label();
            btnNavListas = new Button();
            btnNavCanciones = new Button();
            btnNavHorarios = new Button();
            pnLogo = new Panel();
            lblLogo = new Label();
            pnTop = new Panel();
            lblTituloApp = new Label();
            pnConsole = new Panel();
            pnControlesAudio = new Panel();
            btnRecargar = new Button();
            btnEmergencyStop = new Button();
            pbProgreso = new ProgressBar();
            lblSonando = new Label();
            pnInfoEvento = new Panel();
            lblProximoEvento = new Label();
            lblTituloProximo = new Label();
            pnStatus = new Panel();
            statusStrip1 = new StatusStrip();
            lblEstadoServicio = new ToolStripStatusLabel();
            lblEspacio = new ToolStripStatusLabel();
            lblReloj = new ToolStripStatusLabel();
            uiTimer = new System.Windows.Forms.Timer(components);
            pnSide.SuspendLayout();
            pnLogo.SuspendLayout();
            pnTop.SuspendLayout();
            pnConsole.SuspendLayout();
            pnControlesAudio.SuspendLayout();
            pnInfoEvento.SuspendLayout();
            pnStatus.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnSide
            // 
            pnSide.BackColor = Color.FromArgb(33, 37, 41);
            pnSide.Controls.Add(btnDetener);
            pnSide.Controls.Add(btnIniciar);
            pnSide.Controls.Add(labelSeparador);
            pnSide.Controls.Add(btnNavListas);
            pnSide.Controls.Add(btnNavCanciones);
            pnSide.Controls.Add(btnNavHorarios);
            pnSide.Controls.Add(pnLogo);
            pnSide.Dock = DockStyle.Left;
            pnSide.Location = new Point(0, 0);
            pnSide.Name = "pnSide";
            pnSide.Size = new Size(220, 661);
            pnSide.TabIndex = 0;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.FromArgb(220, 53, 69);
            btnDetener.Dock = DockStyle.Bottom;
            btnDetener.FlatAppearance.BorderSize = 0;
            btnDetener.FlatStyle = FlatStyle.Flat;
            btnDetener.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetener.ForeColor = Color.White;
            btnDetener.Location = new Point(0, 561);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(220, 50);
            btnDetener.TabIndex = 6;
            btnDetener.Text = "APAGAR";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(25, 135, 84);
            btnIniciar.Dock = DockStyle.Bottom;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(0, 611);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(220, 50);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "ENCENDER";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // labelSeparador
            // 
            labelSeparador.BorderStyle = BorderStyle.Fixed3D;
            labelSeparador.Dock = DockStyle.Top;
            labelSeparador.Location = new Point(0, 230);
            labelSeparador.Name = "labelSeparador";
            labelSeparador.Size = new Size(220, 2);
            labelSeparador.TabIndex = 4;
            // 
            // btnNavListas
            // 
            btnNavListas.Dock = DockStyle.Top;
            btnNavListas.FlatAppearance.BorderSize = 0;
            btnNavListas.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 80, 87);
            btnNavListas.FlatStyle = FlatStyle.Flat;
            btnNavListas.Font = new Font("Segoe UI", 11F);
            btnNavListas.ForeColor = Color.White;
            btnNavListas.Location = new Point(0, 180);
            btnNavListas.Name = "btnNavListas";
            btnNavListas.Padding = new Padding(15, 0, 0, 0);
            btnNavListas.Size = new Size(220, 50);
            btnNavListas.TabIndex = 3;
            btnNavListas.Text = "📂  Listas";
            btnNavListas.TextAlign = ContentAlignment.MiddleLeft;
            btnNavListas.UseVisualStyleBackColor = true;
            btnNavListas.Click += btnNavListas_Click;
            // 
            // btnNavCanciones
            // 
            btnNavCanciones.Dock = DockStyle.Top;
            btnNavCanciones.FlatAppearance.BorderSize = 0;
            btnNavCanciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 80, 87);
            btnNavCanciones.FlatStyle = FlatStyle.Flat;
            btnNavCanciones.Font = new Font("Segoe UI", 11F);
            btnNavCanciones.ForeColor = Color.White;
            btnNavCanciones.Location = new Point(0, 130);
            btnNavCanciones.Name = "btnNavCanciones";
            btnNavCanciones.Padding = new Padding(15, 0, 0, 0);
            btnNavCanciones.Size = new Size(220, 50);
            btnNavCanciones.TabIndex = 2;
            btnNavCanciones.Text = "🎵  Audios";
            btnNavCanciones.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCanciones.UseVisualStyleBackColor = true;
            btnNavCanciones.Click += btnNavCanciones_Click;
            // 
            // btnNavHorarios
            // 
            btnNavHorarios.Dock = DockStyle.Top;
            btnNavHorarios.FlatAppearance.BorderSize = 0;
            btnNavHorarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 80, 87);
            btnNavHorarios.FlatStyle = FlatStyle.Flat;
            btnNavHorarios.Font = new Font("Segoe UI", 11F);
            btnNavHorarios.ForeColor = Color.White;
            btnNavHorarios.Location = new Point(0, 80);
            btnNavHorarios.Name = "btnNavHorarios";
            btnNavHorarios.Padding = new Padding(15, 0, 0, 0);
            btnNavHorarios.Size = new Size(220, 50);
            btnNavHorarios.TabIndex = 1;
            btnNavHorarios.Text = "📅  Programación";
            btnNavHorarios.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHorarios.UseVisualStyleBackColor = true;
            btnNavHorarios.Click += btnNavHorarios_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(13, 110, 253);
            pnLogo.Controls.Add(lblLogo);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(220, 80);
            pnLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(2, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(217, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "GESTOR DE TIMBRE";
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.White;
            pnTop.Controls.Add(lblTituloApp);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(220, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(788, 50);
            pnTop.TabIndex = 1;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Segoe UI", 14F);
            lblTituloApp.ForeColor = Color.FromArgb(64, 64, 64);
            lblTituloApp.Location = new Point(20, 12);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(129, 25);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Text = "Panel General";
            // 
            // pnConsole
            // 
            pnConsole.BackColor = Color.White;
            pnConsole.Controls.Add(pnControlesAudio);
            pnConsole.Controls.Add(pnInfoEvento);
            pnConsole.Dock = DockStyle.Bottom;
            pnConsole.Location = new Point(220, 531);
            pnConsole.Name = "pnConsole";
            pnConsole.Size = new Size(788, 100);
            pnConsole.TabIndex = 2;
            // 
            // pnControlesAudio
            // 
            pnControlesAudio.BackColor = Color.WhiteSmoke;
            pnControlesAudio.BorderStyle = BorderStyle.FixedSingle;
            pnControlesAudio.Controls.Add(btnRecargar);
            pnControlesAudio.Controls.Add(btnEmergencyStop);
            pnControlesAudio.Controls.Add(pbProgreso);
            pnControlesAudio.Controls.Add(lblSonando);
            pnControlesAudio.Dock = DockStyle.Fill;
            pnControlesAudio.Location = new Point(350, 0);
            pnControlesAudio.Name = "pnControlesAudio";
            pnControlesAudio.Padding = new Padding(10);
            pnControlesAudio.Size = new Size(438, 100);
            pnControlesAudio.TabIndex = 1;
            // 
            // btnRecargar
            // 
            btnRecargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecargar.BackColor = Color.SteelBlue;
            btnRecargar.FlatAppearance.BorderSize = 0;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRecargar.ForeColor = Color.White;
            btnRecargar.Location = new Point(216, 53);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(100, 30);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "RECARGAR";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnEmergencyStop
            // 
            btnEmergencyStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEmergencyStop.BackColor = Color.FromArgb(220, 53, 69);
            btnEmergencyStop.FlatAppearance.BorderSize = 0;
            btnEmergencyStop.FlatStyle = FlatStyle.Flat;
            btnEmergencyStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergencyStop.ForeColor = Color.White;
            btnEmergencyStop.Location = new Point(322, 53);
            btnEmergencyStop.Name = "btnEmergencyStop";
            btnEmergencyStop.Size = new Size(100, 30);
            btnEmergencyStop.TabIndex = 2;
            btnEmergencyStop.Text = "SILENCIAR";
            btnEmergencyStop.UseVisualStyleBackColor = false;
            btnEmergencyStop.Click += btnDetener_Click;
            // 
            // pbProgreso
            // 
            pbProgreso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProgreso.Location = new Point(13, 37);
            pbProgreso.Name = "pbProgreso";
            pbProgreso.Size = new Size(409, 10);
            pbProgreso.Style = ProgressBarStyle.Continuous;
            pbProgreso.TabIndex = 1;
            // 
            // lblSonando
            // 
            lblSonando.AutoSize = true;
            lblSonando.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSonando.Location = new Point(10, 10);
            lblSonando.Name = "lblSonando";
            lblSonando.Size = new Size(90, 19);
            lblSonando.TabIndex = 0;
            lblSonando.Text = "En silencio...";
            // 
            // pnInfoEvento
            // 
            pnInfoEvento.BackColor = Color.White;
            pnInfoEvento.BorderStyle = BorderStyle.FixedSingle;
            pnInfoEvento.Controls.Add(lblProximoEvento);
            pnInfoEvento.Controls.Add(lblTituloProximo);
            pnInfoEvento.Dock = DockStyle.Left;
            pnInfoEvento.Location = new Point(0, 0);
            pnInfoEvento.Name = "pnInfoEvento";
            pnInfoEvento.Size = new Size(350, 100);
            pnInfoEvento.TabIndex = 0;
            // 
            // lblProximoEvento
            // 
            lblProximoEvento.AutoEllipsis = true;
            lblProximoEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProximoEvento.ForeColor = Color.FromArgb(33, 37, 41);
            lblProximoEvento.Location = new Point(15, 45);
            lblProximoEvento.Name = "lblProximoEvento";
            lblProximoEvento.Size = new Size(320, 25);
            lblProximoEvento.TabIndex = 1;
            lblProximoEvento.Text = "--:-- Sin programar";
            // 
            // lblTituloProximo
            // 
            lblTituloProximo.AutoSize = true;
            lblTituloProximo.Font = new Font("Segoe UI", 9F);
            lblTituloProximo.ForeColor = Color.DimGray;
            lblTituloProximo.Location = new Point(15, 20);
            lblTituloProximo.Name = "lblTituloProximo";
            lblTituloProximo.Size = new Size(109, 15);
            lblTituloProximo.TabIndex = 0;
            lblTituloProximo.Text = "PRÓXIMO EVENTO:";
            // 
            // pnStatus
            // 
            pnStatus.Controls.Add(statusStrip1);
            pnStatus.Dock = DockStyle.Bottom;
            pnStatus.Location = new Point(220, 631);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(788, 30);
            pnStatus.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.White;
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstadoServicio, lblEspacio, lblReloj });
            statusStrip1.Location = new Point(0, 8);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(788, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoServicio
            // 
            lblEstadoServicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoServicio.Name = "lblEstadoServicio";
            lblEstadoServicio.Size = new Size(120, 17);
            lblEstadoServicio.Text = "Sistema Preparado...";
            // 
            // lblEspacio
            // 
            lblEspacio.Name = "lblEspacio";
            lblEspacio.Size = new Size(607, 17);
            lblEspacio.Spring = true;
            // 
            // lblReloj
            // 
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(46, 17);
            lblReloj.Text = " --:--:--";
            lblReloj.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiTimer
            // 
            uiTimer.Interval = 1000;
            uiTimer.Tick += uiTimer_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 661);
            Controls.Add(pnConsole);
            Controls.Add(pnStatus);
            Controls.Add(pnTop);
            Controls.Add(pnSide);
            IsMdiContainer = true;
            MinimumSize = new Size(1024, 700);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión Musical";
            WindowState = FormWindowState.Maximized;
            pnSide.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            pnLogo.PerformLayout();
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            pnConsole.ResumeLayout(false);
            pnControlesAudio.ResumeLayout(false);
            pnControlesAudio.PerformLayout();
            pnInfoEvento.ResumeLayout(false);
            pnInfoEvento.PerformLayout();
            pnStatus.ResumeLayout(false);
            pnStatus.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavHorarios;
        private System.Windows.Forms.Button btnNavListas;
        private System.Windows.Forms.Button btnNavCanciones;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Panel pnConsole;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoServicio;
        private System.Windows.Forms.ToolStripStatusLabel lblReloj;
        private System.Windows.Forms.Panel pnInfoEvento;
        private System.Windows.Forms.Panel pnControlesAudio;
        private System.Windows.Forms.Label lblTituloProximo;
        private System.Windows.Forms.Label lblProximoEvento;
        private System.Windows.Forms.Label lblSonando;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Button btnEmergencyStop;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.Label labelSeparador;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ToolStripStatusLabel lblEspacio;
    }
}