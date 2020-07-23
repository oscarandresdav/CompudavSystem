using CompudavSystem.bdd;
using System;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;
using CompudavSystem.utilitario;
using System.Text;

namespace CompudavSystem.catalogo
{
    public partial class NuevoProducto : Form
    {
        public Categoria CategoriaForm { get; set; } = new Categoria();
        public Fabricante FabricanteForm { get; set; } = new Fabricante();
        public ICatalogo Icatalogo { get; set; } 
        public string TableBdd { get; set; }
        public string IdField { get; set; }
        public bool ErrorStatus { get; set; }
        public ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();

        public NuevoProducto()
        {
            InitializeComponent();
            DatosIniciales();
        }

        public void DatosIniciales()
        {
            CargaDeDatosCombobox(categoryComboBox, "category");
            CargaDeDatosCombobox(iceRateComboBox, "ice_rate");
            CargaDeDatosCombobox(ivaRateComboBox, "iva_rate", campoOrden: "sort");
            CargaDeDatosCombobox(manufacturerComboBox, "manufacturer");
            CargaDeDatosCombobox(typeProductComboBox, "type_product", campoOrden: "sort");
            CargaDeDatosCombobox(unitMeasurementComboBox, "unit_measurement", campoOrden: "sort");
            
            CampoInicialComboBox(categoryComboBox);
            CampoInicialComboBox(iceRateComboBox);
            CampoInicialComboBox(manufacturerComboBox);
            CampoInicialComboBox(unitMeasurementComboBox, "sort");
        }

        private void CampoInicialComboBox(ComboBox comboBox, string sortColum = "name")
        {
            DataTable dataTable = comboBox.DataSource as DataTable;
            DataRow dataRow = dataTable.NewRow();
            dataRow["id"] = "nulo";
            dataRow["name"] = "---------";
            if (sortColum == "sort") { dataRow["sort"] = -1; }
            dataTable.Rows.Add(dataRow);
            dataTable.DefaultView.Sort = $"{sortColum} asc";
            comboBox.DataSource = dataTable;
        }

        private void CargaDeDatosCombobox(ComboBox comboBox, string table, string displayMember = "name", string valueMember = "id", string campoOrden = "name")
        {
            comboBox.DataSource = ConsultasSql.ConsultaGeneral(table, campoOrden: campoOrden);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            ValidateRequire(nameTextBox, "Por favor ingrese el Nombre");
            ValidateRequire(mainCodeTextBox, "Por favor ingrese el Código UPC"); 
            ValidateRequire(stockTextBox, "Por favor ingrese la cantidad de Existencia actual del item");
            ValidateRequire(costTextBox, "Por favor ingrese el Costo del item actual");
            ValidateRequire(percentagePrice1TextBox, "Por favor ingrese el Porcentaje de Venta del item actual");
            ValidateRequire(price1TextBox, "Por favor ingrese el Precio del item actual");
            if (ErrorStatus) { Guardar(); }           
        }

        private void Guardar()
        {
            string mainCode = mainCodeTextBox.Text.Replace("'", "\\'").Trim();
            mainCode = (mainCode == "") ? "null" : $"'{mainCode}'";
            string auxCode = auxCodeTextBox.Text.Replace("'", "\\'").Trim(); 
            auxCode = (auxCode == "") ? "null" : $"'{auxCode}'";
            string name = nameTextBox.Text.Replace("'", "\\'").Trim();
            name = (name == "") ? "null": $"'{name}'";
            string descripcion = descripcionTextBox.Text.Replace("'", "\\'").Trim();
            descripcion = (descripcion == "") ? "null": $"'{descripcion}'";

            string stock = (stockTextBox.Text.Trim() == "") ? "null" : stockTextBox.Text.Trim();
            string minimumStockLevel = (minimumStockLevelTextBox.Text.Trim() == "") ? "null" : minimumStockLevelTextBox.Text.Trim();
            string cost = (costTextBox.Text.Trim() == "") ? "null" : costTextBox.Text.Trim();
            string percentagePrice1 = (percentagePrice1TextBox.Text.Trim() == "") ? "null" : percentagePrice1TextBox.Text.Trim();
            string price1 = (price1TextBox.Text.Trim() == "") ? "null" : price1TextBox.Text.Trim();
            string percentagePrice2 = (percentagePrice2TextBox.Text.Trim() == "") ? "null" : percentagePrice2TextBox.Text.Trim();
            string price2 = (price2TextBox.Text.Trim() == "") ? "null" : price2TextBox.Text.Trim();
            string percentagePrice3 = (percentagePrice3TextBox.Text.Trim() == "") ? "null" : percentagePrice3TextBox.Text.Trim();
            string price3 = (price3TextBox.Text.Trim() == "") ? "null" : price3TextBox.Text.Trim();

            string category = (categoryComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{categoryComboBox.SelectedValue}'"; 
            string manufacturer = (manufacturerComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{manufacturerComboBox.SelectedValue}'"; 
            string iceRate = (iceRateComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{iceRateComboBox.SelectedValue}'"; 
            string ivaRate = (ivaRateComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{ivaRateComboBox.SelectedValue}'"; 
            string typeProduct = (typeProductComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{typeProductComboBox.SelectedValue}'"; 
            string unitMeasurement = (unitMeasurementComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{unitMeasurementComboBox.SelectedValue}'"; 
            
            if (name.Length > 0)
            {
                if (aceptarButton.Text == "Actualizar")
                {
                    if (ConsultasSql.Actualizar(TableBdd, 
                        $"main_code = {mainCode}, aux_code = {auxCode}, name = {name}, detail = {descripcion}, " +
                        $"stock = {stock}, minimum_stock_level = {minimumStockLevel}, cost = {cost}, " +
                        $"percentage_price = {percentagePrice1}, price = {price1}, " +
                        $"percentage_price2 = {percentagePrice2}, price2 = {price2}, " +
                        $"percentage_price3 = {percentagePrice3}, price3 = {price3}, " +
                        $"categoryId = {category}, manufacturerId = {manufacturer}, iceRateId = {iceRate}, " +
                        $"ivaRateId = {ivaRate}, typeProductId = {typeProduct}, unitMeasurementId = {unitMeasurement}",
                        "id", $"'{IdField}'"))
                    {
                        CerrarYRefrescarFormulario();
                    }
                }

                if (aceptarButton.Text == "Guardar")
                {
                    if (ConsultasSql.Insertar(
                        TableBdd,
                        "main_code, aux_code, name, detail, stock, minimum_stock_level, " +
                        "cost, percentage_price, price, percentage_price2, price2, percentage_price3, price3, " +
                        "categoryId, manufacturerId, iceRateId, ivaRateId, typeProductId, unitMeasurementId", 
                        $"{mainCode}, {auxCode}, {name}, {descripcion}, {stock}, {minimumStockLevel}, " +
                        $"{cost}, {percentagePrice1}, {price1}, {percentagePrice2}, {price2}, {percentagePrice3}, {price3}, " +
                        $"{category}, {manufacturer}, {iceRate}, {ivaRate}, {typeProduct}, {unitMeasurement}"
                        ))
                    {
                        CerrarYRefrescarFormulario();
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo descripcion en blanco");
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            CerrarYRefrescarFormulario();
        }

        private void DescripcionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { CerrarYRefrescarFormulario(); }
            if (e.KeyCode == Keys.Enter) { mainCodeTextBox.Focus(); }
        }

        private void CerrarYRefrescarFormulario()
        {
            Hide();
            Icatalogo.FocoEnTextBoxDeBusqueda();
            Icatalogo.Busqueda();
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(nameTextBox, "Por favor ingrese el Nombre");
        }

        private bool ValidateRequire(TextBox textBox, string mensaje)
        {
            ErrorStatus = true;
            if (textBox.Text == "")
            {
                ErrorProvider.SetError(textBox, mensaje);
                ErrorStatus = false;
            }
            else
                ErrorProvider.SetError(textBox, "");
            return ErrorStatus;
        }

        private void MainCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(mainCodeTextBox, "Por favor ingrese el Código UPC");
        }

        private void StockTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(stockTextBox, "Por favor ingrese la cantidad de Existencia actual del item");
        }

        private void CostTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(costTextBox, "Por favor ingrese el Costo del item actual");
        }

        private void PercentagePrice1TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(percentagePrice1TextBox, "Por favor ingrese el Porcentaje de Venta del item actual");
        }

        private void Price1TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateRequire(price1TextBox, "Por favor ingrese el Precio del item actual");
        }

        private void StockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros((int)e.KeyChar);
        }

        private void MinimumStockLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros((int)e.KeyChar);
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);
        }

        private void PercentagePrice1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);

            
        }

        private void PercentagePrice2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);
        }

        private void PercentagePrice3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);
        }

        private void Price1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);

            
        }

        private void Price2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);
        }

        private void Price3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto((int)e.KeyChar);
        }

        private void MainCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { auxCodeTextBox.Focus(); }
        }

        private void AuxCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { descripcionTextBox.Focus(); }
        }

        private void DescripcionTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { typeProductComboBox.Focus(); }
        }

        private void StockTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { minimumStockLevelTextBox.Focus(); }
        }

        private void MinimumStockLevelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { categoryComboBox.Focus(); }
        }

        private void CostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { percentagePrice1TextBox.Focus(); }
        }

        private void PercentagePrice1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { price1TextBox.Focus(); }

            
        }

        private void Price1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { percentagePrice2TextBox.Focus(); }

            
        }

        private void PercentagePrice2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { price2TextBox.Focus(); }
        }

        private void Price2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { percentagePrice3TextBox.Focus(); }
        }

        private void PercentagePrice3TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { price3TextBox.Focus(); }
        }

        private void Price3TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { iceRateComboBox.Focus(); }
        }

        private void PercentagePrice1TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Price1TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PercentagePrice1TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            decimal cost = costTextBox.Text == "" ? 0 : Convert.ToDecimal(costTextBox.Text);
            decimal percentage1 = percentagePrice1TextBox.Text == "" ? 0 : Convert.ToDecimal(percentagePrice1TextBox.Text);
            decimal price1;

            price1 = cost + (cost * (percentage1 / 100));

            price1TextBox.Text = price1.ToString();
        }

        private void Price1TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            decimal cost = costTextBox.Text == "" || costTextBox.Text == "." ? 0 : Convert.ToDecimal(costTextBox.Text);
            decimal price1 = price1TextBox.Text == "" || price1TextBox.Text == "." ? 0 : Convert.ToDecimal(price1TextBox.Text);
            decimal percentage1;

            // price1 = cost + (cost * (percentage1 / 100));

            percentage1 = ((price1 - cost) * 100) / cost;

            percentagePrice1TextBox.Text = percentage1.ToString();
        }
    }
}
