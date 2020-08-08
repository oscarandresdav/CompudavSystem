namespace CompudavSystem.configuracion
{
    partial class Configuracion
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
            this.printerGroupBox = new System.Windows.Forms.GroupBox();
            this.presetDeterminadoLabel = new System.Windows.Forms.Label();
            this.predeterminadoButton = new System.Windows.Forms.Button();
            this.fontSizeTextBox = new System.Windows.Forms.TextBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.positionGroupBox = new System.Windows.Forms.GroupBox();
            this.headerXLabel = new System.Windows.Forms.Label();
            this.footerYTextBox = new System.Windows.Forms.TextBox();
            this.headerXTextBox = new System.Windows.Forms.TextBox();
            this.footerYLabel = new System.Windows.Forms.Label();
            this.mainXLabel = new System.Windows.Forms.Label();
            this.mainYTextBox = new System.Windows.Forms.TextBox();
            this.footerXTextBox = new System.Windows.Forms.TextBox();
            this.mainYLabel = new System.Windows.Forms.Label();
            this.mainXTextBox = new System.Windows.Forms.TextBox();
            this.headerYTextBox = new System.Windows.Forms.TextBox();
            this.footerXLabel = new System.Windows.Forms.Label();
            this.headerYLabel = new System.Windows.Forms.Label();
            this.fontFamilyLabel = new System.Windows.Forms.Label();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.printerNameLabel = new System.Windows.Forms.Label();
            this.printerNameComboBox = new System.Windows.Forms.ComboBox();
            this.tituloPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.presetLabel = new System.Windows.Forms.Label();
            this.presetComboBox = new System.Windows.Forms.ComboBox();
            this.addPresetButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.pageSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.anchoLabel = new System.Windows.Forms.Label();
            this.anchoTextBox = new System.Windows.Forms.TextBox();
            this.altoTextBox = new System.Windows.Forms.TextBox();
            this.altoLabel = new System.Windows.Forms.Label();
            this.printerGroupBox.SuspendLayout();
            this.positionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).BeginInit();
            this.pageSizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerGroupBox
            // 
            this.printerGroupBox.Controls.Add(this.pageSizeGroupBox);
            this.printerGroupBox.Controls.Add(this.presetDeterminadoLabel);
            this.printerGroupBox.Controls.Add(this.predeterminadoButton);
            this.printerGroupBox.Controls.Add(this.fontSizeTextBox);
            this.printerGroupBox.Controls.Add(this.fontSizeLabel);
            this.printerGroupBox.Controls.Add(this.positionGroupBox);
            this.printerGroupBox.Controls.Add(this.fontFamilyLabel);
            this.printerGroupBox.Controls.Add(this.fontFamilyComboBox);
            this.printerGroupBox.Controls.Add(this.printerNameLabel);
            this.printerGroupBox.Controls.Add(this.printerNameComboBox);
            this.printerGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.printerGroupBox.Location = new System.Drawing.Point(50, 100);
            this.printerGroupBox.Name = "printerGroupBox";
            this.printerGroupBox.Size = new System.Drawing.Size(680, 280);
            this.printerGroupBox.TabIndex = 2;
            this.printerGroupBox.TabStop = false;
            this.printerGroupBox.Text = "Impresión";
            // 
            // presetDeterminadoLabel
            // 
            this.presetDeterminadoLabel.AutoSize = true;
            this.presetDeterminadoLabel.Location = new System.Drawing.Point(443, 241);
            this.presetDeterminadoLabel.Name = "presetDeterminadoLabel";
            this.presetDeterminadoLabel.Size = new System.Drawing.Size(0, 15);
            this.presetDeterminadoLabel.TabIndex = 8;
            // 
            // predeterminadoButton
            // 
            this.predeterminadoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.predeterminadoButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predeterminadoButton.ForeColor = System.Drawing.Color.White;
            this.predeterminadoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.predeterminadoButton.Location = new System.Drawing.Point(446, 175);
            this.predeterminadoButton.Name = "predeterminadoButton";
            this.predeterminadoButton.Size = new System.Drawing.Size(140, 60);
            this.predeterminadoButton.TabIndex = 3;
            this.predeterminadoButton.Text = "Establecer Preset Predeterminado";
            this.predeterminadoButton.UseVisualStyleBackColor = false;
            this.predeterminadoButton.Click += new System.EventHandler(this.PredeterminadoButton_Click);
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.Location = new System.Drawing.Point(589, 47);
            this.fontSizeTextBox.MaxLength = 255;
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.Size = new System.Drawing.Size(45, 22);
            this.fontSizeTextBox.TabIndex = 2;
            this.fontSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fontSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FontSizeTextBox_KeyPress);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(586, 25);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(49, 15);
            this.fontSizeLabel.TabIndex = 7;
            this.fontSizeLabel.Text = "Tamaño";
            // 
            // positionGroupBox
            // 
            this.positionGroupBox.Controls.Add(this.headerXLabel);
            this.positionGroupBox.Controls.Add(this.footerYTextBox);
            this.positionGroupBox.Controls.Add(this.headerXTextBox);
            this.positionGroupBox.Controls.Add(this.footerYLabel);
            this.positionGroupBox.Controls.Add(this.mainXLabel);
            this.positionGroupBox.Controls.Add(this.mainYTextBox);
            this.positionGroupBox.Controls.Add(this.footerXTextBox);
            this.positionGroupBox.Controls.Add(this.mainYLabel);
            this.positionGroupBox.Controls.Add(this.mainXTextBox);
            this.positionGroupBox.Controls.Add(this.headerYTextBox);
            this.positionGroupBox.Controls.Add(this.footerXLabel);
            this.positionGroupBox.Controls.Add(this.headerYLabel);
            this.positionGroupBox.Location = new System.Drawing.Point(63, 75);
            this.positionGroupBox.Name = "positionGroupBox";
            this.positionGroupBox.Size = new System.Drawing.Size(225, 165);
            this.positionGroupBox.TabIndex = 5;
            this.positionGroupBox.TabStop = false;
            this.positionGroupBox.Text = "Impresión - Posición";
            // 
            // headerXLabel
            // 
            this.headerXLabel.AutoSize = true;
            this.headerXLabel.Location = new System.Drawing.Point(10, 25);
            this.headerXLabel.Name = "headerXLabel";
            this.headerXLabel.Size = new System.Drawing.Size(78, 15);
            this.headerXLabel.TabIndex = 6;
            this.headerXLabel.Text = "Encabezado X";
            // 
            // footerYTextBox
            // 
            this.footerYTextBox.Location = new System.Drawing.Point(132, 129);
            this.footerYTextBox.MaxLength = 255;
            this.footerYTextBox.Name = "footerYTextBox";
            this.footerYTextBox.Size = new System.Drawing.Size(75, 22);
            this.footerYTextBox.TabIndex = 5;
            this.footerYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.footerYTextBox.TextChanged += new System.EventHandler(this.FooterYTextBox_TextChanged);
            this.footerYTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FooterYTextBox_KeyDown);
            this.footerYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FooterYTextBox_KeyPress);
            // 
            // headerXTextBox
            // 
            this.headerXTextBox.Location = new System.Drawing.Point(13, 43);
            this.headerXTextBox.MaxLength = 255;
            this.headerXTextBox.Name = "headerXTextBox";
            this.headerXTextBox.Size = new System.Drawing.Size(75, 22);
            this.headerXTextBox.TabIndex = 0;
            this.headerXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.headerXTextBox.TextChanged += new System.EventHandler(this.HeaderXTextBox_TextChanged);
            this.headerXTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeaderXTextBox_KeyDown);
            this.headerXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeaderXTextBox_KeyPress);
            // 
            // footerYLabel
            // 
            this.footerYLabel.AutoSize = true;
            this.footerYLabel.Location = new System.Drawing.Point(129, 111);
            this.footerYLabel.Name = "footerYLabel";
            this.footerYLabel.Size = new System.Drawing.Size(53, 15);
            this.footerYLabel.TabIndex = 11;
            this.footerYLabel.Text = "Totales Y";
            // 
            // mainXLabel
            // 
            this.mainXLabel.AutoSize = true;
            this.mainXLabel.Location = new System.Drawing.Point(10, 68);
            this.mainXLabel.Name = "mainXLabel";
            this.mainXLabel.Size = new System.Drawing.Size(52, 15);
            this.mainXLabel.TabIndex = 8;
            this.mainXLabel.Text = "Detalle X";
            // 
            // mainYTextBox
            // 
            this.mainYTextBox.Location = new System.Drawing.Point(132, 86);
            this.mainYTextBox.MaxLength = 255;
            this.mainYTextBox.Name = "mainYTextBox";
            this.mainYTextBox.Size = new System.Drawing.Size(75, 22);
            this.mainYTextBox.TabIndex = 3;
            this.mainYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mainYTextBox.TextChanged += new System.EventHandler(this.MainYTextBox_TextChanged);
            this.mainYTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainYTextBox_KeyDown);
            this.mainYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainYTextBox_KeyPress);
            // 
            // footerXTextBox
            // 
            this.footerXTextBox.Location = new System.Drawing.Point(13, 129);
            this.footerXTextBox.MaxLength = 255;
            this.footerXTextBox.Name = "footerXTextBox";
            this.footerXTextBox.Size = new System.Drawing.Size(75, 22);
            this.footerXTextBox.TabIndex = 4;
            this.footerXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.footerXTextBox.TextChanged += new System.EventHandler(this.FooterXTextBox_TextChanged);
            this.footerXTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FooterXTextBox_KeyDown);
            this.footerXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FooterXTextBox_KeyPress);
            // 
            // mainYLabel
            // 
            this.mainYLabel.AutoSize = true;
            this.mainYLabel.Location = new System.Drawing.Point(129, 68);
            this.mainYLabel.Name = "mainYLabel";
            this.mainYLabel.Size = new System.Drawing.Size(52, 15);
            this.mainYLabel.TabIndex = 9;
            this.mainYLabel.Text = "Detalle Y";
            // 
            // mainXTextBox
            // 
            this.mainXTextBox.Location = new System.Drawing.Point(13, 86);
            this.mainXTextBox.MaxLength = 255;
            this.mainXTextBox.Name = "mainXTextBox";
            this.mainXTextBox.Size = new System.Drawing.Size(75, 22);
            this.mainXTextBox.TabIndex = 2;
            this.mainXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mainXTextBox.TextChanged += new System.EventHandler(this.MainXTextBox_TextChanged);
            this.mainXTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainXTextBox_KeyDown);
            this.mainXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainXTextBox_KeyPress);
            // 
            // headerYTextBox
            // 
            this.headerYTextBox.Location = new System.Drawing.Point(132, 43);
            this.headerYTextBox.MaxLength = 255;
            this.headerYTextBox.Name = "headerYTextBox";
            this.headerYTextBox.Size = new System.Drawing.Size(75, 22);
            this.headerYTextBox.TabIndex = 1;
            this.headerYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.headerYTextBox.TextChanged += new System.EventHandler(this.HeaderYTextBox_TextChanged);
            this.headerYTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeaderYTextBox_KeyDown);
            this.headerYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeaderYTextBox_KeyPress);
            // 
            // footerXLabel
            // 
            this.footerXLabel.AutoSize = true;
            this.footerXLabel.Location = new System.Drawing.Point(10, 111);
            this.footerXLabel.Name = "footerXLabel";
            this.footerXLabel.Size = new System.Drawing.Size(53, 15);
            this.footerXLabel.TabIndex = 10;
            this.footerXLabel.Text = "Totales X";
            // 
            // headerYLabel
            // 
            this.headerYLabel.AutoSize = true;
            this.headerYLabel.Location = new System.Drawing.Point(129, 25);
            this.headerYLabel.Name = "headerYLabel";
            this.headerYLabel.Size = new System.Drawing.Size(78, 15);
            this.headerYLabel.TabIndex = 7;
            this.headerYLabel.Text = "Encabezado Y";
            // 
            // fontFamilyLabel
            // 
            this.fontFamilyLabel.AutoSize = true;
            this.fontFamilyLabel.Location = new System.Drawing.Point(400, 25);
            this.fontFamilyLabel.Name = "fontFamilyLabel";
            this.fontFamilyLabel.Size = new System.Drawing.Size(43, 15);
            this.fontFamilyLabel.TabIndex = 6;
            this.fontFamilyLabel.Text = "Fuente";
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(403, 46);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(180, 23);
            this.fontFamilyComboBox.TabIndex = 1;
            // 
            // printerNameLabel
            // 
            this.printerNameLabel.AutoSize = true;
            this.printerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.printerNameLabel.Location = new System.Drawing.Point(60, 25);
            this.printerNameLabel.Name = "printerNameLabel";
            this.printerNameLabel.Size = new System.Drawing.Size(59, 15);
            this.printerNameLabel.TabIndex = 4;
            this.printerNameLabel.Text = "Impresora";
            // 
            // printerNameComboBox
            // 
            this.printerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerNameComboBox.FormattingEnabled = true;
            this.printerNameComboBox.Location = new System.Drawing.Point(63, 46);
            this.printerNameComboBox.Name = "printerNameComboBox";
            this.printerNameComboBox.Size = new System.Drawing.Size(225, 23);
            this.printerNameComboBox.TabIndex = 0;
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.administrative_tools_36px;
            this.tituloPictureBox.Location = new System.Drawing.Point(13, 12);
            this.tituloPictureBox.Name = "tituloPictureBox";
            this.tituloPictureBox.Size = new System.Drawing.Size(40, 40);
            this.tituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tituloPictureBox.TabIndex = 8;
            this.tituloPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.tituloLabel.Location = new System.Drawing.Point(59, 24);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(109, 17);
            this.tituloLabel.TabIndex = 6;
            this.tituloLabel.Text = "Configuración";
            // 
            // presetLabel
            // 
            this.presetLabel.AutoSize = true;
            this.presetLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.presetLabel.Location = new System.Drawing.Point(315, 65);
            this.presetLabel.Name = "presetLabel";
            this.presetLabel.Size = new System.Drawing.Size(47, 18);
            this.presetLabel.TabIndex = 5;
            this.presetLabel.Text = "Preset";
            // 
            // presetComboBox
            // 
            this.presetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetComboBox.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetComboBox.FormattingEnabled = true;
            this.presetComboBox.Location = new System.Drawing.Point(368, 62);
            this.presetComboBox.Name = "presetComboBox";
            this.presetComboBox.Size = new System.Drawing.Size(60, 26);
            this.presetComboBox.TabIndex = 0;
            this.presetComboBox.SelectedIndexChanged += new System.EventHandler(this.PresetComboBox_SelectedIndexChanged);
            // 
            // addPresetButton
            // 
            this.addPresetButton.BackColor = System.Drawing.Color.White;
            this.addPresetButton.FlatAppearance.BorderSize = 0;
            this.addPresetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPresetButton.Image = global::CompudavSystem.Properties.Resources.add_22px;
            this.addPresetButton.Location = new System.Drawing.Point(431, 62);
            this.addPresetButton.Name = "addPresetButton";
            this.addPresetButton.Size = new System.Drawing.Size(27, 27);
            this.addPresetButton.TabIndex = 1;
            this.addPresetButton.UseVisualStyleBackColor = false;
            this.addPresetButton.Click += new System.EventHandler(this.AddPresetButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.ForeColor = System.Drawing.Color.Red;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelarButton.Location = new System.Drawing.Point(188, 425);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(200, 29);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.Color.Green;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aceptarButton.Location = new System.Drawing.Point(394, 425);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(200, 29);
            this.aceptarButton.TabIndex = 3;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // pageSizeGroupBox
            // 
            this.pageSizeGroupBox.Controls.Add(this.anchoLabel);
            this.pageSizeGroupBox.Controls.Add(this.anchoTextBox);
            this.pageSizeGroupBox.Controls.Add(this.altoTextBox);
            this.pageSizeGroupBox.Controls.Add(this.altoLabel);
            this.pageSizeGroupBox.Location = new System.Drawing.Point(403, 75);
            this.pageSizeGroupBox.Name = "pageSizeGroupBox";
            this.pageSizeGroupBox.Size = new System.Drawing.Size(231, 80);
            this.pageSizeGroupBox.TabIndex = 9;
            this.pageSizeGroupBox.TabStop = false;
            this.pageSizeGroupBox.Text = "Impresión - Tamaño de papel";
            // 
            // anchoLabel
            // 
            this.anchoLabel.AutoSize = true;
            this.anchoLabel.Location = new System.Drawing.Point(20, 25);
            this.anchoLabel.Name = "anchoLabel";
            this.anchoLabel.Size = new System.Drawing.Size(40, 15);
            this.anchoLabel.TabIndex = 6;
            this.anchoLabel.Text = "Ancho";
            // 
            // anchoTextBox
            // 
            this.anchoTextBox.Location = new System.Drawing.Point(23, 43);
            this.anchoTextBox.MaxLength = 255;
            this.anchoTextBox.Name = "anchoTextBox";
            this.anchoTextBox.Size = new System.Drawing.Size(75, 22);
            this.anchoTextBox.TabIndex = 0;
            this.anchoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // altoTextBox
            // 
            this.altoTextBox.Location = new System.Drawing.Point(132, 43);
            this.altoTextBox.MaxLength = 255;
            this.altoTextBox.Name = "altoTextBox";
            this.altoTextBox.Size = new System.Drawing.Size(75, 22);
            this.altoTextBox.TabIndex = 1;
            this.altoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // altoLabel
            // 
            this.altoLabel.AutoSize = true;
            this.altoLabel.Location = new System.Drawing.Point(129, 25);
            this.altoLabel.Name = "altoLabel";
            this.altoLabel.Size = new System.Drawing.Size(28, 15);
            this.altoLabel.TabIndex = 7;
            this.altoLabel.Text = "Alto";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.addPresetButton);
            this.Controls.Add(this.presetLabel);
            this.Controls.Add(this.presetComboBox);
            this.Controls.Add(this.tituloPictureBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.printerGroupBox);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.printerGroupBox.ResumeLayout(false);
            this.printerGroupBox.PerformLayout();
            this.positionGroupBox.ResumeLayout(false);
            this.positionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            this.pageSizeGroupBox.ResumeLayout(false);
            this.pageSizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox printerGroupBox;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label presetLabel;
        public System.Windows.Forms.ComboBox presetComboBox;
        private System.Windows.Forms.Button addPresetButton;
        private System.Windows.Forms.Button cancelarButton;
        public System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label fontFamilyLabel;
        public System.Windows.Forms.ComboBox fontFamilyComboBox;
        private System.Windows.Forms.Label printerNameLabel;
        public System.Windows.Forms.ComboBox printerNameComboBox;
        public System.Windows.Forms.TextBox headerXTextBox;
        private System.Windows.Forms.Label headerXLabel;
        public System.Windows.Forms.TextBox fontSizeTextBox;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.GroupBox positionGroupBox;
        public System.Windows.Forms.TextBox footerYTextBox;
        private System.Windows.Forms.Label footerYLabel;
        private System.Windows.Forms.Label mainXLabel;
        public System.Windows.Forms.TextBox mainYTextBox;
        public System.Windows.Forms.TextBox footerXTextBox;
        private System.Windows.Forms.Label mainYLabel;
        public System.Windows.Forms.TextBox mainXTextBox;
        public System.Windows.Forms.TextBox headerYTextBox;
        private System.Windows.Forms.Label footerXLabel;
        private System.Windows.Forms.Label headerYLabel;
        public System.Windows.Forms.Button predeterminadoButton;
        private System.Windows.Forms.Label presetDeterminadoLabel;
        private System.Windows.Forms.GroupBox pageSizeGroupBox;
        private System.Windows.Forms.Label anchoLabel;
        public System.Windows.Forms.TextBox anchoTextBox;
        public System.Windows.Forms.TextBox altoTextBox;
        private System.Windows.Forms.Label altoLabel;
    }
}