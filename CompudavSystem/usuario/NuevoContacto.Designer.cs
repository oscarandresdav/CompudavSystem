namespace CompudavSystem.usuario
{
    partial class NuevoContacto
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
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.businessNameLabel = new System.Windows.Forms.Label();
            this.tradenameTextBox = new System.Windows.Forms.TextBox();
            this.tradenameLabel = new System.Windows.Forms.Label();
            this.typeIdentificationComboBox = new System.Windows.Forms.ComboBox();
            this.typeIdentificationLabel = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.clientCheckBox = new System.Windows.Forms.CheckBox();
            this.tipoContactoGroupBox = new System.Windows.Forms.GroupBox();
            this.providerCheckBox = new System.Windows.Forms.CheckBox();
            this.specialTaxpayerCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.landlineTextBox = new System.Windows.Forms.TextBox();
            this.landlineLabel = new System.Windows.Forms.Label();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneLabel = new System.Windows.Forms.Label();
            this.additionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.additionalInformationLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.tipoContactoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.businessNameTextBox.Location = new System.Drawing.Point(40, 38);
            this.businessNameTextBox.MaxLength = 255;
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(406, 22);
            this.businessNameTextBox.TabIndex = 1;
            // 
            // businessNameLabel
            // 
            this.businessNameLabel.AutoSize = true;
            this.businessNameLabel.Location = new System.Drawing.Point(20, 20);
            this.businessNameLabel.Name = "businessNameLabel";
            this.businessNameLabel.Size = new System.Drawing.Size(71, 15);
            this.businessNameLabel.TabIndex = 2;
            this.businessNameLabel.Text = "Razón social";
            // 
            // tradenameTextBox
            // 
            this.tradenameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tradenameTextBox.Location = new System.Drawing.Point(40, 81);
            this.tradenameTextBox.MaxLength = 255;
            this.tradenameTextBox.Name = "tradenameTextBox";
            this.tradenameTextBox.Size = new System.Drawing.Size(406, 22);
            this.tradenameTextBox.TabIndex = 3;
            // 
            // tradenameLabel
            // 
            this.tradenameLabel.AutoSize = true;
            this.tradenameLabel.Location = new System.Drawing.Point(20, 63);
            this.tradenameLabel.Name = "tradenameLabel";
            this.tradenameLabel.Size = new System.Drawing.Size(101, 15);
            this.tradenameLabel.TabIndex = 4;
            this.tradenameLabel.Text = "Nombre comercial";
            // 
            // typeIdentificationComboBox
            // 
            this.typeIdentificationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeIdentificationComboBox.FormattingEnabled = true;
            this.typeIdentificationComboBox.Location = new System.Drawing.Point(40, 167);
            this.typeIdentificationComboBox.Name = "typeIdentificationComboBox";
            this.typeIdentificationComboBox.Size = new System.Drawing.Size(180, 23);
            this.typeIdentificationComboBox.TabIndex = 13;
            // 
            // typeIdentificationLabel
            // 
            this.typeIdentificationLabel.AutoSize = true;
            this.typeIdentificationLabel.Location = new System.Drawing.Point(20, 149);
            this.typeIdentificationLabel.Name = "typeIdentificationLabel";
            this.typeIdentificationLabel.Size = new System.Drawing.Size(119, 15);
            this.typeIdentificationLabel.TabIndex = 14;
            this.typeIdentificationLabel.Text = "Tipo de identificación";
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idNumberTextBox.Location = new System.Drawing.Point(266, 167);
            this.idNumberTextBox.MaxLength = 45;
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(180, 22);
            this.idNumberTextBox.TabIndex = 15;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(246, 149);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(77, 15);
            this.idNumberLabel.TabIndex = 16;
            this.idNumberLabel.Text = "Identificación";
            // 
            // clientCheckBox
            // 
            this.clientCheckBox.AutoSize = true;
            this.clientCheckBox.Location = new System.Drawing.Point(10, 20);
            this.clientCheckBox.Name = "clientCheckBox";
            this.clientCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientCheckBox.Size = new System.Drawing.Size(62, 19);
            this.clientCheckBox.TabIndex = 18;
            this.clientCheckBox.Text = "Cliente";
            this.clientCheckBox.UseVisualStyleBackColor = true;
            // 
            // tipoContactoGroupBox
            // 
            this.tipoContactoGroupBox.Controls.Add(this.specialTaxpayerCheckBox);
            this.tipoContactoGroupBox.Controls.Add(this.providerCheckBox);
            this.tipoContactoGroupBox.Controls.Add(this.clientCheckBox);
            this.tipoContactoGroupBox.Location = new System.Drawing.Point(40, 196);
            this.tipoContactoGroupBox.Name = "tipoContactoGroupBox";
            this.tipoContactoGroupBox.Size = new System.Drawing.Size(406, 55);
            this.tipoContactoGroupBox.TabIndex = 19;
            this.tipoContactoGroupBox.TabStop = false;
            // 
            // providerCheckBox
            // 
            this.providerCheckBox.AutoSize = true;
            this.providerCheckBox.Location = new System.Drawing.Point(123, 20);
            this.providerCheckBox.Name = "providerCheckBox";
            this.providerCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.providerCheckBox.Size = new System.Drawing.Size(80, 19);
            this.providerCheckBox.TabIndex = 19;
            this.providerCheckBox.Text = "Proveedor";
            this.providerCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialTaxpayerCheckBox
            // 
            this.specialTaxpayerCheckBox.AutoSize = true;
            this.specialTaxpayerCheckBox.Location = new System.Drawing.Point(250, 20);
            this.specialTaxpayerCheckBox.Name = "specialTaxpayerCheckBox";
            this.specialTaxpayerCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.specialTaxpayerCheckBox.Size = new System.Drawing.Size(145, 19);
            this.specialTaxpayerCheckBox.TabIndex = 20;
            this.specialTaxpayerCheckBox.Text = "Contribuyente Especial";
            this.specialTaxpayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.Location = new System.Drawing.Point(40, 272);
            this.emailTextBox.MaxLength = 255;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(406, 22);
            this.emailTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 254);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 15);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Correo";
            // 
            // landlineTextBox
            // 
            this.landlineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.landlineTextBox.Location = new System.Drawing.Point(40, 315);
            this.landlineTextBox.MaxLength = 45;
            this.landlineTextBox.Name = "landlineTextBox";
            this.landlineTextBox.Size = new System.Drawing.Size(180, 22);
            this.landlineTextBox.TabIndex = 22;
            // 
            // landlineLabel
            // 
            this.landlineLabel.AutoSize = true;
            this.landlineLabel.Location = new System.Drawing.Point(20, 297);
            this.landlineLabel.Name = "landlineLabel";
            this.landlineLabel.Size = new System.Drawing.Size(125, 15);
            this.landlineLabel.TabIndex = 23;
            this.landlineLabel.Text = "Teléfono convencional";
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(266, 315);
            this.mobilePhoneTextBox.MaxLength = 45;
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(180, 22);
            this.mobilePhoneTextBox.TabIndex = 24;
            // 
            // mobilePhoneLabel
            // 
            this.mobilePhoneLabel.AutoSize = true;
            this.mobilePhoneLabel.Location = new System.Drawing.Point(246, 297);
            this.mobilePhoneLabel.Name = "mobilePhoneLabel";
            this.mobilePhoneLabel.Size = new System.Drawing.Size(90, 15);
            this.mobilePhoneLabel.TabIndex = 25;
            this.mobilePhoneLabel.Text = "Teléfono celular";
            // 
            // additionalInformationTextBox
            // 
            this.additionalInformationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.additionalInformationTextBox.Location = new System.Drawing.Point(40, 358);
            this.additionalInformationTextBox.Multiline = true;
            this.additionalInformationTextBox.Name = "additionalInformationTextBox";
            this.additionalInformationTextBox.Size = new System.Drawing.Size(406, 44);
            this.additionalInformationTextBox.TabIndex = 26;
            // 
            // additionalInformationLabel
            // 
            this.additionalInformationLabel.AutoSize = true;
            this.additionalInformationLabel.Location = new System.Drawing.Point(20, 340);
            this.additionalInformationLabel.Name = "additionalInformationLabel";
            this.additionalInformationLabel.Size = new System.Drawing.Size(117, 15);
            this.additionalInformationLabel.TabIndex = 27;
            this.additionalInformationLabel.Text = "Información adcional";
            // 
            // addressTextBox
            // 
            this.addressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addressTextBox.Location = new System.Drawing.Point(40, 124);
            this.addressTextBox.MaxLength = 255;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(406, 22);
            this.addressTextBox.TabIndex = 28;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 106);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(55, 15);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Dirección";
            // 
            // cancelarButton
            // 
            this.cancelarButton.ForeColor = System.Drawing.Color.Red;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelarButton.Location = new System.Drawing.Point(40, 440);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(200, 29);
            this.cancelarButton.TabIndex = 30;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.Color.Green;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aceptarButton.Location = new System.Drawing.Point(246, 440);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(200, 29);
            this.aceptarButton.TabIndex = 31;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 485);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.additionalInformationTextBox);
            this.Controls.Add(this.additionalInformationLabel);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(this.mobilePhoneLabel);
            this.Controls.Add(this.landlineTextBox);
            this.Controls.Add(this.landlineLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.tipoContactoGroupBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.typeIdentificationComboBox);
            this.Controls.Add(this.typeIdentificationLabel);
            this.Controls.Add(this.tradenameTextBox);
            this.Controls.Add(this.tradenameLabel);
            this.Controls.Add(this.businessNameTextBox);
            this.Controls.Add(this.businessNameLabel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoContacto";
            this.Text = "NuevoContacto";
            this.tipoContactoGroupBox.ResumeLayout(false);
            this.tipoContactoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.Label businessNameLabel;
        public System.Windows.Forms.TextBox tradenameTextBox;
        private System.Windows.Forms.Label tradenameLabel;
        public System.Windows.Forms.ComboBox typeIdentificationComboBox;
        private System.Windows.Forms.Label typeIdentificationLabel;
        public System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.CheckBox clientCheckBox;
        private System.Windows.Forms.GroupBox tipoContactoGroupBox;
        private System.Windows.Forms.CheckBox specialTaxpayerCheckBox;
        private System.Windows.Forms.CheckBox providerCheckBox;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.TextBox landlineTextBox;
        private System.Windows.Forms.Label landlineLabel;
        public System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.Label mobilePhoneLabel;
        public System.Windows.Forms.TextBox additionalInformationTextBox;
        private System.Windows.Forms.Label additionalInformationLabel;
        public System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button cancelarButton;
        public System.Windows.Forms.Button aceptarButton;
    }
}