namespace SanarRuralProyectoUnan.forms.citas
{
    partial class verCitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verCitasForm));
            lblTitulo = new Label();
            dgvCitas = new DataGridView();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            layoutGlobal = new TableLayoutPanel();
            layoutCabecera = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            layoutGlobal.SuspendLayout();
            layoutCabecera.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mis Citas Médicas";
            // 
            // dgvCitas
            // 
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.BorderStyle = BorderStyle.None;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Dock = DockStyle.Fill;
            dgvCitas.Location = new Point(23, 83);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(854, 384);
            dgvCitas.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Left;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.Location = new Point(23, 480);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(160, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "← Volver al Menú";
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(751, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // layoutGlobal
            // 
            layoutGlobal.BackColor = Color.SteelBlue;
            layoutGlobal.ColumnCount = 1;
            layoutGlobal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            layoutGlobal.Controls.Add(layoutCabecera, 0, 0);
            layoutGlobal.Controls.Add(dgvCitas, 0, 1);
            layoutGlobal.Controls.Add(btnVolver, 0, 2);
            layoutGlobal.Dock = DockStyle.Fill;
            layoutGlobal.Location = new Point(0, 0);
            layoutGlobal.Name = "layoutGlobal";
            layoutGlobal.Padding = new Padding(20);
            layoutGlobal.RowCount = 3;
            layoutGlobal.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layoutGlobal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutGlobal.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layoutGlobal.Size = new Size(900, 550);
            layoutGlobal.TabIndex = 0;
            // 
            // layoutCabecera
            // 
            layoutCabecera.ColumnCount = 2;
            layoutCabecera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            layoutCabecera.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            layoutCabecera.Controls.Add(lblTitulo, 0, 0);
            layoutCabecera.Controls.Add(pictureBox1, 1, 0);
            layoutCabecera.Dock = DockStyle.Fill;
            layoutCabecera.Location = new Point(23, 23);
            layoutCabecera.Name = "layoutCabecera";
            layoutCabecera.RowCount = 1;
            layoutCabecera.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutCabecera.Size = new Size(854, 54);
            layoutCabecera.TabIndex = 0;
            // 
            // verCitasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 550);
            Controls.Add(layoutGlobal);
            Name = "verCitasForm";
            Text = "Sanar Rural - Historial de Citas";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            layoutGlobal.ResumeLayout(false);
            layoutCabecera.ResumeLayout(false);
            layoutCabecera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TableLayoutPanel layoutGlobal;
        private TableLayoutPanel layoutCabecera;
    }
}