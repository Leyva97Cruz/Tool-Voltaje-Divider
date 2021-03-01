using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_Voltaje_Divider
{
    class ControlObjet
    {
        private int Regresa;
        //public int Value;
        int GetR1(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = false;
            Txtr2.Visible = true;
            Txtvou.Visible = true;
            Txtvin.Visible = true;
            Regresa = 0;
            return Regresa;
        }
        int GetR2(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = true;
            Txtr2.Visible = false;
            Txtvou.Visible = true;
            Txtvin.Visible = true;
            Regresa = 1;
            return Regresa;
        }
        int  GetVou(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = true;
            Txtr2.Visible = true;
            Txtvou.Visible = false;
            Txtvin.Visible = true;
            Regresa = 2;
            return Regresa;
        }
        void Normal(TextBox Txtr1, TextBox Txtr2, TextBox Txtvou, TextBox Txtvin)
        {
            Txtr1.Visible = true;
            Txtr2.Visible = true;
            Txtvou.Visible = true;
            Txtvin.Visible = true;

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
                default:
                    Normal(Txtr1, Txtr2, Txtvou, Txtvin);
                    break;
            }
        }
        public int Returndata() 
        {
            return Regresa;
        }

    }
}
