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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }
        int periodos = 2; double capital = 200000; int t = 1;
        double tasa = 0.015; double interes = 0;
        double acum = 0; double MontoTotal;

        private void Calculobutton_Click(object sender, EventArgs e)
        {
            
            String[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
            "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            for (int i = 0; i < Meses.Length; i++)
            {
                interes = capital * tasa * t;
                MontoTotal = interes + capital;
                ValoreslistBox.Items.Add(Meses[i]+ " |"+ interes+"    |"+ MontoTotal);

                capital = MontoTotal;
            }

           // Mostrar();

        }
        private void Mostrar()
        {
            for (int i = 0; i <= periodos; i++)
            {
                ValoreslistBox.Items.Add(" MES " + interes + MontoTotal);
            }
        }

       
    }
}
