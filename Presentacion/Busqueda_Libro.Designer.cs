namespace Presentacion
{
    partial class Busqueda_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_Libro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnSalir = new Presentacion.Boton_Circular();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 79);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "CATÁLOGO DE LIBROS";
            // 
            // txtLibro
            // 
            this.txtLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLibro.Location = new System.Drawing.Point(86, 113);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(277, 20);
            this.txtLibro.TabIndex = 44;
            this.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLibro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLibro_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Libro:";
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(26, 151);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.Size = new System.Drawing.Size(677, 481);
            this.dgvCatalogo.TabIndex = 46;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Peru;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Peru;
            this.btnSalir.Location = new System.Drawing.Point(641, 641);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 49);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Busqueda_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(727, 699);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda_Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_Libro";
            this.Load += new System.EventHandler(this.Busqueda_Libro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private Boton_Circular btnSalir;
    }
}