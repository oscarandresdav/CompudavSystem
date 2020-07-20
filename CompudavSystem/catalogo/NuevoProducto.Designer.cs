namespace CompudavSystem.catalogo
{
    partial class NuevoProducto
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.mainCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.auxCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minimumStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.percentagePrice1TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.price1TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.price2TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice2TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.price3TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice3TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.unitMeasurementComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.iceRateComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ivaRateComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.typeProductComboBox = new System.Windows.Forms.ComboBox();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Location = new System.Drawing.Point(40, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(406, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTextBox_KeyDown);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.Color.Green;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aceptarButton.Location = new System.Drawing.Point(246, 455);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(200, 29);
            this.aceptarButton.TabIndex = 4;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.ForeColor = System.Drawing.Color.Red;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelarButton.Location = new System.Drawing.Point(40, 455);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(200, 29);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // mainCodeTextBox
            // 
            this.mainCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mainCodeTextBox.Location = new System.Drawing.Point(40, 81);
            this.mainCodeTextBox.Name = "mainCodeTextBox";
            this.mainCodeTextBox.Size = new System.Drawing.Size(180, 22);
            this.mainCodeTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código UPC";
            // 
            // auxCodeTextBox
            // 
            this.auxCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.auxCodeTextBox.Location = new System.Drawing.Point(266, 81);
            this.auxCodeTextBox.Name = "auxCodeTextBox";
            this.auxCodeTextBox.Size = new System.Drawing.Size(180, 22);
            this.auxCodeTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código Auxiliar";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.Location = new System.Drawing.Point(40, 124);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(406, 44);
            this.descripcionTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // stockTextBox
            // 
            this.stockTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stockTextBox.Location = new System.Drawing.Point(198, 189);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(120, 22);
            this.stockTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // costTextBox
            // 
            this.costTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.costTextBox.Location = new System.Drawing.Point(40, 276);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(110, 22);
            this.costTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de producto";
            // 
            // minimumStockLevelTextBox
            // 
            this.minimumStockLevelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.minimumStockLevelTextBox.Location = new System.Drawing.Point(356, 189);
            this.minimumStockLevelTextBox.Name = "minimumStockLevelTextBox";
            this.minimumStockLevelTextBox.Size = new System.Drawing.Size(90, 22);
            this.minimumStockLevelTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock mínimo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.price3TextBox);
            this.groupBox1.Controls.Add(this.percentagePrice3TextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.price2TextBox);
            this.groupBox1.Controls.Add(this.percentagePrice2TextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.price1TextBox);
            this.groupBox1.Controls.Add(this.percentagePrice1TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(40, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de precios";
            // 
            // percentagePrice1TextBox
            // 
            this.percentagePrice1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice1TextBox.Location = new System.Drawing.Point(96, 21);
            this.percentagePrice1TextBox.Name = "percentagePrice1TextBox";
            this.percentagePrice1TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice1TextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "%";
            // 
            // price1TextBox
            // 
            this.price1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price1TextBox.Location = new System.Drawing.Point(209, 21);
            this.price1TextBox.Name = "price1TextBox";
            this.price1TextBox.Size = new System.Drawing.Size(120, 22);
            this.price1TextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Precio";
            // 
            // price2TextBox
            // 
            this.price2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price2TextBox.Location = new System.Drawing.Point(208, 49);
            this.price2TextBox.Name = "price2TextBox";
            this.price2TextBox.Size = new System.Drawing.Size(120, 22);
            this.price2TextBox.TabIndex = 21;
            // 
            // percentagePrice2TextBox
            // 
            this.percentagePrice2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice2TextBox.Location = new System.Drawing.Point(95, 49);
            this.percentagePrice2TextBox.Name = "percentagePrice2TextBox";
            this.percentagePrice2TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice2TextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Precio";
            // 
            // price3TextBox
            // 
            this.price3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price3TextBox.Location = new System.Drawing.Point(208, 77);
            this.price3TextBox.Name = "price3TextBox";
            this.price3TextBox.Size = new System.Drawing.Size(120, 22);
            this.price3TextBox.TabIndex = 25;
            // 
            // percentagePrice3TextBox
            // 
            this.percentagePrice3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice3TextBox.Location = new System.Drawing.Point(95, 77);
            this.percentagePrice3TextBox.Name = "percentagePrice3TextBox";
            this.percentagePrice3TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice3TextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(40, 232);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(110, 23);
            this.categoryComboBox.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Categoría";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fabricante";
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(188, 232);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(110, 23);
            this.manufacturerComboBox.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Unidad de medida";
            // 
            // unitMeasurementComboBox
            // 
            this.unitMeasurementComboBox.FormattingEnabled = true;
            this.unitMeasurementComboBox.Location = new System.Drawing.Point(336, 232);
            this.unitMeasurementComboBox.Name = "unitMeasurementComboBox";
            this.unitMeasurementComboBox.Size = new System.Drawing.Size(110, 23);
            this.unitMeasurementComboBox.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(316, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "ICE";
            // 
            // iceRateComboBox
            // 
            this.iceRateComboBox.FormattingEnabled = true;
            this.iceRateComboBox.Location = new System.Drawing.Point(336, 276);
            this.iceRateComboBox.Name = "iceRateComboBox";
            this.iceRateComboBox.Size = new System.Drawing.Size(110, 23);
            this.iceRateComboBox.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 15);
            this.label17.TabIndex = 28;
            this.label17.Text = "IVA";
            // 
            // ivaRateComboBox
            // 
            this.ivaRateComboBox.FormattingEnabled = true;
            this.ivaRateComboBox.Location = new System.Drawing.Point(188, 276);
            this.ivaRateComboBox.Name = "ivaRateComboBox";
            this.ivaRateComboBox.Size = new System.Drawing.Size(110, 23);
            this.ivaRateComboBox.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 26;
            this.label18.Text = "Costo";
            // 
            // typeProductComboBox
            // 
            this.typeProductComboBox.FormattingEnabled = true;
            this.typeProductComboBox.Location = new System.Drawing.Point(40, 189);
            this.typeProductComboBox.Name = "typeProductComboBox";
            this.typeProductComboBox.Size = new System.Drawing.Size(120, 23);
            this.typeProductComboBox.TabIndex = 25;
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.BackgroundImage = global::CompudavSystem.Properties.Resources.add_22px;
            this.categoryAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryAddButton.FlatAppearance.BorderSize = 0;
            this.categoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryAddButton.Location = new System.Drawing.Point(153, 232);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(23, 23);
            this.categoryAddButton.TabIndex = 31;
            this.categoryAddButton.UseVisualStyleBackColor = true;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 498);
            this.Controls.Add(this.categoryAddButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.iceRateComboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ivaRateComboBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.typeProductComboBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.unitMeasurementComboBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.minimumStockLevelTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auxCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoCategoriaFabricante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        public System.Windows.Forms.TextBox mainCodeTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox auxCodeTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox minimumStockLevelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox price3TextBox;
        public System.Windows.Forms.TextBox percentagePrice3TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox price2TextBox;
        public System.Windows.Forms.TextBox percentagePrice2TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox price1TextBox;
        public System.Windows.Forms.TextBox percentagePrice1TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox unitMeasurementComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox iceRateComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ivaRateComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox typeProductComboBox;
        private System.Windows.Forms.Button categoryAddButton;
    }
}