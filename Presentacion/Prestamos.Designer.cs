namespace Presentacion
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new Presentacion.Boton_Circular();
            this.btnLibros = new Presentacion.Boton_Circular();
            this.btnComputadoras = new Presentacion.Boton_Circular();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-2, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "BIBLIOTECA TELLINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "LIBROS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "COMPUTADORAS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Peru;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Peru;
            this.btnSalir.Location = new System.Drawing.Point(514, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 62);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Yellow;
            this.btnLibros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLibros.BackgroundImage")));
            this.btnLibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Location = new System.Drawing.Point(107, 172);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(124, 110);
            this.btnLibros.TabIndex = 15;
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnComputadoras
            // 
            this.btnComputadoras.BackColor = System.Drawing.Color.Yellow;
            this.btnComputadoras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComputadoras.BackgroundImage")));
            this.btnComputadoras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComputadoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputadoras.Location = new System.Drawing.Point(353, 172);
            this.btnComputadoras.Name = "btnComputadoras";
            this.btnComputadoras.Size = new System.Drawing.Size(124, 110);
            this.btnComputadoras.TabIndex = 13;
            this.btnComputadoras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComputadoras.UseVisualStyleBackColor = false;
            this.btnComputadoras.Click += new System.EventHandler(this.btnComputadoras_Click);
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(603, 449);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComputadoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Boton_Circular btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Boton_Circular btnLibros;
        private System.Windows.Forms.Label label1;
        private Boton_Circular btnComputadoras;
    }
}