namespace Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBusqueda_Libros = new Presentacion.Boton_Circular();
            this.btnSalir = new Presentacion.Boton_Circular();
            this.btnPrestamos = new Presentacion.Boton_Circular();
            this.btnMantenimiento_ = new Presentacion.Boton_Circular();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRÉSTAMOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MANTENIMIENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "BIBLIOTECA TELLINA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(568, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "BÚSQUEDA DE LIBROS";
            // 
            // btnBusqueda_Libros
            // 
            this.btnBusqueda_Libros.BackColor = System.Drawing.Color.Yellow;
            this.btnBusqueda_Libros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusqueda_Libros.BackgroundImage")));
            this.btnBusqueda_Libros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusqueda_Libros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda_Libros.Location = new System.Drawing.Point(590, 157);
            this.btnBusqueda_Libros.Name = "btnBusqueda_Libros";
            this.btnBusqueda_Libros.Size = new System.Drawing.Size(124, 110);
            this.btnBusqueda_Libros.TabIndex = 12;
            this.btnBusqueda_Libros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusqueda_Libros.UseVisualStyleBackColor = false;
            this.btnBusqueda_Libros.Click += new System.EventHandler(this.btnBusqueda_Libros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Peru;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Peru;
            this.btnSalir.Location = new System.Drawing.Point(750, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 62);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackColor = System.Drawing.Color.Yellow;
            this.btnPrestamos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrestamos.BackgroundImage")));
            this.btnPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Location = new System.Drawing.Point(358, 157);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(124, 110);
            this.btnPrestamos.TabIndex = 5;
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamos.UseVisualStyleBackColor = false;
            this.btnPrestamos.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnMantenimiento_
            // 
            this.btnMantenimiento_.BackColor = System.Drawing.Color.Yellow;
            this.btnMantenimiento_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento_.BackgroundImage")));
            this.btnMantenimiento_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMantenimiento_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento_.Location = new System.Drawing.Point(130, 157);
            this.btnMantenimiento_.Name = "btnMantenimiento_";
            this.btnMantenimiento_.Size = new System.Drawing.Size(124, 110);
            this.btnMantenimiento_.TabIndex = 3;
            this.btnMantenimiento_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimiento_.UseVisualStyleBackColor = false;
            this.btnMantenimiento_.Click += new System.EventHandler(this.btnMantenimiento__Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(842, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBusqueda_Libros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMantenimiento_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Boton_Circular btnMantenimiento_;
        private System.Windows.Forms.Label label2;
        private Boton_Circular btnPrestamos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private Boton_Circular btnSalir;
        private Boton_Circular btnBusqueda_Libros;
        private System.Windows.Forms.Label label3;
    }
}