namespace Presentacion
{
    partial class Alumno
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNocturno = new System.Windows.Forms.RadioButton();
            this.rbDiurno = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(132, 579);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(435, 579);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(340, 579);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNocturno);
            this.groupBox1.Controls.Add(this.rbDiurno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.cboEspecialidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboSemestre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Location = new System.Drawing.Point(29, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 122);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // rbNocturno
            // 
            this.rbNocturno.AutoSize = true;
            this.rbNocturno.Enabled = false;
            this.rbNocturno.Location = new System.Drawing.Point(705, 78);
            this.rbNocturno.Name = "rbNocturno";
            this.rbNocturno.Size = new System.Drawing.Size(69, 17);
            this.rbNocturno.TabIndex = 7;
            this.rbNocturno.Text = "Nocturno";
            this.rbNocturno.UseVisualStyleBackColor = true;
            // 
            // rbDiurno
            // 
            this.rbDiurno.AutoSize = true;
            this.rbDiurno.Checked = true;
            this.rbDiurno.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbDiurno.Enabled = false;
            this.rbDiurno.Location = new System.Drawing.Point(643, 78);
            this.rbDiurno.Name = "rbDiurno";
            this.rbDiurno.Size = new System.Drawing.Size(56, 17);
            this.rbDiurno.TabIndex = 6;
            this.rbDiurno.TabStop = true;
            this.rbDiurno.Text = "Diurno";
            this.rbDiurno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "TURNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "APELLIDOS:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(630, 30);
            this.txtApellidos.MaxLength = 40;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(266, 20);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.Enabled = false;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(113, 74);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(218, 21);
            this.cboEspecialidad.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ESPECIALIDAD:";
            // 
            // cboSemestre
            // 
            this.cboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemestre.Enabled = false;
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            "PRIMERO",
            "SEGUNDO",
            "TERCERO",
            "CUARTO",
            "QUINTO",
            "SEXTO"});
            this.cboSemestre.Location = new System.Drawing.Point(436, 74);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(90, 21);
            this.cboSemestre.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SEMESTRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRES:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(261, 30);
            this.txtNombres.MaxLength = 40;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(234, 20);
            this.txtNombres.TabIndex = 2;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(60, 30);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(94, 20);
            this.txtDni.TabIndex = 1;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "  ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(857, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Black;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(37, 579);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 35);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AllowUserToAddRows = false;
            this.dgvAlumno.AllowUserToDeleteRows = false;
            this.dgvAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(29, 216);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.ReadOnly = true;
            this.dgvAlumno.Size = new System.Drawing.Size(927, 345);
            this.dgvAlumno.TabIndex = 25;
            this.dgvAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_CellClick);
            this.dgvAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumno_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "MANTENIMIENTO ALUMNO";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(987, 638);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alumno_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.RadioButton rbNocturno;
        private System.Windows.Forms.RadioButton rbDiurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}