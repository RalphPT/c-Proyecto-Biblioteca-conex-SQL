namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaOculta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.PictureBox();
            this.txtContraseñaVista = new System.Windows.Forms.TextBox();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 62);
            this.label4.TabIndex = 8;
            this.label4.Text = "BIBLIOTECA TELLINA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(377, 155);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseñaOculta
            // 
            this.txtContraseñaOculta.Location = new System.Drawing.Point(377, 210);
            this.txtContraseñaOculta.Name = "txtContraseñaOculta";
            this.txtContraseñaOculta.PasswordChar = '*';
            this.txtContraseñaOculta.Size = new System.Drawing.Size(163, 20);
            this.txtContraseñaOculta.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(551, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(400, 253);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 29);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Recuerde que el usuario es su DNI!";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(275, 314);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(109, 13);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.TabStop = true;
            this.lblContraseña.Text = "Olvidé mi contraseña:";
            this.lblContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblContraseña_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.Location = new System.Drawing.Point(546, 210);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(28, 20);
            this.btnMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostrar.TabIndex = 21;
            this.btnMostrar.TabStop = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtContraseñaVista
            // 
            this.txtContraseñaVista.Location = new System.Drawing.Point(377, 210);
            this.txtContraseñaVista.Name = "txtContraseñaVista";
            this.txtContraseñaVista.Size = new System.Drawing.Size(163, 20);
            this.txtContraseñaVista.TabIndex = 22;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.Location = new System.Drawing.Point(546, 210);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(28, 20);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 23;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Visible = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(643, 351);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtContraseñaOculta);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContraseñaVista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseñaOculta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblContraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMostrar;
        private System.Windows.Forms.TextBox txtContraseñaVista;
        private System.Windows.Forms.PictureBox btnOcultar;
    }
}