using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Parcial
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void PrecioP2label_Click(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            String Producto1 = Convert.ToString(Producto1textBox);
            String Producto2 = Convert.ToString(Producto2textBox);

            decimal PrecioP1 = Convert.ToDecimal(PrecioP1textBox);
            decimal PrecioP2 = Convert.ToDecimal(PrecioP2textBox);

            decimal CalcularButton = Convert.ToDecimal(Producto1 + Producto2);

            decimal CantidadProductos = Convert.ToDecimal(CalcularButton);
        }
    }
}
