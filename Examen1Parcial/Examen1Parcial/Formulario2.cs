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
        decimal TotalPagar; decimal desc; decimal subtotal; String Producto1; String Producto2;
        decimal PrecioP1; decimal PrecioP2;
        private void PrecioP2label_Click(object sender, EventArgs e)
        {

        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            

            //Ingresar nombre de los productos
            String Producto1 = Convert.ToString(Producto1textBox);
            String Producto2 = Convert.ToString(Producto2textBox);

            //Ingresar precio de los productos
            decimal PrecioP1 = Convert.ToDecimal(PrecioP1textBox);//Verificar
            decimal PrecioP2 = Convert.ToDecimal(PrecioP2textBox);

            //Ingresar la cantidad de cada producto
            int CantidadP1 = Convert.ToInt32(Cantidad1textBox);
            int CantidadP2 = Convert.ToInt32(Cantidad1textBox);

            // Decimal TotalPagar = await CalculoAsync(PrecioP1,PrecioP2,CantidadP1,CantidadP2);

            decimal Resultado = await CalculoAsync(PrecioP1, PrecioP2, CantidadP1, CantidadP2,subtotal,desc);

        }
        
        private async Task <decimal> CalculoAsync(decimal P1, decimal P2, int C1, int C2, decimal SubTotal,decimal ISV)
        {

            decimal TotalPagar = await Task.Run(()=>
            
            {
                SubTotal = (P1 * C1) + (P2 * C2);
                ISV = SubTotal * (15/100);
                return SubTotal - ISV;
            });

            return TotalPagar;
        } 

        private void FacturalistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacturalistBox.Items.Add("Producto :....................."+Producto1);
            FacturalistBox.Items.Add("Producto :....................."+Producto2);
            FacturalistBox.Items.Add("Precio unitario :.............."+PrecioP1);
            FacturalistBox.Items.Add("Precio unitario :.............."+PrecioP1);
            FacturalistBox.Items.Add("Total Productos :.............."+Producto1+ Producto2);
            FacturalistBox.Items.Add("Sub Total :...................."+subtotal);
            FacturalistBox.Items.Add("ISV :.........................."+desc);
            FacturalistBox.Items.Add("Total a pagar:................."+ TotalPagar);

        }
    }
}
