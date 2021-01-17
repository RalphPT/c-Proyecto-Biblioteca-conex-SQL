namespace Presentacion
{
    partial class Prestamos_Libro
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBibliotecario = new System.Windows.Forms.TextBox();
            this.txtCodLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblApellidosAlumno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.txtId_Bib = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRÉSTAMOS DE LIBROS";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 325);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(871, 335);
            this.dgvPrestamos.TabIndex = 7;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CODIGO_LIBRO:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(120, 131);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(218, 21);
            this.cboEspecialidad.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ESPECIALIDAD:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(69, 66);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(111, 13);
            this.lblNombreAlumno.TabIndex = 27;
            this.lblNombreAlumno.Text = "NO ENCONTRADO!!!";
            this.lblNombreAlumno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(63, 32);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(99, 20);
            this.txtDni.TabIndex = 1;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "BIBLIOTECARIO:";
            // 
            // txtBibliotecario
            // 
            this.txtBibliotecario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBibliotecario.Enabled = false;
            this.txtBibliotecario.Location = new System.Drawing.Point(122, 104);
            this.txtBibliotecario.MaxLength = 50;
            this.txtBibliotecario.Name = "txtBibliotecario";
            this.txtBibliotecario.Size = new System.Drawing.Size(260, 20);
            this.txtBibliotecario.TabIndex = 31;
            this.txtBibliotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodLibro.Location = new System.Drawing.Point(371, 36);
            this.txtCodLibro.MaxLength = 5;
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.Size = new System.Drawing.Size(88, 20);
            this.txtCodLibro.TabIndex = 2;
            this.txtCodLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodLibro.Leave += new System.EventHandler(this.txtCodLibro_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "FECHA:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(726, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 15);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "FECHA:";
            // 
            // fecha
            // 
            this.fecha.Tick += new System.EventHandler(this.fecha_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblApellidosAlumno);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lblNombreLibro);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.txtCodLibro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblNombreAlumno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboEspecialidad);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 182);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // lblApellidosAlumno
            // 
            this.lblApellidosAlumno.AutoSize = true;
            this.lblApellidosAlumno.Location = new System.Drawing.Point(69, 82);
            this.lblApellidosAlumno.Name = "lblApellidosAlumno";
            this.lblApellidosAlumno.Size = new System.Drawing.Size(111, 13);
            this.lblApellidosAlumno.TabIndex = 36;
            this.lblApellidosAlumno.Text = "NO ENCONTRADO!!!";
            this.lblApellidosAlumno.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bookstack_libr_3024;
            this.pictureBox1.Location = new System.Drawing.Point(717, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(902, 28);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 113);
            this.textBox3.TabIndex = 7;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(371, 70);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(111, 13);
            this.lblNombreLibro.TabIndex = 34;
            this.lblNombreLibro.Text = "NO ENCONTRADO!!!";
            this.lblNombreLibro.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(31, 677);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(759, 677);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.Black;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Location = new System.Drawing.Point(179, 677);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(116, 35);
            this.btnEstado.TabIndex = 4;
            this.btnEstado.Text = "Cambiar Estado";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // txtId_Bib
            // 
            this.txtId_Bib.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId_Bib.Enabled = false;
            this.txtId_Bib.Location = new System.Drawing.Point(406, 104);
            this.txtId_Bib.MaxLength = 50;
            this.txtId_Bib.Name = "txtId_Bib";
            this.txtId_Bib.Size = new System.Drawing.Size(32, 20);
            this.txtId_Bib.TabIndex = 44;
            this.txtId_Bib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId_Bib.Visible = false;
            // 
            // Prestamos_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(895, 729);
            this.Controls.Add(this.txtId_Bib);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBibliotecario);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestamos_Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBibliotecario;
        private System.Windows.Forms.TextBox txtCodLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer fecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblApellidosAlumno;
        public System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtId_Bib;
    }
}