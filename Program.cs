using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphsimAbstractionCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123-234-345";
            karyawanTetap.Nama = "Michael Suyama";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "123-321-346";
            karyawanHarian.Nama = "Laura Callahan";
            karyawanHarian.UpahPerJam = 13000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "123-333-346";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            //Objek class karyawan

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}