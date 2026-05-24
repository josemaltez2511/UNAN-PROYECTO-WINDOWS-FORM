namespace SanarRuralProyectoUnan
{
    partial class loginForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            botonIniciarSesion = new Button();
            linkLabelCrearCuenta = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tablaPrincipal = new TableLayoutPanel();
            panelCentralLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tablaPrincipal.SuspendLayout();
            panelCentralLogin.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Segoe UI", 11F);
            textBoxUsuario.Location = new Point(30, 65);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(240, 27);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Font = new Font("Segoe UI", 11F);
            textBoxContraseña.Location = new Point(30, 135);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(240, 27);
            textBoxContraseña.TabIndex = 1;
            textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Usuario / Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 110);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.BackColor = Color.White;
            botonIniciarSesion.FlatAppearance.BorderSize = 0;
            botonIniciarSesion.FlatStyle = FlatStyle.Flat;
            botonIniciarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            botonIniciarSesion.ForeColor = Color.SteelBlue;
            botonIniciarSesion.Location = new Point(30, 195);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(240, 40);
            botonIniciarSesion.TabIndex = 4;
            botonIniciarSesion.Text = "Iniciar Sesión";
            botonIniciarSesion.UseVisualStyleBackColor = false;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // linkLabelCrearCuenta
            // 
            linkLabelCrearCuenta.ActiveLinkColor = Color.LightGray;
            linkLabelCrearCuenta.AutoSize = true;
            linkLabelCrearCuenta.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            linkLabelCrearCuenta.LinkColor = Color.White;
            linkLabelCrearCuenta.Location = new Point(165, 260);
            linkLabelCrearCuenta.Name = "linkLabelCrearCuenta";
            linkLabelCrearCuenta.Size = new Size(87, 17);
            linkLabelCrearCuenta.TabIndex = 6;
            linkLabelCrearCuenta.TabStop = true;
            linkLabelCrearCuenta.Text = "Crear Cuenta";
            linkLabelCrearCuenta.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(35, 260);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 5;
            label3.Text = "¿No está registrado?";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tablaPrincipal
            // 
            tablaPrincipal.BackColor = Color.SteelBlue;
            tablaPrincipal.ColumnCount = 2;
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.Controls.Add(panelCentralLogin, 0, 0);
            tablaPrincipal.Controls.Add(pictureBox1, 1, 0);
            tablaPrincipal.Dock = DockStyle.Fill;
            tablaPrincipal.Location = new Point(0, 0);
            tablaPrincipal.Name = "tablaPrincipal";
            tablaPrincipal.RowCount = 1;
            tablaPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaPrincipal.Size = new Size(800, 450);
            tablaPrincipal.TabIndex = 0;
            // 
            // panelCentralLogin
            // 
            panelCentralLogin.Anchor = AnchorStyles.None;
            panelCentralLogin.Controls.Add(label1);
            panelCentralLogin.Controls.Add(textBoxUsuario);
            panelCentralLogin.Controls.Add(label2);
            panelCentralLogin.Controls.Add(textBoxContraseña);
            panelCentralLogin.Controls.Add(botonIniciarSesion);
            panelCentralLogin.Controls.Add(label3);
            panelCentralLogin.Controls.Add(linkLabelCrearCuenta);
            panelCentralLogin.Location = new Point(50, 50);
            panelCentralLogin.Name = "panelCentralLogin";
            panelCentralLogin.Size = new Size(300, 350);
            panelCentralLogin.TabIndex = 0;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tablaPrincipal);
            Name = "loginForm";
            Text = "Sanar Rural - Login";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tablaPrincipal.ResumeLayout(false);
            panelCentralLogin.ResumeLayout(false);
            panelCentralLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Label label1;
        private Label label2;
        private Button botonIniciarSesion;
        private LinkLabel linkLabelCrearCuenta;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tablaPrincipal;
        private Panel panelCentralLogin;
    }
}