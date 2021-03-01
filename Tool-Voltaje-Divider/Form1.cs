using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Voltaje_Divider
{
    public partial class Form1 : Form
    {
        Divisor DivisorVoltaje = new Divisor();
        ControlObjet Control = new ControlObjet();


        public Form1()
        {
            InitializeComponent();
        }

        private void TxtVou_Enter(object sender, EventArgs e)
        {
            if (TxtVou.Text == "Voltaje de Salida")
            {
                TxtVou.Text = "";

            }
           
        }
        private void TxtVou_Leave(object sender, EventArgs e)
        {
            if (TxtVou.Text == "")
            {
                TxtVou.Text = "Voltaje de Salida";

            }
        }

        private void TxtVin_Enter(object sender, EventArgs e)
        {
            if (TxtVin.Text == "Voltaje de Entrada")
            {
                TxtVin.Text = "";

            }
        }

        private void TxtVin_Leave(object sender, EventArgs e)
        {
            if(TxtVin.Text == "")
            {
                TxtVin.Text = "Voltaje de Entrada";

            }
        }

        private void TxtR1_Enter(object sender, EventArgs e)
        {
            if (TxtR1.Text == "Resistencia 1")
            {      
                TxtR1.Text = "";

            }
        }

        private void TxtR1_Leave(object sender, EventArgs e)
        {
            if (TxtR1.Text == "")
            {      
                TxtR1.Text = "Resistencia 1";

            }
        }

        private void TxtR2_Enter(object sender, EventArgs e)
        {
            if (TxtR2.Text == "Resistencia 2")
            {      
                TxtR2.Text = "";

            }
        }

        private void TxtR2_Leave(object sender, EventArgs e)
        {
            if (TxtR2.Text == "")
            {      
                TxtR2.Text = "Resistencia 2";

            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            switch (Control.Returndata())
            {
                case 0:
                    double R1 = DivisorVoltaje.GetR1(TxtVin.Text, TxtVou.Text, TxtR2.Text);
                    Console.WriteLine("El resultado es :" + R1.ToString("0.##"));
                    break;
                case 1:
                    double R2 = DivisorVoltaje.GetR2(TxtVin.Text, TxtVou.Text, TxtR1.Text);
                    Console.WriteLine("El resultado es :" + R2.ToString("0.##"));
                    break;
                case 2:
                    double Vou = DivisorVoltaje.GetVout(TxtVin.Text, TxtR1.Text, TxtR2.Text);
                    Console.WriteLine("El resultado es :" + Vou.ToString("0.##"));
                    break;
                default:
                    break;
            }

      
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            CboSelect.SelectedIndex = 0;
            Control.GetIndexCbo(CboSelect.SelectedIndex,TxtR1,TxtR2,TxtVou,TxtVin);

        }

        private void CboSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            Control.GetIndexCbo(CboSelect.SelectedIndex, TxtR1, TxtR2, TxtVou, TxtVin);

        }
    }


}
