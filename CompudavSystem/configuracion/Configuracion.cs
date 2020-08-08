using CompudavSystem.bdd;
using CompudavSystem.Properties;
using CompudavSystem.utilitario;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CompudavSystem.configuracion
{
    public partial class Configuracion : Form
    {
        private DataTable parameterDataTable { get; set; } = new DataTable();
        private DataTable dataFilter { get; set; } = new DataTable();
        private string TableBdd { get; set; } = "parameter";
        private string PresetString { get; set; }
        public Configuracion()
        {
            InitializeComponent();
            LoadFonts();
            LoadPrinters();
            CargarDatos();
            LoadPreset();
        }

        private void LoadPreset()
        {
            PresetString = Settings.Default.preset == 0 ? "Ninguno" : Settings.Default.preset.ToString();
            presetDeterminadoLabel.Text = $"Preset predeterminado: {PresetString}";
            if (PresetString != "Ninguno")
            {
                presetComboBox.Text = PresetString;
            }
        }

        private void LoadFonts()
        {
            foreach (var font in FontFamily.Families)
            {
                fontFamilyComboBox.Items.Add(font.Name);
            }
        }

        private void LoadPrinters()
        {
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                printerNameComboBox.Items.Add(printer);
            }
        }

        private void CargarDatos(int presetIndex = 0)
        {
            parameterDataTable = ConsultasSql.ConsultaGeneral(TableBdd, campoOrden: "preset");
            presetComboBox.DataSource = parameterDataTable;
            presetComboBox.DisplayMember = "preset";
            presetComboBox.ValueMember = "id";
            DataRow dataRow = parameterDataTable.Rows[presetIndex];
            printerNameComboBox.Text = dataRow["printerName"].ToString();
            fontFamilyComboBox.Text = dataRow["printerFontFamily"].ToString();
            fontSizeTextBox.Text = dataRow["printerFontSize"].ToString();
            headerXTextBox.Text = dataRow["printerHeaderPositionX"].ToString();
            headerYTextBox.Text = dataRow["printerHeaderPositionY"].ToString();
            mainXTextBox.Text = dataRow["printerMainPositionX"].ToString();
            mainYTextBox.Text = dataRow["printerMainPositionY"].ToString();
            footerXTextBox.Text = dataRow["printerFooterPositionX"].ToString();
            footerYTextBox.Text = dataRow["printerFooterPositionY"].ToString();
            aceptarButton.Text = "Actualizar";
        }

        private void AddPresetButton_Click(object sender, EventArgs e)
        {
            parameterDataTable = ConsultasSql.ConsultaGeneral(TableBdd, campoOrden: "preset");
            presetComboBox.DataSource = parameterDataTable;
            presetComboBox.DisplayMember = "preset";
            presetComboBox.ValueMember = "id";
            DataRow dataRow = parameterDataTable.NewRow();
            dataRow["id"] = "nulo";
            dataRow["preset"] = presetComboBox.Items.Count + 1;
            parameterDataTable.Rows.Add(dataRow);
            parameterDataTable.DefaultView.Sort = "preset desc";
            presetComboBox.DataSource = parameterDataTable;

            printerNameComboBox.SelectedIndex = 0;
            fontFamilyComboBox.SelectedIndex = 0;
            fontSizeTextBox.Text = "8";
            headerXTextBox.Text = "0";
            headerYTextBox.Text = "0";
            mainXTextBox.Text = "0";
            mainYTextBox.Text = "0";
            footerXTextBox.Text = "0";
            footerYTextBox.Text = "0";

            aceptarButton.Text = "Guardar";

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string preset = $"'{presetComboBox.Text}'";
            string printerName = $"'{printerNameComboBox.Text}'";
            string printerFontFamily = $"'{fontFamilyComboBox.Text}'";
            string printerFontSize = $"{fontSizeTextBox.Text}";
            string printerHeaderPositionX = $"{headerXTextBox.Text}";
            string printerHeaderPositionY = $"{headerYTextBox.Text}";
            string printerMainPositionX = $"{mainXTextBox.Text}";
            string printerMainPositionY = $"{mainYTextBox.Text}";
            string printerFooterPositionX = $"{footerXTextBox.Text}";
            string printerFooterPositionY = $"{footerYTextBox.Text}";

            if (aceptarButton.Text == "Guardar")
            {
                if (ConsultasSql.Insertar(TableBdd,
                    "preset, printerName, printerFontFamily, printerFontSize, printerHeaderPositionX, " +
                    "printerHeaderPositionY, printerMainPositionX, printerMainPositionY, " +
                    "printerFooterPositionX, printerFooterPositionY",
                    $"{preset}, {printerName}, {printerFontFamily}, {printerFontSize}, {printerHeaderPositionX}, " +
                    $"{printerHeaderPositionY}, {printerMainPositionX}, {printerMainPositionY}, " +
                    $"{printerFooterPositionX}, {printerFooterPositionY} "
                    ))
                {
                    CargarDatos();
                }
            }
            if (aceptarButton.Text == "Actualizar")
            {
                if (ConsultasSql.Actualizar(TableBdd,
                    $"preset = {preset}, printerName = {printerName}, printerFontFamily = {printerFontFamily}, printerFontSize = {printerFontSize}, " +
                    $"printerHeaderPositionX = {printerHeaderPositionX}, printerHeaderPositionY = {printerHeaderPositionY}, printerMainPositionX = {printerMainPositionX}, " +
                    $"printerMainPositionY = {printerMainPositionY}, printerFooterPositionX = {printerFooterPositionX}, printerFooterPositionY = {printerFooterPositionY}",
                    "id", $"'{presetComboBox.SelectedValue}'"))
                {
                    MessageBox.Show("Preset actualizado correctamente");
                }
            }
        }

        private void PredeterminadoButton_Click(object sender, EventArgs e)
        {
            Settings.Default.printerName = printerNameComboBox.Text;
            Settings.Default.printerFontFamily = fontFamilyComboBox.Text;
            Settings.Default.printerFontSize = int.Parse(fontSizeTextBox.Text);
            Settings.Default.printerHeaderPositionX = int.Parse(headerXTextBox.Text);
            Settings.Default.printerHeaderPositionY = int.Parse(headerYTextBox.Text);
            Settings.Default.printerMainPositionX = int.Parse(mainXTextBox.Text);
            Settings.Default.printerMainPositionY = int.Parse(mainYTextBox.Text);
            Settings.Default.printerFooterPositionX = int.Parse(footerXTextBox.Text);
            Settings.Default.printerFooterPositionY = int.Parse(footerYTextBox.Text);
            Settings.Default.preset = int.Parse(presetComboBox.Text);
            Settings.Default.Save();
            Settings.Default.Reload();
            LoadPreset();

        }

        private void PresetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataFilter = ConsultasSql.ConsultaIndividual(TableBdd, "*", "preset", "=", presetComboBox.Text);
            if (dataFilter.Rows.Count > 0)
            {
                DataRow dataRow = dataFilter.Rows[0];
                printerNameComboBox.Text = dataRow["printerName"].ToString();
                fontFamilyComboBox.Text = dataRow["printerFontFamily"].ToString();
                fontSizeTextBox.Text = dataRow["printerFontSize"].ToString();
                headerXTextBox.Text = dataRow["printerHeaderPositionX"].ToString();
                headerYTextBox.Text = dataRow["printerHeaderPositionY"].ToString();
                mainXTextBox.Text = dataRow["printerMainPositionX"].ToString();
                mainYTextBox.Text = dataRow["printerMainPositionY"].ToString();
                footerXTextBox.Text = dataRow["printerFooterPositionX"].ToString();
                footerYTextBox.Text = dataRow["printerFooterPositionY"].ToString();
            }
        }

        private void NumerosNegativos(TextBox textBox)
        {
            _ = int.TryParse(textBox.Text, out int result);
            textBox.Text = result.ToString();
        }

        private void HeaderXTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(headerXTextBox);
        }

        private void HeaderXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void HeaderYTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(headerYTextBox);
        }

        private void HeaderYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void MainXTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(mainXTextBox);
        }

        private void MainXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void MainYTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(mainYTextBox);
        }

        private void MainYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void FooterXTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(footerXTextBox);
        }

        private void FooterXTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void FooterYTextBox_TextChanged(object sender, EventArgs e)
        {
            NumerosNegativos(footerYTextBox);
        }

        private void FooterYTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.NumerosPositivosYNegativos(e.KeyChar);
            e.Handled = Validaciones.SignoNegativo(sender, e);
        }

        private void FontSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Validaciones.Numeros(e.KeyChar);
        }

        private void HeaderXTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { headerYTextBox.Focus(); }
        }

        private void HeaderYTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { mainXTextBox.Focus(); }
        }

        private void MainXTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { mainYTextBox.Focus(); }
        }

        private void MainYTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { footerXTextBox.Focus(); }
        }

        private void FooterXTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { footerYTextBox.Focus(); }
        }

        private void FooterYTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { fontSizeTextBox.Focus(); }
        }

    }
}
