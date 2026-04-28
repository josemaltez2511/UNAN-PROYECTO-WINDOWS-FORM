namespace SanarRuralProyectoUnan.forms.tratamientos
{
    partial class crearTratamientoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripción del tratamiento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 140);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 80);
            txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 240);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha de Inicio:";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(40, 260);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(320, 23);
            dtpInicio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 300);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha Estimada de Fin:";
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(40, 320);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(320, 23);
            dtpFin.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(40, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(210, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "❌ Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(160, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 80);
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
            panelFormulario.Location = new Point(200, 25);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(400, 450);
            panelFormulario.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(140, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 73);
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
        private TableLayoutPanel layoutCentrador;
        private Panel panelFormulario;
        private PictureBox pictureBox2;
    }
}