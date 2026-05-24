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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnVerCitas = new System.Windows.Forms.Button();
            this.btnSintomas = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablaPrincipal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(25, 10);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(250, 35);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Cargando...";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.White;
            this.btnAgendarCita.FlatAppearance.BorderSize = 0;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgendarCita.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAgendarCita.Location = new System.Drawing.Point(25, 60);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(250, 50);
            this.btnAgendarCita.TabIndex = 1;
            this.btnAgendarCita.Text = "📅 Agendar Cita";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnVerCitas
            // 
            this.btnVerCitas.BackColor = System.Drawing.Color.White;
            this.btnVerCitas.FlatAppearance.BorderSize = 0;
            this.btnVerCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerCitas.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnVerCitas.Location = new System.Drawing.Point(25, 120);
            this.btnVerCitas.Name = "btnVerCitas";
            this.btnVerCitas.Size = new System.Drawing.Size(250, 50);
            this.btnVerCitas.TabIndex = 2;
            this.btnVerCitas.Text = "🔎 Ver mis Citas";
            this.btnVerCitas.UseVisualStyleBackColor = false;
            this.btnVerCitas.Click += new System.EventHandler(this.btnVerCitas_Click);
            // 
            // btnSintomas
            // 
            this.btnSintomas.BackColor = System.Drawing.Color.White;
            this.btnSintomas.FlatAppearance.BorderSize = 0;
            this.btnSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintomas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSintomas.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSintomas.Location = new System.Drawing.Point(25, 180);
            this.btnSintomas.Name = "btnSintomas";
            this.btnSintomas.Size = new System.Drawing.Size(250, 50);
            this.btnSintomas.TabIndex = 3;
            this.btnSintomas.Text = "🩺 Consulta de Síntomas";
            this.btnSintomas.UseVisualStyleBackColor = false;
            this.btnSintomas.Click += new System.EventHandler(this.btnSintomas_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.BackColor = System.Drawing.Color.White;
            this.btnTratamientos.FlatAppearance.BorderSize = 0;
            this.btnTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratamientos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTratamientos.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTratamientos.Location = new System.Drawing.Point(25, 240);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(250, 50);
            this.btnTratamientos.TabIndex = 4;
            this.btnTratamientos.Text = "💊 Ver Tratamientos";
            this.btnTratamientos.UseVisualStyleBackColor = false;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(75, 330);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "🚪 Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.ColumnCount = 2;
            this.tablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPrincipal.Controls.Add(this.panelMenu, 0, 0);
            this.tablaPrincipal.Controls.Add(this.pictureBox1, 1, 0);
            this.tablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.RowCount = 1;
            this.tablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablaPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tablaPrincipal.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.Controls.Add(this.lblBienvenida);
            this.panelMenu.Controls.Add(this.btnAgendarCita);
            this.panelMenu.Controls.Add(this.btnVerCitas);
            this.panelMenu.Controls.Add(this.btnSintomas);
            this.panelMenu.Controls.Add(this.btnTratamientos);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Location = new System.Drawing.Point(50, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(300, 400);
            this.panelMenu.TabIndex = 0;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaPrincipal);
            this.Name = "menuForm";
            this.Text = "Sanar Rural - Menú Principal";
            this.Load += new System.EventHandler(this.menuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablaPrincipal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnVerCitas;
        private System.Windows.Forms.Button btnSintomas;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tablaPrincipal;
        private System.Windows.Forms.Panel panelMenu;
    }
}