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
        decimal SubTotal; decimal TotalPagar; double ISV = 0.15;
        private void PrecioP2label_Click(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            //Ingresar nombre de los productos
            String Producto1 = Convert.ToString(Producto1textBox);
            String Producto2 = Convert.ToString(Producto2textBox);

            //Ingresar precio de los productos
            decimal PrecioP1 = Convert.ToDecimal(PrecioP1textBox);
            decimal PrecioP2 = Convert.ToDecimal(PrecioP2textBox);

            //Ingresar la cantidad de cada producto
            int CantidadP1 = Convert.ToInt32(Cantidad1textBox);
            int CantidadP2 = Convert.ToInt32(Cantidad1textBox);

           // Decimal TotalPagar = await CalculoAsync(PrecioP1,PrecioP2,CantidadP1,CantidadP2);

            FacturalistBox.Items.Add("Cantidad de Productos:..........."+CantidadP1);
            FacturalistBox.Items.Add("Precio Unitario Producto 1:......."+PrecioP1);
            FacturalistBox.Items.Add("Precio Unitario Producto 2:......."+PrecioP2);
            FacturalistBox.Items.Add("Sub Total:........................"+SubTotal);
            FacturalistBox.Items.Add("ISV:.............................."+ISV);
            FacturalistBox.Items.Add("Total a pagar:...................."+TotalPagar);

        }
        
        private async Task <decimal> CalculoAsync(decimal P1, decimal P2, int C1, int C2)
        {

            decimal TotalPagar = await Task.Run(()=>
            
            {
                SubTotal = (P1 * C1) + (P2 * C2);
                TotalPagar = SubTotal + (SubTotal * 0.15);
            });

            return SubTotal;
        }

    }
}
