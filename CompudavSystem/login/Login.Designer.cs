namespace CompudavSystem.login
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
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(150, 173);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(150, 24);
            this.textBoxClave.TabIndex = 29;
            this.textBoxClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClave_KeyDown);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(150, 143);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(150, 24);
            this.textBoxUsuario.TabIndex = 28;
            this.textBoxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(97, 176);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(47, 17);
            this.lblClave.TabIndex = 31;
            this.lblClave.Text = "Clave :";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(84, 146);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 17);
            this.lblUsuario.TabIndex = 30;
            this.lblUsuario.Text = "Usuario :";
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracion.ForeColor = System.Drawing.Color.Red;
            this.buttonConfiguracion.Image = global::CompudavSystem.Properties.Resources.settings_24px;
            this.buttonConfiguracion.Location = new System.Drawing.Point(396, 273);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(26, 26);
            this.buttonConfiguracion.TabIndex = 34;
            this.buttonConfiguracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfiguracion.UseVisualStyleBackColor = true;
            this.buttonConfiguracion.Click += new System.EventHandler(this.ButtonConfiguracion_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.Red;
            this.buttonCerrar.Image = global::CompudavSystem.Properties.Resources.shutdown_36px;
            this.buttonCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCerrar.Location = new System.Drawing.Point(195, 239);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(60, 60);
            this.buttonCerrar.TabIndex = 33;
            this.buttonCerrar.Text = "Salir";
            this.buttonCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.buttonIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.buttonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonIniciar.Image = global::CompudavSystem.Properties.Resources.key_36px;
            this.buttonIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIniciar.Location = new System.Drawing.Point(311, 140);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(60, 60);
            this.buttonIniciar.TabIndex = 32;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.ButtonIniciar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::CompudavSystem.Properties.Resources.compudav_logo4x;
            this.logo.Location = new System.Drawing.Point(150, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 78);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxServidor.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServidor.Location = new System.Drawing.Point(311, 250);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(111, 17);
            this.textBoxServidor.TabIndex = 35;
            this.textBoxServidor.Text = "localhost";
            this.textBoxServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxServidor.Visible = false;
            this.textBoxServidor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxServidor_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.textBoxServidor);
            this.Controls.Add(this.buttonConfiguracion);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        internal System.Windows.Forms.TextBox textBoxClave;
        internal System.Windows.Forms.TextBox textBoxUsuario;
        internal System.Windows.Forms.Label lblClave;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonConfiguracion;
        internal System.Windows.Forms.TextBox textBoxServidor;
    }
}