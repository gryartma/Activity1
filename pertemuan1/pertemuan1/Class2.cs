using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    class Class2
    {
        double panjang3, lebar3;

        public void Masukkan3()
        {
            Console.WriteLine("masukan Panjang3: ");
            panjang3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("masukan lebar3: ");
            lebar3 = Convert.ToDouble(Console.ReadLine());

        }

        public double Hitung3()
        {
            return panjang3 * lebar();
        }

        public void Keluaran3()
        {
            Console.WriteLine("luas persegi panjang3 = {0}", Hitung3());
            Console.ReadKey();
        }

        public double lebar()
        {
            Console.WriteLine("masukan lebar :");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
