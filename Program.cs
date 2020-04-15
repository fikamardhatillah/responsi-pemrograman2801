using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ResponsiPemrograman2801
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112801, "Taehyung", 3000000);
            Karyawan karyawan2 = new Karyawan(19112802, "Jungkook", 2000000);
            Karyawan karyawan3 = new Karyawan(19112803, "Kim Seokjin", -1000000);

            Console.WriteLine("Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.karyawan();
            karyawan2.karyawan();
            karyawan3.karyawan();

            Console.WriteLine("\n\nAsikkkk Kenaikan Gaji 10%!!!\n\n");

            Console.WriteLine("Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();
            karyawan3.NaikGaji();

            Console.ReadKey();
        }
    }
}
