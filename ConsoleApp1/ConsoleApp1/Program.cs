﻿using System;

namespace HW14092021
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephone = new Telephone();

            telephone.Manufacturer = "Samsung";
            telephone.Model = "Galaxy";
            telephone.Length = 12;
            telephone.Width = 9;
            telephone.Depth = 2;

            //==============================================
            var mashina = new Mashina();
            mashina.Marka = "VW";
            mashina.Numurs = "PT1978";
            mashina.Atrums = 8;

            string uztaure = mashina.Uztaure();
            Console.WriteLine(uztaure);

            //============================================


            var prece = new Prece (25, 15, 125);

          
            string precesparametri = prece.PrecesParametri();
            Console.WriteLine(precesparametri);


            //============================================



















        }
    }
}
