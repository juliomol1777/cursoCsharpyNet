﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Billetera
    {
        public int BilletesDe10 {get; set;}
        public int BilletesDe20 {get; set;}
        public int BilletesDe50 {get; set;}
        public int BilletesDe100 {get; set;}
        public int BilletesDe200 {get; set;}
        public int BilletesDe500 {get; set;}
        public int BilletesDe1000 {get; set;}

        public Billetera()
        {
        }

        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, 
                int billetesDe100, int billetesDe200, int billetesDe500, 
                int billetesDe1000)
        {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        public decimal Total()
        {
            return BilletesDe10*10+BilletesDe20*20+BilletesDe50*50+
                   BilletesDe100*100+BilletesDe200*200+BilletesDe500
                   *500+BilletesDe1000*1000;
        }

        public Billetera Combinar(Billetera billetera)
        {
            Billetera billetera2 = new Billetera();
            billetera2.BilletesDe10 = BilletesDe10 + billetera.BilletesDe10;
            BilletesDe10 = 0;
            billetera.BilletesDe10 = 0;
            billetera2.BilletesDe20 = BilletesDe20 + billetera.BilletesDe20;
            BilletesDe20 = 0;
            billetera.BilletesDe20 = 0;
            billetera2.BilletesDe50 = BilletesDe50 + billetera.BilletesDe50;
            BilletesDe50 = 0;
            billetera.BilletesDe50 = 0;
            billetera2.BilletesDe100 = BilletesDe100 + billetera.BilletesDe100;
            BilletesDe100 = 0;
            billetera.BilletesDe100 = 0;
            billetera2.BilletesDe200 = BilletesDe200 + billetera.BilletesDe200;
            BilletesDe200 = 0;
            billetera.BilletesDe200 = 0;
            billetera2.BilletesDe500 = BilletesDe500 + billetera.BilletesDe500;
            BilletesDe500 = 0;
            billetera.BilletesDe500 = 0;
            billetera2.BilletesDe1000 = BilletesDe1000 + billetera.BilletesDe1000;
            BilletesDe1000 = 0;
            billetera.BilletesDe1000 = 0;

            return billetera2;
        }

    }
}
