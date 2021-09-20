using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14092021
{
    public class Prece
    {

        public Prece (double garums, double augstums, double svars)
        {
            Garums = garums;
            Augstums = augstums;
            Svars = svars;
        }
        public double Garums { get; }
        public double Augstums { get; }
        public double Svars { get; }


        public string PrecesParametri()
        {
            return $"Preces parametri ir Augstums {Augstums} un Garums {Garums} ka ari Svars {Svars}";
        }






    }
}
