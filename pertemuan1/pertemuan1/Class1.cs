using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    class Class1
    {
        private double luas2, panjang2, lebar2;

        public void Masukkan2()
        {
            Console.WriteLine("masukan Panjang2: ");
            panjang2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukan lebar2: ");
            lebar2 = Convert.ToDouble(Console.ReadLine());

        }

        public void Hitung2()
        {
            luas2 = panjang2 * lebar2;
        }

        public void Keluaran2()
        {
            Console.WriteLine("luas persegi panjang2 = {0}", luas2) ;
            Console.ReadKey();
        }
    }
}
