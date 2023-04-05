using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS_SS2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Koneksi ke database\n");
                    Console.WriteLine("masukkan User ID :");
                    string user = Console.ReadLine();
                    Console.WriteLine("Masukkan Password");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Masukkan Database Tujuan :");
                    string dtb = Console.ReadLine();
                    Console.Write("\nKetik K untuk terhubung ke database");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {

                    }

                }
            }
        }
    }
}
