namespace SanarRuralProyectoUnan.forms.tratamientos
{
    partial class crearTratamientoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearTratamientoForm));
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            dtpInicio = new DateTimePicker();
            label3 = new Label();
            dtpFin = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            layoutCentrador = new TableLayoutPanel();
            panelFormulario = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            layoutCentrador.SuspendLayout();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 135);
            label1.Name = "label1";
            label1.Size = new Size(199, 19);
            label1.TabIndex = 1;
            label1.Text = "Descripción del tratamiento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.Location = new Point(40, 160);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 80);
            txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 255);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Inicio:";
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Segoe UI", 11F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(40, 280);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(320, 27);
            dtpInicio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 320);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 5;
            label3.Text = "Fecha Estimada de Fin:";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Segoe UI", 11F);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(40, 345);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(320, 27);
            dtpFin.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.SteelBlue;
            btnGuardar.Location = new Point(40, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(210, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(270, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 10);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Tratamiento";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // layoutCentrador
            // 
            layoutCentrador.BackColor = Color.SteelBlue;
            layoutCentrador.ColumnCount = 1;
            layoutCentrador.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutCentrador.Controls.Add(panelFormulario, 0, 0);
            layoutCentrador.Dock = DockStyle.Fill;
            layoutCentrador.Location = new Point(0, 0);
            layoutCentrador.Name = "layoutCentrador";
            layoutCentrador.RowCount = 1;
            layoutCentrador.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutCentrador.Size = new Size(800, 500);
            layoutCentrador.TabIndex = 0;
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.None;
            panelFormulario.Controls.Add(pictureBox2);
            panelFormulario.Controls.Add(lblTitulo);
            panelFormulario.Controls.Add(label1);
            panelFormulario.Controls.Add(txtDescripcion);
            panelFormulario.Controls.Add(label2);
            panelFormulario.Controls.Add(dtpInicio);
            panelFormulario.Controls.Add(label3);
            panelFormulario.Controls.Add(dtpFin);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(btnCancelar);
            panelFormulario.Controls.Add(pictureBox1);
            panelFormulario.Location = new Point(200, 15);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(400, 470);
            panelFormulario.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(140, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // crearTratamientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 500);
            Controls.Add(layoutCentrador);
            Name = "crearTratamientoForm";
            Text = "Sanar Rural - Registro de Tratamiento";
            Load += crearTratamientoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            layoutCentrador.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel layoutCentrador;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}