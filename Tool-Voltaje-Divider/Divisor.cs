using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Voltaje_Divider
{
    class Divisor
    {

        public double GetR1(string Vin,string Vout,string R2)
        {
            double R1 = ((Convert.ToDouble(R2) * Convert.ToDouble(Vin)) / Convert.ToDouble(Vout)) - Convert.ToDouble(R2);

            return R1;
        }

        public double GetR2(string Vin, string Vout, string R1)
        {
            double R2 = (Convert.ToDouble(Vout) * Convert.ToDouble(R1)) / (Convert.ToDouble(Vin) - Convert.ToDouble(Vout));

            return R2;
        }

        public double GetVout(string Vin, string R1,string R2)
        {
            double Vou = (Convert.ToDouble(R2) / (Convert.ToDouble(R1) + Convert.ToDouble(R2))) * Convert.ToDouble(Vin);
            return Vou;
            
        }

    }
}
