namespace SanarRuralProyectoUnan.forms.diagnostico
{
    partial class diagnosticoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diagnosticoForm));
            label1 = new Label();
            txtEntradaSintomas = new TextBox();
            btnAnalizar = new Button();
            lblResultado = new Label();
            btnRegresar = new Button();
            btnIrACita = new Button();
            pictureBox1 = new PictureBox();
            tablaPrincipal = new TableLayoutPanel();
            panelContenido = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tablaPrincipal.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(315, 19);
            label1.TabIndex = 1;
            label1.Text = "Describe tus síntomas (separados por comas):";
            // 
            // txtEntradaSintomas
            // 
            txtEntradaSintomas.Font = new Font("Segoe UI", 11F);
            txtEntradaSintomas.Location = new Point(20, 45);
            txtEntradaSintomas.Name = "txtEntradaSintomas";
            txtEntradaSintomas.Size = new Size(410, 27);
            txtEntradaSintomas.TabIndex = 2;
            // 
            // btnAnalizar
            // 
            btnAnalizar.BackColor = Color.White;
            btnAnalizar.FlatAppearance.BorderSize = 0;
            btnAnalizar.FlatStyle = FlatStyle.Flat;
            btnAnalizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnalizar.ForeColor = Color.SteelBlue;
            btnAnalizar.Location = new Point(20, 85);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(180, 40);
            btnAnalizar.TabIndex = 3;
            btnAnalizar.Text = "🔍 Analizar Síntomas";
            btnAnalizar.UseVisualStyleBackColor = false;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.WhiteSmoke;
            lblResultado.Font = new Font("Segoe UI", 10.5F);
            lblResultado.ForeColor = Color.FromArgb(64, 64, 64);
            lblResultado.Location = new Point(20, 140);
            lblResultado.Name = "lblResultado";
            lblResultado.Padding = new Padding(15);
            lblResultado.Size = new Size(410, 170);
            lblResultado.TabIndex = 4;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.LightCoral;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(270, 330);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 40);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Volver al Menú";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnIrACita
            // 
            btnIrACita.BackColor = Color.White;
            btnIrACita.FlatAppearance.BorderSize = 0;
            btnIrACita.FlatStyle = FlatStyle.Flat;
            btnIrACita.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIrACita.ForeColor = Color.MediumSeaGreen;
            btnIrACita.Location = new Point(20, 330);
            btnIrACita.Name = "btnIrACita";
            btnIrACita.Size = new Size(160, 40);
            btnIrACita.TabIndex = 6;
            btnIrACita.Text = "📅 Agendar Cita";
            btnIrACita.UseVisualStyleBackColor = false;
            btnIrACita.Visible = false;
            btnIrACita.Click += btnIrACita_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tablaPrincipal
            // 
            tablaPrincipal.BackColor = Color.SteelBlue;
            tablaPrincipal.ColumnCount = 1;
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaPrincipal.Controls.Add(panelContenido, 0, 0);
            tablaPrincipal.Dock = DockStyle.Fill;
            tablaPrincipal.Location = new Point(0, 0);
            tablaPrincipal.Name = "tablaPrincipal";
            tablaPrincipal.RowCount = 1;
            tablaPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaPrincipal.Size = new Size(600, 500);
            tablaPrincipal.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.None;
            panelContenido.Controls.Add(pictureBox1);
            panelContenido.Controls.Add(label1);
            panelContenido.Controls.Add(txtEntradaSintomas);
            panelContenido.Controls.Add(btnAnalizar);
            panelContenido.Controls.Add(lblResultado);
            panelContenido.Controls.Add(btnIrACita);
            panelContenido.Controls.Add(btnRegresar);
            panelContenido.Location = new Point(75, 50);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(450, 400);
            panelContenido.TabIndex = 0;
            // 
            // diagnosticoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(600, 500);
            Controls.Add(tablaPrincipal);
            Name = "diagnosticoForm";
            Text = "Sanar Rural - Asistente de Salud";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tablaPrincipal.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntradaSintomas;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnIrACita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tablaPrincipal;
        private System.Windows.Forms.Panel panelContenido;
    }
}