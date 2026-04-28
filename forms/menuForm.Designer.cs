namespace SanarRuralProyectoUnan
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            lblBienvenida = new Label();
            btnAgendarCita = new Button();
            btnVerCitas = new Button();
            btnSintomas = new Button();
            btnTratamientos = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(146, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Cargando...";
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.BackColor = Color.White;
            btnAgendarCita.FlatStyle = FlatStyle.Flat;
            btnAgendarCita.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgendarCita.Location = new Point(40, 90);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new Size(250, 55);
            btnAgendarCita.TabIndex = 1;
            btnAgendarCita.Text = "📅 Agendar Cita";
            btnAgendarCita.UseVisualStyleBackColor = false;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnVerCitas
            // 
            btnVerCitas.BackColor = Color.White;
            btnVerCitas.FlatStyle = FlatStyle.Flat;
            btnVerCitas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVerCitas.Location = new Point(40, 160);
            btnVerCitas.Name = "btnVerCitas";
            btnVerCitas.Size = new Size(250, 55);
            btnVerCitas.TabIndex = 2;
            btnVerCitas.Text = "🔎 Ver mis Citas";
            btnVerCitas.UseVisualStyleBackColor = false;
            btnVerCitas.Click += btnVerCitas_Click;
            // 
            // btnSintomas
            // 
            btnSintomas.BackColor = Color.White;
            btnSintomas.FlatStyle = FlatStyle.Flat;
            btnSintomas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSintomas.Location = new Point(40, 230);
            btnSintomas.Name = "btnSintomas";
            btnSintomas.Size = new Size(250, 55);
            btnSintomas.TabIndex = 3;
            btnSintomas.Text = "\U0001fa7a Consulta de Síntomas";
            btnSintomas.UseVisualStyleBackColor = false;
            btnSintomas.Click += btnSintomas_Click;
            // 
            // btnTratamientos
            // 
            btnTratamientos.BackColor = Color.White;
            btnTratamientos.FlatStyle = FlatStyle.Flat;
            btnTratamientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTratamientos.Location = new Point(40, 300);
            btnTratamientos.Name = "btnTratamientos";
            btnTratamientos.Size = new Size(250, 55);
            btnTratamientos.TabIndex = 4;
            btnTratamientos.Text = "💊 Ver Tratamientos";
            btnTratamientos.UseVisualStyleBackColor = false;
            btnTratamientos.Click += btnTratamientos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightCoral;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(40, 385);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "🚪 Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 358);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnTratamientos);
            Controls.Add(btnSintomas);
            Controls.Add(btnVerCitas);
            Controls.Add(btnAgendarCita);
            Controls.Add(lblBienvenida);
            Name = "menuForm";
            Text = "Sanar Rural - Menú Principal";
            Load += menuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.Button btnSintomas;
        private System.Windows.Forms.Button btnTratamientos; // Declaración del nuevo botón
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}