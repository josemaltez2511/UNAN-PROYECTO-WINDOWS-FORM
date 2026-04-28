namespace SanarRuralProyectoUnan.forms.tratamientos
{
    partial class tratamientosForm
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
            lblTitulo = new Label();
            txtDescripcion = new TextBox();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnGuardar = new Button();
            dgvTratamientos = new DataGridView();
            btnVolver = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tablaGlobal = new TableLayoutPanel();
            panelIzquierdoInputs = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            tablaGlobal.SuspendLayout();
            panelIzquierdoInputs.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Tratamientos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(10, 90);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 60);
            txtDescripcion.TabIndex = 2;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(10, 180);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 4;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(10, 240);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 40);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "💾 Registrar Tratamiento";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTratamientos.BackgroundColor = Color.White;
            dgvTratamientos.BorderStyle = BorderStyle.None;
            dgvTratamientos.Dock = DockStyle.Fill;
            dgvTratamientos.Location = new Point(386, 18);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.Size = new Size(546, 464);
            dgvTratamientos.TabIndex = 1;
            dgvTratamientos.CellContentClick += dgvTratamientos_CellContentClick;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(10, 350);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 30);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "← Volver";
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción del Tratamiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 160);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 220);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha de Finalización:";
            // 
            // tablaGlobal
            // 
            tablaGlobal.BackColor = Color.SteelBlue;
            tablaGlobal.ColumnCount = 2;
            tablaGlobal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tablaGlobal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tablaGlobal.Controls.Add(panelIzquierdoInputs, 0, 0);
            tablaGlobal.Controls.Add(dgvTratamientos, 1, 0);
            tablaGlobal.Dock = DockStyle.Fill;
            tablaGlobal.Location = new Point(0, 0);
            tablaGlobal.Name = "tablaGlobal";
            tablaGlobal.Padding = new Padding(15);
            tablaGlobal.RowCount = 1;
            tablaGlobal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablaGlobal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablaGlobal.Size = new Size(950, 500);
            tablaGlobal.TabIndex = 0;
            // 
            // panelIzquierdoInputs
            // 
            panelIzquierdoInputs.Anchor = AnchorStyles.None;
            panelIzquierdoInputs.Controls.Add(lblTitulo);
            panelIzquierdoInputs.Controls.Add(label2);
            panelIzquierdoInputs.Controls.Add(txtDescripcion);
            panelIzquierdoInputs.Controls.Add(label3);
            panelIzquierdoInputs.Controls.Add(dtpInicio);
            panelIzquierdoInputs.Controls.Add(label4);
            panelIzquierdoInputs.Controls.Add(dtpFin);
            panelIzquierdoInputs.Controls.Add(btnGuardar);
            panelIzquierdoInputs.Controls.Add(btnVolver);
            panelIzquierdoInputs.Location = new Point(39, 50);
            panelIzquierdoInputs.Name = "panelIzquierdoInputs";
            panelIzquierdoInputs.Size = new Size(320, 400);
            panelIzquierdoInputs.TabIndex = 0;
            // 
            // tratamientosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(950, 500);
            Controls.Add(tablaGlobal);
            Name = "tratamientosForm";
            Text = "Sanar Rural - Gestión de Tratamientos";
            Load += tratamientosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            tablaGlobal.ResumeLayout(false);
            panelIzquierdoInputs.ResumeLayout(false);
            panelIzquierdoInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TableLayoutPanel tablaGlobal;
        private Panel panelIzquierdoInputs;
    }
}