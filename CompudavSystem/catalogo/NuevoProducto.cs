using System;
using System.Data;
using System.Windows.Forms;
using CompudavSystem.bdd;
using CompudavSystem.utilitario;

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
            ValidarCampoRequerido(nameTextBox, "Por favor ingrese el Nombre");
            ValidarCampoRequerido(mainCodeTextBox, "Por favor ingrese el Código UPC");
            ValidarCampoRequerido(stockTextBox, "Por favor ingrese la cantidad de Existencia actual del item");
            ValidarCampoRequerido(costTextBox, "Por favor ingrese el Costo del item actual");
            ValidarCampoRequerido(percentagePrice1TextBox, "Por favor ingrese el Porcentaje de Venta del item actual");
            ValidarCampoRequerido(price1TextBox, "Por favor ingrese el Precio del item actual");

            if (ErrorStatus)
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            string mainCode = mainCodeTextBox.Text.Replace("'", "\\'").Trim();
            mainCode = (mainCode == "") ? "null" : $"'{mainCode}'";
            string auxCode = auxCodeTextBox.Text.Replace("'", "\\'").Trim();
            auxCode = (auxCode == "") ? "null" : $"'{auxCode}'";
            string name = nameTextBox.Text.Replace("'", "\\'").Trim();
            name = (name == "") ? "null" : $"'{name}'";
            string descripcion = descripcionTextBox.Text.Replace("'", "\\'").Trim();
            descripcion = (descripcion == "") ? "null" : $"'{descripcion}'";

            string stock = (stockTextBox.Text.Trim() == "") ? "0" : stockTextBox.Text.Trim();
            string minimumStockLevel = (minimumStockLevelTextBox.Text.Trim() == "") ? "0" : minimumStockLevelTextBox.Text.Trim();
            string stockIndicator = (int.Parse(stock) - int.Parse(minimumStockLevel)).ToString();

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

            if (aceptarButton.Text == "Actualizar")
            {
                if (ConsultasSql.Actualizar(TableBdd,
                    $"main_code = {mainCode}, aux_code = {auxCode}, name = {name}, detail = {descripcion}, " +
                    $"stock = {stock}, minimum_stock_level = {minimumStockLevel}, stock_indicator = {stockIndicator}, cost = {cost}, " +
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
                    "main_code, aux_code, name, detail, stock, minimum_stock_level, stock_indicator, " +
                    "cost, percentage_price, price, percentage_price2, price2, percentage_price3, price3, " +
                    "categoryId, manufacturerId, iceRateId, ivaRateId, typeProductId, unitMeasurementId" ,
                    $"{mainCode}, {auxCode}, {name}, {descripcion}, {stock}, {minimumStockLevel}, {stockIndicator}," +
                    $"{cost}, {percentagePrice1}, {price1}, {percentagePrice2}, {price2}, {percentagePrice3}, {price3}, " +
                    $"{category}, {manufacturer}, {iceRate}, {ivaRate}, {typeProduct}, {unitMeasurement}"
                    ))
                {
                    CerrarYRefrescarFormulario();
                }
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

        private bool ValidarCampoRequerido(TextBox textBox, string mensaje)
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

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(nameTextBox, "Por favor ingrese el Nombre");
        }

        private void MainCodeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(mainCodeTextBox, "Por favor ingrese el Código UPC");
        }

        private void StockTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(stockTextBox, "Por favor ingrese la cantidad de Existencia actual del item");
        }

        private void CostTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(costTextBox, "Por favor ingrese el Costo del item actual");
        }

        private void PercentagePrice1TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(percentagePrice1TextBox, "Por favor ingrese el Porcentaje de Venta del item actual");
        }

        private void Price1TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidarCampoRequerido(price1TextBox, "Por favor ingrese el Precio del item actual");
        }

        private void StockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros(e.KeyChar);
        }

        private void MinimumStockLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros(e.KeyChar);
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void PercentagePrice1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void PercentagePrice2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void PercentagePrice3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void Price1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void Price2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
        }

        private void Price3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.DecimalesPunto(e.KeyChar);
            e.Handled = Validaciones.UnSoloPunto(sender, e);
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

        private void CalculoPrecio(TextBox cost, TextBox percentage, TextBox price)
        {
            decimal priceDecimal;
            _ = decimal.TryParse(cost.Text, out decimal costDecimal);
            _ = decimal.TryParse(percentage.Text, out decimal percentageDecimal);
            priceDecimal = costDecimal + (costDecimal * (percentageDecimal / 100));
            price.Text = decimal.Round(priceDecimal, 4).ToString();
        }

        private void CalculoPorcentaje(TextBox cost, TextBox percentage, TextBox price)
        {
            decimal percentageDecimal;
            _ = decimal.TryParse(cost.Text, out decimal costDecimal);
            _ = decimal.TryParse(price.Text, out decimal priceDecimal);
            if (costDecimal == 0)
            {
                ErrorProvider.SetError(cost, "Costo es igual a 0");
                ErrorStatus = false;
                percentageDecimal = 0;
            }
            else
            {
                ErrorProvider.SetError(cost, "");
                percentageDecimal = ((priceDecimal - costDecimal) * 100) / costDecimal;
            }
            percentage.Text = decimal.Round(percentageDecimal, 4).ToString();
        }

        private void PercentagePrice1TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPrecio(costTextBox, percentagePrice1TextBox, price1TextBox);
        }

        private void PercentagePrice2TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPrecio(costTextBox, percentagePrice2TextBox, price2TextBox);
        }

        private void PercentagePrice3TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPrecio(costTextBox, percentagePrice3TextBox, price3TextBox);
        }

        private void Price1TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPorcentaje(costTextBox, percentagePrice1TextBox, price1TextBox);
        }

        private void Price2TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPorcentaje(costTextBox, percentagePrice2TextBox, price2TextBox);
        }

        private void Price3TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPorcentaje(costTextBox, percentagePrice3TextBox, price3TextBox);
        }

        private void CostTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoPrecio(costTextBox, percentagePrice1TextBox, price1TextBox);
            if (percentagePrice2TextBox.Text.Trim() != "") { CalculoPrecio(costTextBox, percentagePrice2TextBox, price2TextBox); }
            if (percentagePrice3TextBox.Text.Trim() != "") { CalculoPrecio(costTextBox, percentagePrice3TextBox, price3TextBox); }
        }

    }
}
