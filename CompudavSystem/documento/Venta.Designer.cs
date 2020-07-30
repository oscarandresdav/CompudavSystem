namespace CompudavSystem.documento
{
    partial class Venta
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.dateIssueLabel = new System.Windows.Forms.Label();
            this.dateIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.landlineLabel = new System.Windows.Forms.Label();
            this.landlineTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tituloPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.nuevoButton);
            this.headerPanel.Controls.Add(this.printButton);
            this.headerPanel.Controls.Add(this.dateIssueLabel);
            this.headerPanel.Controls.Add(this.dateIssueDateTimePicker);
            this.headerPanel.Controls.Add(this.landlineLabel);
            this.headerPanel.Controls.Add(this.landlineTextBox);
            this.headerPanel.Controls.Add(this.addressLabel);
            this.headerPanel.Controls.Add(this.addressTextBox);
            this.headerPanel.Controls.Add(this.idNumberLabel);
            this.headerPanel.Controls.Add(this.idNumberTextBox);
            this.headerPanel.Controls.Add(this.nameLabel);
            this.headerPanel.Controls.Add(this.nameTextBox);
            this.headerPanel.Controls.Add(this.tituloPictureBox);
            this.headerPanel.Controls.Add(this.tituloLabel);
            this.headerPanel.Location = new System.Drawing.Point(10, 10);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(760, 150);
            this.headerPanel.TabIndex = 0;
            // 
            // nuevoButton
            // 
            this.nuevoButton.BackColor = System.Drawing.Color.White;
            this.nuevoButton.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.nuevoButton.Location = new System.Drawing.Point(657, 3);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(100, 40);
            this.nuevoButton.TabIndex = 5;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.printButton.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(551, 3);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 40);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Imprimir";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // dateIssueLabel
            // 
            this.dateIssueLabel.AutoSize = true;
            this.dateIssueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.dateIssueLabel.Location = new System.Drawing.Point(477, 73);
            this.dateIssueLabel.Name = "dateIssueLabel";
            this.dateIssueLabel.Size = new System.Drawing.Size(97, 15);
            this.dateIssueLabel.TabIndex = 15;
            this.dateIssueLabel.Text = "Fecha de emisión";
            // 
            // dateIssueDateTimePicker
            // 
            this.dateIssueDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.dateIssueDateTimePicker.Location = new System.Drawing.Point(480, 91);
            this.dateIssueDateTimePicker.Name = "dateIssueDateTimePicker";
            this.dateIssueDateTimePicker.Size = new System.Drawing.Size(233, 22);
            this.dateIssueDateTimePicker.TabIndex = 4;
            // 
            // landlineLabel
            // 
            this.landlineLabel.AutoSize = true;
            this.landlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.landlineLabel.Location = new System.Drawing.Point(39, 118);
            this.landlineLabel.Name = "landlineLabel";
            this.landlineLabel.Size = new System.Drawing.Size(53, 15);
            this.landlineLabel.TabIndex = 11;
            this.landlineLabel.Text = "Teléfono";
            // 
            // landlineTextBox
            // 
            this.landlineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.landlineTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.landlineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.landlineTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.landlineTextBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landlineTextBox.Location = new System.Drawing.Point(98, 118);
            this.landlineTextBox.Name = "landlineTextBox";
            this.landlineTextBox.Size = new System.Drawing.Size(300, 15);
            this.landlineTextBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.addressLabel.Location = new System.Drawing.Point(37, 97);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(55, 15);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Dirección";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.addressTextBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(98, 97);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(300, 15);
            this.addressTextBox.TabIndex = 2;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.idNumberLabel.Location = new System.Drawing.Point(15, 55);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(77, 15);
            this.idNumberLabel.TabIndex = 8;
            this.idNumberLabel.Text = "Identificación";
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idNumberTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idNumberTextBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(98, 55);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(300, 15);
            this.idNumberTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.nameLabel.Location = new System.Drawing.Point(43, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 15);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(98, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 15);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.market_square_36px;
            this.tituloPictureBox.Location = new System.Drawing.Point(3, 2);
            this.tituloPictureBox.Name = "tituloPictureBox";
            this.tituloPictureBox.Size = new System.Drawing.Size(40, 40);
            this.tituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tituloPictureBox.TabIndex = 1;
            this.tituloPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.tituloLabel.Location = new System.Drawing.Point(50, 14);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(51, 17);
            this.tituloLabel.TabIndex = 7;
            this.tituloLabel.Text = "Venta";
            // 
            // footerPanel
            // 
            this.footerPanel.Location = new System.Drawing.Point(10, 450);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(760, 180);
            this.footerPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listadoDataGridView);
            this.mainPanel.Location = new System.Drawing.Point(10, 165);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 280);
            this.mainPanel.TabIndex = 1;
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.RowHeadersVisible = false;
            this.listadoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoDataGridView.Size = new System.Drawing.Size(754, 274);
            this.listadoDataGridView.TabIndex = 2;
            this.listadoDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListadoDataGridView_KeyDown);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label landlineLabel;
        public System.Windows.Forms.TextBox landlineTextBox;
        private System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label idNumberLabel;
        public System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label dateIssueLabel;
        private System.Windows.Forms.DateTimePicker dateIssueDateTimePicker;
        private System.Windows.Forms.DataGridView listadoDataGridView;
    }
}