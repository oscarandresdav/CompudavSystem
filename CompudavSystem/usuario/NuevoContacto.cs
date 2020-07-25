using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.usuario
{
    public partial class NuevoContacto : Form
    {
        public IContacto Icontacto { get; set; }
        public string TableBdd { get; set; }
        public string IdField { get; set; }
        public NuevoContacto()
        {
            InitializeComponent();
        }
    }
}
