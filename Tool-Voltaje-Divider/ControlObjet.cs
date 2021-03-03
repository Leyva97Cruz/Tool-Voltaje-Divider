using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tool_Voltaje_Divider
{
    /******************************************************
     *  Esta es una clase en la cual controlamos          *
     *  los textbox y otro controles del windows forms    *
     *                                                    *
     ******************************************************/
    class ControlObjet
    {
        private int Regresa;
        int GetR1(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = false;
            Txtr2.Visible = true;
            Txtr2.Location = new Point(33, 143);
            Txtvou.Visible = true;
            Txtvou.Location = new Point(33, 209);
            Txtvin.Visible = true;
            Txtvin.Location = new Point(33, 275);
            Regresa = 0;
            return Regresa;
        }

        int GetR2(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr2.Visible = false;
            Txtr1.Visible = true;
            Txtr1.Location = new Point(33, 143);
            Txtvou.Visible = true;
            Txtvou.Location = new Point(33, 209);
            Txtvin.Visible = true;
            Txtvin.Location = new Point(33, 275);
            Regresa = 1;
            return Regresa;
        }

        int  GetVou(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtvou.Visible = false;
            Txtr1.Visible = true;
            Txtr1.Location = new Point(33, 143);
            Txtr2.Visible = true;
            Txtr2.Location = new Point(33, 209);
            Txtvin.Visible = true;
            Txtvin.Location = new Point(33, 275);
            Regresa = 2;
            return Regresa;
        }

        public void ClearTxt(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {

            Txtr1.Clear();
            Txtr2.Clear();
            Txtvou.Clear();
            Txtvin.Clear();

            
        }
        int Normal(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = true;
            Txtr1.Location = new Point(33, 143);
            Txtr2.Visible = true;
            Txtr2.Location = new Point(33, 209);
            Txtvou.Visible = true;
            Txtvou.Location = new Point(33, 275);
            Txtvin.Visible = true;
            Txtvin.Location = new Point(33, 342);
            Regresa = 3;
            return Regresa;

        }

        public void GetIndexCbo(int Value, TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            switch (Value)
            {
                case 0:
                    GetR1(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;
                case 1:
                    GetR2(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;
                case 2:
                    GetVou(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;

                case 3:
                    Normal(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;
                default:
                    Normal(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;
            }
        }

        public int Returndata() 
        {
            return Regresa;
        }

        public void Simulation(ProgressBar Vou ,double Vin, double R1, double R2)
        {
            int r1 = Convert.ToInt32(R1);
            int r2 = Convert.ToInt32(R2);
            int vin = Convert.ToInt32(Vin);
            Vou.Value = (r2 / (r1 + r2)) * vin;

        }

    }
}
