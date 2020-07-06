using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {

        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "RESPONSI UAS MATAKULIAH PEMROGRAMAN";
            bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nPILIH MENU (1,2,3,4): ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("MENU TIDAK ADA.");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("PILIH MENU APLIKASI...\n");
            Console.WriteLine("1.) TAMBAH PRODUK.");
            Console.WriteLine("2.) HAPUS PRODUK.");
            Console.WriteLine("3.) TAMPILKAN PRODUK.");
            Console.WriteLine("4.) KELUAR.");
        }

        static void TambahProduk()
        {
            Console.Clear();
//
            Produk produk = new Produk();
            Console.WriteLine("TAMBAH DATA PRODUK.\n");
            Console.Write("KODE PRODUK..: ");
            produk.productcode = Console.ReadLine();
            Console.Write("NAMA PRODUK..: ");
            produk.productname = Console.ReadLine();
            Console.Write("HARGA BELI..: ");
            produk.productprice = double.Parse(Console.ReadLine());
            Console.Write("HARGA JUAL..: ");
            produk.sell = double.Parse(Console.ReadLine());
            daftarProduk.Add(produk);
			
            Console.WriteLine("\nTEKAN TOMBOL (ENTER) UNTUK KEMBALI KE AWAL.\n");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("HAPUS DATA PRODUK.");
            Console.Write("KODE PRODUK..: ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.productcode == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nDATA PRODUK BERHASIL DI HAPUS.\n");
            }
            else
            {
                Console.WriteLine("\nKODE PRODUK TIDAK ADA.\n");
            }

            Console.WriteLine("\nTEKAN TOMBOL (ENTER) UNTUK KEMBALI KE AWAL.\n");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int number = 0;
            Console.WriteLine("DATA PRODUK.\n");
            foreach (Produk produk in daftarProduk)
            {
                number++;
                Console.WriteLine("{0}. KODE PRODUK..: {1}, NAMA PRODUK..: {2}, HARGA BELI..: {3}, HARGA JUAL..: {4}", number, produk.productcode, produk.productname, produk.productprice, produk.sell);
            }
            if (number < 1)
            {
                Console.WriteLine("DATA PRODUK TIDAK ADA.\n");
            }

            Console.WriteLine("\nTEKAN TOMBOL (ENTER) UNTUK KEMBALI KE AWAL.\n");
            Console.ReadKey();
        }
    }
}