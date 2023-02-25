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

        decimal TotalPagar; String Producto1; String Producto2; decimal desc;
        decimal PrecioP1; decimal PrecioP2; decimal ISV; decimal SubTotal; decimal subtotal;
        private void PrecioP2label_Click(object sender, EventArgs e)
        {

        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {

            //Ingresar nombre de los productos
            String Producto1 = Convert.ToString(Producto1textBox.Text);
            String Producto2 = Convert.ToString(Producto2textBox.Text);

            //Ingresar precio de los productos
            decimal PrecioP1 = Convert.ToDecimal(PrecioP1textBox.Text);
            decimal PrecioP2 = Convert.ToDecimal(PrecioP2textBox.Text);

            //Ingresar la cantidad de cada producto
            int CantidadP1 = Convert.ToInt32(Cantidad1textBox.Text);
            int CantidadP2 = Convert.ToInt32(Cantidad1textBox.Text);

            // Decimal TotalPagar = await CalculoAsync(PrecioP1,PrecioP2,CantidadP1,CantidadP2);

            decimal Resultado = await CalculoAsync(PrecioP1, PrecioP2, CantidadP1, CantidadP2, SubTotal, ISV);

            FacturalistBox.Items.Add(".................... FACTURA ...........");
            FacturalistBox.Items.Add(".................................");
            FacturalistBox.Items.Add("Producto1 :....................."+Producto1);
            FacturalistBox.Items.Add("Producto2 :....................."+Producto2);
            FacturalistBox.Items.Add("Precio unitario :..............."+PrecioP1);
            FacturalistBox.Items.Add("Precio unitario :..............."+PrecioP2);
            FacturalistBox.Items.Add("Sub Total :....................."+ (Resultado = await CalculoAsync(PrecioP1, PrecioP2, CantidadP1, CantidadP2, SubTotal, ISV)));
            FacturalistBox.Items.Add("Descuento :....................."+ (Resultado = await CalculoAsync(PrecioP1, PrecioP2, CantidadP1, CantidadP2, SubTotal, ISV)));
            FacturalistBox.Items.Add("Total a pagar:.................."+(Resultado = await CalculoAsync(PrecioP1, PrecioP2, CantidadP1, CantidadP2, SubTotal, ISV)));     
        }
        
        private async Task <decimal> CalculoAsync(decimal P1, decimal P2, int C1, int C2,decimal desc,decimal SubTotal)
        {

            decimal TotalPagar = await Task.Run(()=>
            
            {
                SubTotal = (P1 * C1) + (P2 * C2);
                ISV = SubTotal * (15/100);
                return TotalPagar = SubTotal - desc;
            });

            return TotalPagar;
        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
