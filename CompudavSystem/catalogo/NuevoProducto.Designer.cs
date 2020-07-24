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
            this.mainCodeLabel = new System.Windows.Forms.Label();
            this.auxCodeTextBox = new System.Windows.Forms.TextBox();
            this.auxCodeLabel = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.typeProductLabel = new System.Windows.Forms.Label();
            this.minimumStockLevelTextBox = new System.Windows.Forms.TextBox();
            this.minimumStockLevelLabel = new System.Windows.Forms.Label();
            this.listaPreciosGroupBox = new System.Windows.Forms.GroupBox();
            this.price3Label = new System.Windows.Forms.Label();
            this.price3TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice3TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice3Label = new System.Windows.Forms.Label();
            this.price2Label = new System.Windows.Forms.Label();
            this.price2TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice2TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice2Label = new System.Windows.Forms.Label();
            this.price1Label = new System.Windows.Forms.Label();
            this.price1TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice1TextBox = new System.Windows.Forms.TextBox();
            this.percentagePrice1Label = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.unitMeasurementLabel = new System.Windows.Forms.Label();
            this.unitMeasurementComboBox = new System.Windows.Forms.ComboBox();
            this.iceRateLabel = new System.Windows.Forms.Label();
            this.iceRateComboBox = new System.Windows.Forms.ComboBox();
            this.ivaRateLabel = new System.Windows.Forms.Label();
            this.ivaRateComboBox = new System.Windows.Forms.ComboBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.typeProductComboBox = new System.Windows.Forms.ComboBox();
            this.listaPreciosGroupBox.SuspendLayout();
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
            this.nameTextBox.MaxLength = 255;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(406, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTextBox_KeyDown);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.Color.Green;
            this.aceptarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aceptarButton.Location = new System.Drawing.Point(246, 485);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(200, 29);
            this.aceptarButton.TabIndex = 15;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.ForeColor = System.Drawing.Color.Red;
            this.cancelarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelarButton.Location = new System.Drawing.Point(40, 485);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(200, 29);
            this.cancelarButton.TabIndex = 14;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // mainCodeTextBox
            // 
            this.mainCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mainCodeTextBox.Location = new System.Drawing.Point(40, 81);
            this.mainCodeTextBox.MaxLength = 45;
            this.mainCodeTextBox.Name = "mainCodeTextBox";
            this.mainCodeTextBox.Size = new System.Drawing.Size(180, 22);
            this.mainCodeTextBox.TabIndex = 1;
            this.mainCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainCodeTextBox_KeyDown);
            this.mainCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MainCodeTextBox_Validating);
            // 
            // mainCodeLabel
            // 
            this.mainCodeLabel.AutoSize = true;
            this.mainCodeLabel.Location = new System.Drawing.Point(20, 63);
            this.mainCodeLabel.Name = "mainCodeLabel";
            this.mainCodeLabel.Size = new System.Drawing.Size(69, 15);
            this.mainCodeLabel.TabIndex = 6;
            this.mainCodeLabel.Text = "Código UPC";
            // 
            // auxCodeTextBox
            // 
            this.auxCodeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.auxCodeTextBox.Location = new System.Drawing.Point(266, 81);
            this.auxCodeTextBox.MaxLength = 45;
            this.auxCodeTextBox.Name = "auxCodeTextBox";
            this.auxCodeTextBox.Size = new System.Drawing.Size(180, 22);
            this.auxCodeTextBox.TabIndex = 2;
            this.auxCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AuxCodeTextBox_KeyDown);
            // 
            // auxCodeLabel
            // 
            this.auxCodeLabel.AutoSize = true;
            this.auxCodeLabel.Location = new System.Drawing.Point(246, 63);
            this.auxCodeLabel.Name = "auxCodeLabel";
            this.auxCodeLabel.Size = new System.Drawing.Size(86, 15);
            this.auxCodeLabel.TabIndex = 8;
            this.auxCodeLabel.Text = "Código Auxiliar";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.Location = new System.Drawing.Point(40, 124);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(406, 44);
            this.descripcionTextBox.TabIndex = 3;
            this.descripcionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescripcionTextBox_KeyDown_1);
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(20, 106);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(67, 15);
            this.descripcionLabel.TabIndex = 10;
            this.descripcionLabel.Text = "Descripción";
            // 
            // stockTextBox
            // 
            this.stockTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stockTextBox.Location = new System.Drawing.Point(198, 189);
            this.stockTextBox.MaxLength = 11;
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(120, 22);
            this.stockTextBox.TabIndex = 5;
            this.stockTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockTextBox_KeyDown);
            this.stockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockTextBox_KeyPress);
            this.stockTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StockTextBox_Validating);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(178, 171);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(35, 15);
            this.stockLabel.TabIndex = 14;
            this.stockLabel.Text = "Stock";
            // 
            // costTextBox
            // 
            this.costTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.costTextBox.Location = new System.Drawing.Point(40, 276);
            this.costTextBox.MaxLength = 13;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(110, 22);
            this.costTextBox.TabIndex = 9;
            this.costTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostTextBox_KeyDown);
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            this.costTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CostTextBox_KeyUp);
            this.costTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CostTextBox_Validating);
            // 
            // typeProductLabel
            // 
            this.typeProductLabel.AutoSize = true;
            this.typeProductLabel.Location = new System.Drawing.Point(20, 171);
            this.typeProductLabel.Name = "typeProductLabel";
            this.typeProductLabel.Size = new System.Drawing.Size(97, 15);
            this.typeProductLabel.TabIndex = 12;
            this.typeProductLabel.Text = "Tipo de producto";
            // 
            // minimumStockLevelTextBox
            // 
            this.minimumStockLevelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.minimumStockLevelTextBox.Location = new System.Drawing.Point(356, 189);
            this.minimumStockLevelTextBox.MaxLength = 11;
            this.minimumStockLevelTextBox.Name = "minimumStockLevelTextBox";
            this.minimumStockLevelTextBox.Size = new System.Drawing.Size(90, 22);
            this.minimumStockLevelTextBox.TabIndex = 6;
            this.minimumStockLevelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinimumStockLevelTextBox_KeyDown);
            this.minimumStockLevelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinimumStockLevelTextBox_KeyPress);
            // 
            // minimumStockLevelLabel
            // 
            this.minimumStockLevelLabel.AutoSize = true;
            this.minimumStockLevelLabel.Location = new System.Drawing.Point(336, 171);
            this.minimumStockLevelLabel.Name = "minimumStockLevelLabel";
            this.minimumStockLevelLabel.Size = new System.Drawing.Size(78, 15);
            this.minimumStockLevelLabel.TabIndex = 16;
            this.minimumStockLevelLabel.Text = "Stock mínimo";
            // 
            // listaPreciosGroupBox
            // 
            this.listaPreciosGroupBox.Controls.Add(this.price3Label);
            this.listaPreciosGroupBox.Controls.Add(this.price3TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice3TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice3Label);
            this.listaPreciosGroupBox.Controls.Add(this.price2Label);
            this.listaPreciosGroupBox.Controls.Add(this.price2TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice2TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice2Label);
            this.listaPreciosGroupBox.Controls.Add(this.price1Label);
            this.listaPreciosGroupBox.Controls.Add(this.price1TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice1TextBox);
            this.listaPreciosGroupBox.Controls.Add(this.percentagePrice1Label);
            this.listaPreciosGroupBox.Location = new System.Drawing.Point(40, 305);
            this.listaPreciosGroupBox.Name = "listaPreciosGroupBox";
            this.listaPreciosGroupBox.Size = new System.Drawing.Size(406, 110);
            this.listaPreciosGroupBox.TabIndex = 12;
            this.listaPreciosGroupBox.TabStop = false;
            this.listaPreciosGroupBox.Text = "Lista de precios";
            // 
            // price3Label
            // 
            this.price3Label.AutoSize = true;
            this.price3Label.Location = new System.Drawing.Point(163, 80);
            this.price3Label.Name = "price3Label";
            this.price3Label.Size = new System.Drawing.Size(39, 15);
            this.price3Label.TabIndex = 26;
            this.price3Label.Text = "Precio";
            // 
            // price3TextBox
            // 
            this.price3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price3TextBox.Location = new System.Drawing.Point(208, 77);
            this.price3TextBox.MaxLength = 13;
            this.price3TextBox.Name = "price3TextBox";
            this.price3TextBox.Size = new System.Drawing.Size(120, 22);
            this.price3TextBox.TabIndex = 5;
            this.price3TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price3TextBox_KeyDown);
            this.price3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price3TextBox_KeyPress);
            this.price3TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price3TextBox_KeyUp);
            // 
            // percentagePrice3TextBox
            // 
            this.percentagePrice3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice3TextBox.Location = new System.Drawing.Point(95, 77);
            this.percentagePrice3TextBox.MaxLength = 8;
            this.percentagePrice3TextBox.Name = "percentagePrice3TextBox";
            this.percentagePrice3TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice3TextBox.TabIndex = 4;
            this.percentagePrice3TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice3TextBox_KeyDown);
            this.percentagePrice3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentagePrice3TextBox_KeyPress);
            this.percentagePrice3TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice3TextBox_KeyUp);
            // 
            // percentagePrice3Label
            // 
            this.percentagePrice3Label.AutoSize = true;
            this.percentagePrice3Label.Location = new System.Drawing.Point(73, 80);
            this.percentagePrice3Label.Name = "percentagePrice3Label";
            this.percentagePrice3Label.Size = new System.Drawing.Size(16, 15);
            this.percentagePrice3Label.TabIndex = 23;
            this.percentagePrice3Label.Text = "%";
            // 
            // price2Label
            // 
            this.price2Label.AutoSize = true;
            this.price2Label.Location = new System.Drawing.Point(163, 52);
            this.price2Label.Name = "price2Label";
            this.price2Label.Size = new System.Drawing.Size(39, 15);
            this.price2Label.TabIndex = 22;
            this.price2Label.Text = "Precio";
            // 
            // price2TextBox
            // 
            this.price2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price2TextBox.Location = new System.Drawing.Point(208, 49);
            this.price2TextBox.MaxLength = 13;
            this.price2TextBox.Name = "price2TextBox";
            this.price2TextBox.Size = new System.Drawing.Size(120, 22);
            this.price2TextBox.TabIndex = 3;
            this.price2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price2TextBox_KeyDown);
            this.price2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price2TextBox_KeyPress);
            this.price2TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price2TextBox_KeyUp);
            // 
            // percentagePrice2TextBox
            // 
            this.percentagePrice2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice2TextBox.Location = new System.Drawing.Point(95, 49);
            this.percentagePrice2TextBox.MaxLength = 8;
            this.percentagePrice2TextBox.Name = "percentagePrice2TextBox";
            this.percentagePrice2TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice2TextBox.TabIndex = 2;
            this.percentagePrice2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice2TextBox_KeyDown);
            this.percentagePrice2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentagePrice2TextBox_KeyPress);
            this.percentagePrice2TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice2TextBox_KeyUp);
            // 
            // percentagePrice2Label
            // 
            this.percentagePrice2Label.AutoSize = true;
            this.percentagePrice2Label.Location = new System.Drawing.Point(73, 52);
            this.percentagePrice2Label.Name = "percentagePrice2Label";
            this.percentagePrice2Label.Size = new System.Drawing.Size(16, 15);
            this.percentagePrice2Label.TabIndex = 19;
            this.percentagePrice2Label.Text = "%";
            // 
            // price1Label
            // 
            this.price1Label.AutoSize = true;
            this.price1Label.Location = new System.Drawing.Point(163, 24);
            this.price1Label.Name = "price1Label";
            this.price1Label.Size = new System.Drawing.Size(39, 15);
            this.price1Label.TabIndex = 18;
            this.price1Label.Text = "Precio";
            // 
            // price1TextBox
            // 
            this.price1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.price1TextBox.Location = new System.Drawing.Point(208, 21);
            this.price1TextBox.MaxLength = 13;
            this.price1TextBox.Name = "price1TextBox";
            this.price1TextBox.Size = new System.Drawing.Size(120, 22);
            this.price1TextBox.TabIndex = 1;
            this.price1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Price1TextBox_KeyDown);
            this.price1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price1TextBox_KeyPress);
            this.price1TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Price1TextBox_KeyUp);
            this.price1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Price1TextBox_Validating);
            // 
            // percentagePrice1TextBox
            // 
            this.percentagePrice1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.percentagePrice1TextBox.Location = new System.Drawing.Point(95, 21);
            this.percentagePrice1TextBox.MaxLength = 8;
            this.percentagePrice1TextBox.Name = "percentagePrice1TextBox";
            this.percentagePrice1TextBox.Size = new System.Drawing.Size(50, 22);
            this.percentagePrice1TextBox.TabIndex = 0;
            this.percentagePrice1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice1TextBox_KeyDown);
            this.percentagePrice1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PercentagePrice1TextBox_KeyPress);
            this.percentagePrice1TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PercentagePrice1TextBox_KeyUp);
            this.percentagePrice1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PercentagePrice1TextBox_Validating);
            // 
            // percentagePrice1Label
            // 
            this.percentagePrice1Label.AutoSize = true;
            this.percentagePrice1Label.Location = new System.Drawing.Point(73, 24);
            this.percentagePrice1Label.Name = "percentagePrice1Label";
            this.percentagePrice1Label.Size = new System.Drawing.Size(16, 15);
            this.percentagePrice1Label.TabIndex = 14;
            this.percentagePrice1Label.Text = "%";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(40, 232);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(180, 23);
            this.categoryComboBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(20, 214);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(56, 15);
            this.categoryLabel.TabIndex = 20;
            this.categoryLabel.Text = "Categoría";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(246, 214);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(61, 15);
            this.manufacturerLabel.TabIndex = 22;
            this.manufacturerLabel.Text = "Fabricante";
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(266, 232);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(180, 23);
            this.manufacturerComboBox.TabIndex = 8;
            // 
            // unitMeasurementLabel
            // 
            this.unitMeasurementLabel.AutoSize = true;
            this.unitMeasurementLabel.Location = new System.Drawing.Point(316, 258);
            this.unitMeasurementLabel.Name = "unitMeasurementLabel";
            this.unitMeasurementLabel.Size = new System.Drawing.Size(103, 15);
            this.unitMeasurementLabel.TabIndex = 24;
            this.unitMeasurementLabel.Text = "Unidad de medida";
            // 
            // unitMeasurementComboBox
            // 
            this.unitMeasurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitMeasurementComboBox.FormattingEnabled = true;
            this.unitMeasurementComboBox.Location = new System.Drawing.Point(336, 276);
            this.unitMeasurementComboBox.Name = "unitMeasurementComboBox";
            this.unitMeasurementComboBox.Size = new System.Drawing.Size(110, 23);
            this.unitMeasurementComboBox.TabIndex = 11;
            // 
            // iceRateLabel
            // 
            this.iceRateLabel.AutoSize = true;
            this.iceRateLabel.Location = new System.Drawing.Point(20, 418);
            this.iceRateLabel.Name = "iceRateLabel";
            this.iceRateLabel.Size = new System.Drawing.Size(23, 15);
            this.iceRateLabel.TabIndex = 30;
            this.iceRateLabel.Text = "ICE";
            // 
            // iceRateComboBox
            // 
            this.iceRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iceRateComboBox.FormattingEnabled = true;
            this.iceRateComboBox.Location = new System.Drawing.Point(40, 436);
            this.iceRateComboBox.Name = "iceRateComboBox";
            this.iceRateComboBox.Size = new System.Drawing.Size(406, 23);
            this.iceRateComboBox.TabIndex = 13;
            // 
            // ivaRateLabel
            // 
            this.ivaRateLabel.AutoSize = true;
            this.ivaRateLabel.Location = new System.Drawing.Point(168, 258);
            this.ivaRateLabel.Name = "ivaRateLabel";
            this.ivaRateLabel.Size = new System.Drawing.Size(24, 15);
            this.ivaRateLabel.TabIndex = 28;
            this.ivaRateLabel.Text = "IVA";
            // 
            // ivaRateComboBox
            // 
            this.ivaRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ivaRateComboBox.FormattingEnabled = true;
            this.ivaRateComboBox.Location = new System.Drawing.Point(188, 276);
            this.ivaRateComboBox.Name = "ivaRateComboBox";
            this.ivaRateComboBox.Size = new System.Drawing.Size(110, 23);
            this.ivaRateComboBox.TabIndex = 10;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(20, 258);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(37, 15);
            this.costLabel.TabIndex = 26;
            this.costLabel.Text = "Costo";
            // 
            // typeProductComboBox
            // 
            this.typeProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeProductComboBox.FormattingEnabled = true;
            this.typeProductComboBox.Location = new System.Drawing.Point(40, 189);
            this.typeProductComboBox.Name = "typeProductComboBox";
            this.typeProductComboBox.Size = new System.Drawing.Size(120, 23);
            this.typeProductComboBox.TabIndex = 4;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 530);
            this.Controls.Add(this.iceRateLabel);
            this.Controls.Add(this.iceRateComboBox);
            this.Controls.Add(this.ivaRateLabel);
            this.Controls.Add(this.ivaRateComboBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.typeProductComboBox);
            this.Controls.Add(this.unitMeasurementLabel);
            this.Controls.Add(this.unitMeasurementComboBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.listaPreciosGroupBox);
            this.Controls.Add(this.minimumStockLevelTextBox);
            this.Controls.Add(this.minimumStockLevelLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.typeProductLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.auxCodeTextBox);
            this.Controls.Add(this.auxCodeLabel);
            this.Controls.Add(this.mainCodeTextBox);
            this.Controls.Add(this.mainCodeLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoCategoriaFabricante";
            this.listaPreciosGroupBox.ResumeLayout(false);
            this.listaPreciosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        public System.Windows.Forms.TextBox mainCodeTextBox;
        private System.Windows.Forms.Label mainCodeLabel;
        public System.Windows.Forms.TextBox auxCodeTextBox;
        private System.Windows.Forms.Label auxCodeLabel;
        public System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label descripcionLabel;
        public System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label stockLabel;
        public System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label typeProductLabel;
        public System.Windows.Forms.TextBox minimumStockLevelTextBox;
        private System.Windows.Forms.Label minimumStockLevelLabel;
        private System.Windows.Forms.GroupBox listaPreciosGroupBox;
        private System.Windows.Forms.Label price3Label;
        public System.Windows.Forms.TextBox price3TextBox;
        public System.Windows.Forms.TextBox percentagePrice3TextBox;
        private System.Windows.Forms.Label percentagePrice3Label;
        private System.Windows.Forms.Label price2Label;
        public System.Windows.Forms.TextBox price2TextBox;
        public System.Windows.Forms.TextBox percentagePrice2TextBox;
        private System.Windows.Forms.Label percentagePrice2Label;
        private System.Windows.Forms.Label price1Label;
        public System.Windows.Forms.TextBox price1TextBox;
        public System.Windows.Forms.TextBox percentagePrice1TextBox;
        private System.Windows.Forms.Label percentagePrice1Label;
        public System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        public System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.Label unitMeasurementLabel;
        public System.Windows.Forms.ComboBox unitMeasurementComboBox;
        private System.Windows.Forms.Label iceRateLabel;
        public System.Windows.Forms.ComboBox iceRateComboBox;
        private System.Windows.Forms.Label ivaRateLabel;
        public System.Windows.Forms.ComboBox ivaRateComboBox;
        private System.Windows.Forms.Label costLabel;
        public System.Windows.Forms.ComboBox typeProductComboBox;
    }
}