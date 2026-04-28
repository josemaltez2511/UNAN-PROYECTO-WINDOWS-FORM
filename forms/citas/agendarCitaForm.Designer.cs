namespace SanarRuralProyectoUnan.forms.citas
{
    partial class agendarCitaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agendarCitaForm));
            label1 = new Label();
            txtMotivo = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnRegresar = new Button();
            dgvCitas = new DataGridView();
            pictureBox1 = new PictureBox();
            tablaGlobal = new TableLayoutPanel();
            areaSuperior = new TableLayoutPanel();
            panelInputs = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tablaGlobal.SuspendLayout();
            areaSuperior.SuspendLayout();
            panelInputs.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Motivo de la Cita:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(20, 35);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(250, 23);
            txtMotivo.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(20, 80);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Location = new Point(20, 130);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar Cita";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.Location = new Point(150, 130);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(110, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Volver al Menú";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.Dock = DockStyle.Fill;
            dgvCitas.Location = new Point(3, 363);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(794, 234);
            dgvCitas.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tablaGlobal
            // 
            tablaGlobal.ColumnCount = 1;
            tablaGlobal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablaGlobal.Controls.Add(areaSuperior, 0, 0);
            tablaGlobal.Controls.Add(dgvCitas, 0, 1);
            tablaGlobal.Dock = DockStyle.Fill;
            tablaGlobal.Location = new Point(0, 0);
            tablaGlobal.Name = "tablaGlobal";
            tablaGlobal.RowCount = 2;
            tablaGlobal.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tablaGlobal.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tablaGlobal.Size = new Size(800, 600);
            tablaGlobal.TabIndex = 0;
            // 
            // areaSuperior
            // 
            areaSuperior.BackColor = Color.SteelBlue;
            areaSuperior.ColumnCount = 2;
            areaSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            areaSuperior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            areaSuperior.Controls.Add(panelInputs, 0, 0);
            areaSuperior.Controls.Add(pictureBox1, 1, 0);
            areaSuperior.Dock = DockStyle.Fill;
            areaSuperior.Location = new Point(3, 3);
            areaSuperior.Name = "areaSuperior";
            areaSuperior.RowCount = 1;
            areaSuperior.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            areaSuperior.Size = new Size(794, 354);
            areaSuperior.TabIndex = 0;
            // 
            // panelInputs
            // 
            panelInputs.Anchor = AnchorStyles.None;
            panelInputs.Controls.Add(label1);
            panelInputs.Controls.Add(txtMotivo);
            panelInputs.Controls.Add(dtpFecha);
            panelInputs.Controls.Add(btnGuardar);
            panelInputs.Controls.Add(btnRegresar);
            panelInputs.Location = new Point(48, 67);
            panelInputs.Name = "panelInputs";
            panelInputs.Size = new Size(300, 220);
            panelInputs.TabIndex = 0;
            // 
            // agendarCitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 600);
            Controls.Add(tablaGlobal);
            Name = "agendarCitaForm";
            Text = "Gestión de Citas - Sanar Rural";
            Load += agendarCitaForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tablaGlobal.ResumeLayout(false);
            areaSuperior.ResumeLayout(false);
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TableLayoutPanel tablaGlobal;
        private TableLayoutPanel areaSuperior;
        private Panel panelInputs;
    }
}