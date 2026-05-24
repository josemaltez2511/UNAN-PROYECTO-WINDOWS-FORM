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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonCrearUsuario = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.txtPasswordRegistro = new System.Windows.Forms.TextBox();
            this.txtEmailRegistro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelCentralRegistro = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablaPrincipal.SuspendLayout();
            this.panelCentralRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreRegistro.Location = new System.Drawing.Point(50, 65);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(250, 27);
            this.txtNombreRegistro.TabIndex = 1;
            this.txtNombreRegistro.TextChanged += new System.EventHandler(this.txtNombreRegistro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese su correo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmailRegistro
            // 
            this.txtEmailRegistro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailRegistro.Location = new System.Drawing.Point(50, 140);
            this.txtEmailRegistro.Name = "txtEmailRegistro";
            this.txtEmailRegistro.Size = new System.Drawing.Size(250, 27);
            this.txtEmailRegistro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese su contraseña";
            // 
            // txtPasswordRegistro
            // 
            this.txtPasswordRegistro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordRegistro.Location = new System.Drawing.Point(50, 215);
            this.txtPasswordRegistro.Name = "txtPasswordRegistro";
            this.txtPasswordRegistro.Size = new System.Drawing.Size(250, 27);
            this.txtPasswordRegistro.TabIndex = 5;
            this.txtPasswordRegistro.UseSystemPasswordChar = true;
            // 
            // botonCrearUsuario
            // 
            this.botonCrearUsuario.BackColor = System.Drawing.Color.White;
            this.botonCrearUsuario.FlatAppearance.BorderSize = 0;
            this.botonCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonCrearUsuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.botonCrearUsuario.Location = new System.Drawing.Point(50, 275);
            this.botonCrearUsuario.Name = "botonCrearUsuario";
            this.botonCrearUsuario.Size = new System.Drawing.Size(120, 40);
            this.botonCrearUsuario.TabIndex = 6;
            this.botonCrearUsuario.Text = "Crear Usuario";
            this.botonCrearUsuario.UseVisualStyleBackColor = false;
            this.botonCrearUsuario.Click += new System.EventHandler(this.botonCrearUsuario_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.botonCancelar.FlatAppearance.BorderSize = 0;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonCancelar.ForeColor = System.Drawing.Color.White;
            this.botonCancelar.Location = new System.Drawing.Point(180, 275);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(120, 40);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.tablaPrincipal.ColumnCount = 2;
            this.tablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPrincipal.Controls.Add(this.panelCentralRegistro, 0, 0);
            this.tablaPrincipal.Controls.Add(this.pictureBox1, 1, 0);
            this.tablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.RowCount = 1;
            this.tablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tablaPrincipal.TabIndex = 0;
            this.tablaPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tablaPrincipal_Paint);
            // 
            // panelCentralRegistro
            // 
            this.panelCentralRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentralRegistro.Controls.Add(this.label1);
            this.panelCentralRegistro.Controls.Add(this.txtNombreRegistro);
            this.panelCentralRegistro.Controls.Add(this.label3);
            this.panelCentralRegistro.Controls.Add(this.txtEmailRegistro);
            this.panelCentralRegistro.Controls.Add(this.label2);
            this.panelCentralRegistro.Controls.Add(this.txtPasswordRegistro);
            this.panelCentralRegistro.Controls.Add(this.botonCrearUsuario);
            this.panelCentralRegistro.Controls.Add(this.botonCancelar);
            this.panelCentralRegistro.Location = new System.Drawing.Point(25, 25);
            this.panelCentralRegistro.Name = "panelCentralRegistro";
            this.panelCentralRegistro.Size = new System.Drawing.Size(350, 400);
            this.panelCentralRegistro.TabIndex = 0;
            // 
            // signInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaPrincipal);
            this.Name = "signInForm";
            this.Text = "Sanar Rural - Registro";
            this.Load += new System.EventHandler(this.signInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablaPrincipal.ResumeLayout(false);
            this.panelCentralRegistro.ResumeLayout(false);
            this.panelCentralRegistro.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tablaPrincipal;
        private System.Windows.Forms.Panel panelCentralRegistro;
    }
}