namespace SanarRuralProyectoUnan.forms
{
    partial class signInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInForm));
            pictureBox1 = new PictureBox();
            botonCrearUsuario = new Button();
            botonCancelar = new Button();
            txtNombreRegistro = new TextBox();
            txtPasswordRegistro = new TextBox();
            txtEmailRegistro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tablaPrincipal = new TableLayoutPanel();
            panelCentralRegistro = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tablaPrincipal.SuspendLayout();
            panelCentralRegistro.SuspendLayout();
            SuspendLayout();
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
            // botonCrearUsuario
            // 
            botonCrearUsuario.Location = new Point(50, 230);
            botonCrearUsuario.Name = "botonCrearUsuario";
            botonCrearUsuario.Size = new Size(110, 35);
            botonCrearUsuario.TabIndex = 6;
            botonCrearUsuario.Text = "Crear Usuario";
            botonCrearUsuario.UseVisualStyleBackColor = true;
            botonCrearUsuario.Click += botonCrearUsuario_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(190, 230);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(110, 35);
            botonCancelar.TabIndex = 7;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // txtNombreRegistro
            // 
            txtNombreRegistro.Location = new Point(50, 60);
            txtNombreRegistro.Name = "txtNombreRegistro";
            txtNombreRegistro.Size = new Size(250, 23);
            txtNombreRegistro.TabIndex = 1;
            txtNombreRegistro.TextChanged += txtNombreRegistro_TextChanged;
            // 
            // txtPasswordRegistro
            // 
            txtPasswordRegistro.Location = new Point(50, 180);
            txtPasswordRegistro.Name = "txtPasswordRegistro";
            txtPasswordRegistro.Size = new Size(250, 23);
            txtPasswordRegistro.TabIndex = 5;
            txtPasswordRegistro.UseSystemPasswordChar = true;
            // 
            // txtEmailRegistro
            // 
            txtEmailRegistro.Location = new Point(50, 120);
            txtEmailRegistro.Name = "txtEmailRegistro";
            txtEmailRegistro.Size = new Size(250, 23);
            txtEmailRegistro.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 160);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese su contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 100);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese su correo";
            label3.Click += label3_Click;
            // 
            // tablaPrincipal
            // 
            tablaPrincipal.BackColor = Color.SteelBlue;
            tablaPrincipal.ColumnCount = 2;
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.Controls.Add(panelCentralRegistro, 0, 0);
            tablaPrincipal.Controls.Add(pictureBox1, 1, 0);
            tablaPrincipal.Dock = DockStyle.Fill;
            tablaPrincipal.Location = new Point(0, 0);
            tablaPrincipal.Name = "tablaPrincipal";
            tablaPrincipal.RowCount = 1;
            tablaPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablaPrincipal.Size = new Size(800, 450);
            tablaPrincipal.TabIndex = 0;
            tablaPrincipal.Paint += tablaPrincipal_Paint;
            // 
            // panelCentralRegistro
            // 
            panelCentralRegistro.Anchor = AnchorStyles.None;
            panelCentralRegistro.Controls.Add(label1);
            panelCentralRegistro.Controls.Add(txtNombreRegistro);
            panelCentralRegistro.Controls.Add(label3);
            panelCentralRegistro.Controls.Add(txtEmailRegistro);
            panelCentralRegistro.Controls.Add(label2);
            panelCentralRegistro.Controls.Add(txtPasswordRegistro);
            panelCentralRegistro.Controls.Add(botonCrearUsuario);
            panelCentralRegistro.Controls.Add(botonCancelar);
            panelCentralRegistro.Location = new Point(25, 25);
            panelCentralRegistro.Name = "panelCentralRegistro";
            panelCentralRegistro.Size = new Size(350, 400);
            panelCentralRegistro.TabIndex = 0;
            // 
            // signInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tablaPrincipal);
            Name = "signInForm";
            Text = "Sanar Rural - Registro";
            Load += signInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tablaPrincipal.ResumeLayout(false);
            panelCentralRegistro.ResumeLayout(false);
            panelCentralRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonCrearUsuario;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.TextBox txtNombreRegistro;
        private System.Windows.Forms.TextBox txtPasswordRegistro;
        private System.Windows.Forms.TextBox txtEmailRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TableLayoutPanel tablaPrincipal;
        private Panel panelCentralRegistro;
    }
}