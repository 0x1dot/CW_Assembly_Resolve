using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Sinifim
    {
        public ArrayList sayiuret(int baslangic,int bitis,int adet)
        {
            ArrayList array = new ArrayList();
            Random rnd = new Random();
            int baslangic_sayisi = baslangic;
            int i=0;
            while (i < adet)
            {
                array.Add(rnd.Next(baslangic,bitis));
                i++;
            }
            return array;
        }
    }
}
