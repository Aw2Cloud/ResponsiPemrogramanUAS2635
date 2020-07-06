using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        Produk Produk = new Produk();
        
        static List<Produk> daftarProduk = new List<Produk>();
        

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                Produk Produk = new Produk();
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
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

                    case 4: // keluar dari program
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Silahkan Pilih Menu yang tersedia");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {


            Console.Clear();
            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk\n");
            Console.Write("Kode Produk : ");
            produk.kode = int.Parse(Console.ReadLine());
            Console.Write("Nama Produk : ");
            produk.nama = Console.ReadLine();
            Console.Write("Harga Beli : ");
            produk.beli = int.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            produk.jual = int.Parse(Console.ReadLine());
            daftarProduk.Add(produk);
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, del = -1;
            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            int code = int.Parse(Console.ReadLine());
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if (produk.kode == code)
                {
                    del = no;
                }
            }
            if (del != -1)
            {
                daftarProduk.RemoveAt(del);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {

            Console.Clear();

            int no = 0;
            Console.WriteLine("Data Produk\n");
            foreach(Produk produk in daftarProduk)
            {
                no++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, produk.kode, produk.nama, produk.beli, produk.jual);
            }
            if (no < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }


            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
