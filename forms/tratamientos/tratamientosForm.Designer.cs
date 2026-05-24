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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.panelIzquierdoInputs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.tablaGlobal.SuspendLayout();
            this.panelIzquierdoInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Tratamientos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción del Tratamiento:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(10, 90);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 60);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(10, 190);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(300, 27);
            this.dtpInicio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Finalización:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(10, 255);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(300, 27);
            this.dtpFin.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(10, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightCoral;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(165, 310);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(145, 40);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTratamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTratamientos.Location = new System.Drawing.Point(386, 18);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.Size = new System.Drawing.Size(546, 464);
            this.dgvTratamientos.TabIndex = 1;
            this.dgvTratamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTratamientos_CellContentClick);
            // 
            // tablaGlobal
            // 
            this.tablaGlobal.BackColor = System.Drawing.Color.SteelBlue;
            this.tablaGlobal.ColumnCount = 2;
            this.tablaGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablaGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablaGlobal.Controls.Add(this.panelIzquierdoInputs, 0, 0);
            this.tablaGlobal.Controls.Add(this.dgvTratamientos, 1, 0);
            this.tablaGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaGlobal.Location = new System.Drawing.Point(0, 0);
            this.tablaGlobal.Name = "tablaGlobal";
            this.tablaGlobal.Padding = new System.Windows.Forms.Padding(15);
            this.tablaGlobal.RowCount = 1;
            this.tablaGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablaGlobal.Size = new System.Drawing.Size(950, 500);
            this.tablaGlobal.TabIndex = 0;
            // 
            // panelIzquierdoInputs
            // 
            this.panelIzquierdoInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIzquierdoInputs.Controls.Add(this.lblTitulo);
            this.panelIzquierdoInputs.Controls.Add(this.label2);
            this.panelIzquierdoInputs.Controls.Add(this.txtDescripcion);
            this.panelIzquierdoInputs.Controls.Add(this.label3);
            this.panelIzquierdoInputs.Controls.Add(this.dtpInicio);
            this.panelIzquierdoInputs.Controls.Add(this.label4);
            this.panelIzquierdoInputs.Controls.Add(this.dtpFin);
            this.panelIzquierdoInputs.Controls.Add(this.btnGuardar);
            this.panelIzquierdoInputs.Controls.Add(this.btnVolver);
            this.panelIzquierdoInputs.Location = new System.Drawing.Point(39, 50);
            this.panelIzquierdoInputs.Name = "panelIzquierdoInputs";
            this.panelIzquierdoInputs.Size = new System.Drawing.Size(320, 400);
            this.panelIzquierdoInputs.TabIndex = 0;
            // 
            // tratamientosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.tablaGlobal);
            this.Name = "tratamientosForm";
            this.Text = "Sanar Rural - Gestión de Tratamientos";
            this.Load += new System.EventHandler(this.tratamientosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.tablaGlobal.ResumeLayout(false);
            this.panelIzquierdoInputs.ResumeLayout(false);
            this.panelIzquierdoInputs.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tablaGlobal;
        private System.Windows.Forms.Panel panelIzquierdoInputs;
    }
}