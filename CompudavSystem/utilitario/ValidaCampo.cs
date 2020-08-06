using System.Windows.Forms;

namespace CompudavSystem.utilitario
{
    public class ValidaCampo
    {
        public bool ErrorStatus { get; set; }
        public ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();
        public void Requerido(TextBox textBox, string mensaje)
        {
            ErrorStatus = true;
            if (textBox.Text == "")
            {
                ErrorProvider.SetError(textBox, mensaje);
                ErrorStatus = false;
            }
            else
            {
                ErrorProvider.SetError(textBox, "");
            }
        }

        public void Requerido(DataGridView dataGridView, Panel panel, string mensaje)
        {
            ErrorStatus = true;
            if (dataGridView.Rows.Count > 1)
            {
                ErrorProvider.SetError(panel, "");
            }
            else
            {
                ErrorProvider.SetError(panel, mensaje);
                ErrorProvider.SetIconPadding(panel,-30);
                ErrorStatus = false;
            }
        }

        public void Identificacion(TextBox textBox)
        {
            ErrorStatus = true;
            if (textBox.Text.Trim().Length > 0)
            {
                if (textBox.Text.Trim() == "9999999999999")
                {
                    ErrorStatus = true;
                }
                else
                {
                    ErrorStatus = ValidaIDNumber.VerificaIdentificacion(textBox.Text);
                }
            }
            if (ErrorStatus)
            {
                ErrorProvider.SetError(textBox, "");
            }
            else
            {
                ErrorProvider.SetError(textBox, "Verifica número de ID");
            }
        }

    }
   
}
