using CompudavSystem.bdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.configuracion
{
    public partial class Configuracion : Form
    {
        private DataTable parameterDataTable { get; set; } = new DataTable();
        private string TableBdd { get; set; } = "parameter";
        public Configuracion()
        {
            InitializeComponent();
            LoadFonts();
            LoadPrinters();
            CargarDatos();
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
                    CargarDatos();
                }
            }
        }
    }
}
