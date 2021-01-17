namespace Presentacion
{
    partial class Prestamos_Computadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos_Computadora));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblApellidosAlumno = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNombreComputadora = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBibliotecario = new System.Windows.Forms.TextBox();
            this.dgvPrestamosComputadora = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.btnMarcarSalida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtId_Bib = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosComputadora)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(28, 697);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 35);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(768, 697);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 35);
            this.btnConfirmar.TabIndex = 38;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblApellidosAlumno);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lblNombreComputadora);
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblNombreAlumno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboEspecialidad);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 146);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // lblNombreComputadora
            // 
            this.lblNombreComputadora.AutoSize = true;
            this.lblNombreComputadora.Location = new System.Drawing.Point(332, 102);
            this.lblNombreComputadora.Name = "lblNombreComputadora";
            this.lblNombreComputadora.Size = new System.Drawing.Size(111, 13);
            this.lblNombreComputadora.TabIndex = 34;
            this.lblNombreComputadora.Text = "NO ENCONTRADO!!!";
            this.lblNombreComputadora.Visible = false;
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
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(334, 69);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "ESPECIALIDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "COMPUTADORA #";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(320, 32);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(218, 21);
            this.cboEspecialidad.TabIndex = 23;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(808, 117);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 15);
            this.lblHora.TabIndex = 46;
            this.lblHora.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "FECHA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "BIBLIOTECARIO:";
            // 
            // txtBibliotecario
            // 
            this.txtBibliotecario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBibliotecario.Enabled = false;
            this.txtBibliotecario.Location = new System.Drawing.Point(122, 112);
            this.txtBibliotecario.MaxLength = 50;
            this.txtBibliotecario.Name = "txtBibliotecario";
            this.txtBibliotecario.Size = new System.Drawing.Size(281, 20);
            this.txtBibliotecario.TabIndex = 43;
            this.txtBibliotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvPrestamosComputadora
            // 
            this.dgvPrestamosComputadora.AllowUserToAddRows = false;
            this.dgvPrestamosComputadora.AllowUserToDeleteRows = false;
            this.dgvPrestamosComputadora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamosComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosComputadora.Location = new System.Drawing.Point(12, 305);
            this.dgvPrestamosComputadora.Name = "dgvPrestamosComputadora";
            this.dgvPrestamosComputadora.ReadOnly = true;
            this.dgvPrestamosComputadora.Size = new System.Drawing.Size(884, 363);
            this.dgvPrestamosComputadora.TabIndex = 41;
            this.dgvPrestamosComputadora.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrestamosComputadora_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(-1, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 79);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(653, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRÉSTAMOS DE COMPUTADORAS";
            // 
            // Hora
            // 
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha2.Location = new System.Drawing.Point(589, 117);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(55, 15);
            this.lblFecha2.TabIndex = 48;
            this.lblFecha2.Text = "FECHA:";
            this.lblFecha2.Visible = false;
            // 
            // btnMarcarSalida
            // 
            this.btnMarcarSalida.BackColor = System.Drawing.Color.Black;
            this.btnMarcarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarSalida.ForeColor = System.Drawing.Color.White;
            this.btnMarcarSalida.Location = new System.Drawing.Point(162, 697);
            this.btnMarcarSalida.Name = "btnMarcarSalida";
            this.btnMarcarSalida.Size = new System.Drawing.Size(116, 35);
            this.btnMarcarSalida.TabIndex = 49;
            this.btnMarcarSalida.Text = "Marcar Salida";
            this.btnMarcarSalida.UseVisualStyleBackColor = false;
            this.btnMarcarSalida.Click += new System.EventHandler(this.btnMarcarSalida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(748, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtId_Bib
            // 
            this.txtId_Bib.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId_Bib.Enabled = false;
            this.txtId_Bib.Location = new System.Drawing.Point(429, 112);
            this.txtId_Bib.MaxLength = 50;
            this.txtId_Bib.Name = "txtId_Bib";
            this.txtId_Bib.Size = new System.Drawing.Size(26, 20);
            this.txtId_Bib.TabIndex = 50;
            this.txtId_Bib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId_Bib.Visible = false;
            // 
            // Prestamos_Computadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(908, 760);
            this.Controls.Add(this.txtId_Bib);
            this.Controls.Add(this.btnMarcarSalida);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBibliotecario);
            this.Controls.Add(this.dgvPrestamosComputadora);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prestamos_Computadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos_Computadora";
            this.Load += new System.EventHandler(this.Prestamos_Computadora_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosComputadora)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblApellidosAlumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBibliotecario;
        private System.Windows.Forms.DataGridView dgvPrestamosComputadora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Label lblNombreComputadora;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Button btnMarcarSalida;
        private System.Windows.Forms.TextBox txtId_Bib;
    }
}