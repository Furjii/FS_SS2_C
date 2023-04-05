using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
                        case 'k':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = LAPTOP-DKPVN1V3\\FURJIKUN04; " +
                                    "initial catalog = {0}; " +
                                    "USer ID = {1}; password = {2}";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Melihat Seluruh Data");
                                        Console.WriteLine("2. Tambah Data");
                                        Console.WriteLine("3. Remove");
                                        Console.WriteLine("4. Keluar");

                                        Console.WriteLine("\nMasukkan pilihan anda (1-4) :");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Produk\n");
                                                    Console.WriteLine();
                                                    pr.baca(conn);
                                                    conn.Close();
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Data Produk\n");
                                                    Console.WriteLine("Masukkan ID Produk :");
                                                    string IDproduk = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Produk :");
                                                    string NmaProduk = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Deskripsi Produk :");
                                                    string Deskripsi = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Stok Produk :");
                                                    string Stok = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Harga Jual :");
                                                    string hrgajual = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insert(IDproduk, NmaProduk, Deskripsi, Stok, hrgajual, conn);
                                                        conn.Close();

                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah data");
                                                    }

                                                }
                                            case '3':
                                                conn.Close();
                                                return;
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\nInvalid option");
                                                }
                                                break;
                                        }

                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nCheck For The Value Entered.");
                                    }
                                }
                            }
                        default:
                            {
                                Console.WriteLine("\nInvalid Option");
                            }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak dapat mengakses database menggunakan user tersebut\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
