using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billeteras
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            return BilletesDe10*10 + BilletesDe20*20 + BilletesDe50*50 + BilletesDe100*100 + BilletesDe200*200
                + BilletesDe500*500 + BilletesDe1000*1000;
        }
        public Billetera Combinar(Billetera otraBilletera)
        {
            Billetera nuevaBilletera = new Billetera();

            int sumaBilletesDe10 = BilletesDe10 + otraBilletera.BilletesDe10;
            int sumaBilletesDe20 = BilletesDe20 + otraBilletera.BilletesDe20;
            int sumaBilletesDe50 = BilletesDe50 + otraBilletera.BilletesDe50;
            int sumaBilletesDe100 = BilletesDe100 + otraBilletera.BilletesDe100;
            int sumaBilletesDe200 = BilletesDe200 + otraBilletera.BilletesDe200;
            int sumaBilletesDe500 = BilletesDe500 + otraBilletera.BilletesDe500;
            int sumaBilletesDe1000 = BilletesDe1000 + otraBilletera.BilletesDe1000;

            nuevaBilletera.BilletesDe10 = sumaBilletesDe10;
            nuevaBilletera.BilletesDe20 = sumaBilletesDe20;
            nuevaBilletera.BilletesDe50 = sumaBilletesDe50;
            nuevaBilletera.BilletesDe100 = sumaBilletesDe100;
            nuevaBilletera.BilletesDe200 = sumaBilletesDe200;
            nuevaBilletera.BilletesDe500 = sumaBilletesDe500;
            nuevaBilletera.BilletesDe1000 = sumaBilletesDe1000;

            return nuevaBilletera ; 
        }
    }
}
