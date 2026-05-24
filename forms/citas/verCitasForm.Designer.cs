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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layoutGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.layoutCabecera = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutGlobal.SuspendLayout();
            this.layoutCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mis Citas Médicas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(23, 83);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(854, 384);
            this.dgvCitas.TabIndex = 1;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVolver.BackColor = System.Drawing.Color.LightCoral;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(23, 480);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(160, 40);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "← Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // layoutGlobal
            // 
            this.layoutGlobal.BackColor = System.Drawing.Color.SteelBlue;
            this.layoutGlobal.ColumnCount = 1;
            this.layoutGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutGlobal.Controls.Add(this.layoutCabecera, 0, 0);
            this.layoutGlobal.Controls.Add(this.dgvCitas, 0, 1);
            this.layoutGlobal.Controls.Add(this.btnVolver, 0, 2);
            this.layoutGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGlobal.Location = new System.Drawing.Point(0, 0);
            this.layoutGlobal.Name = "layoutGlobal";
            this.layoutGlobal.Padding = new System.Windows.Forms.Padding(20);
            this.layoutGlobal.RowCount = 3;
            this.layoutGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutGlobal.Size = new System.Drawing.Size(900, 550);
            this.layoutGlobal.TabIndex = 0;
            // 
            // layoutCabecera
            // 
            this.layoutCabecera.ColumnCount = 2;
            this.layoutCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutCabecera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutCabecera.Controls.Add(this.lblTitulo, 0, 0);
            this.layoutCabecera.Controls.Add(this.pictureBox1, 1, 0);
            this.layoutCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCabecera.Location = new System.Drawing.Point(23, 23);
            this.layoutCabecera.Name = "layoutCabecera";
            this.layoutCabecera.RowCount = 1;
            this.layoutCabecera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCabecera.Size = new System.Drawing.Size(854, 54);
            this.layoutCabecera.TabIndex = 0;
            // 
            // verCitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.layoutGlobal);
            this.Name = "verCitasForm";
            this.Text = "Sanar Rural - Historial de Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutGlobal.ResumeLayout(false);
            this.layoutCabecera.ResumeLayout(false);
            this.layoutCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel layoutGlobal;
        private System.Windows.Forms.TableLayoutPanel layoutCabecera;
    }
}