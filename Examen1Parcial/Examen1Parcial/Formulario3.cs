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
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random NumeroGtextBox = new Random();

            int Numero = NumeroGtextBox.Next(1,100);

            this.NumeroGtextBox.Text = Convert.ToString(Numero);


            Mostrar( Numero);

          //  NumeroGtextBox.Text = Convert.ToString(Generarbutton);

        }
        private int Mostrar(int num)
        {
            if (num % 3 == 0)
            {
                ResultadotextBox.Text = Convert.ToString("Jarby");
            }else if (num%5 == 0){

                ResultadotextBox.Text = Convert.ToString("Lisbeth");
            }
            else
            {
               ResultadotextBox.Text = Convert.ToString("Jarby Lisbeth");
            }
            return num;
        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
