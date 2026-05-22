using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
namespace REVIETHA_NUR_HIDAYAH_2034_kelasF_UTSPBO_D
{
    abstract class PesananMakanan
    {
        private string namaPesanan;
        private string nomorMeja;
        private string menuUtama;

        public int jumlahPorsi { get; set };
        public double hargaPerPorsi { get; set };
        public double total { get; set };

    }
        public class PesananMakanan { string namaPesanan; string nomorMeja; string menuUtama; }:base {namaPesanan }, { nomorMeja }, { menuUtama }

        this.namaPesanan = namaPesanan;
        this.nomorMeja = nomorMeja;
        this.namaPesanan = namaPesanan;
    public class namaPemesan {
        get{return namaPemesan;}
        set{namaPemesan value;}
    }

    public class nomorMeja {
        get{return nomorMeja;}
        set{nomorMeja value;}
    }

    public class menuUtama
    {
        get{return menuUtama;}
        set{menuUtama value;}
    }
    
public void tampilInfo()
{
    Console.WriteLine($"Nama Pemesan: " + namaPemesan;);
    Console.WriteLine($"Nomor Meja: " + nomorMeja; );
    Console.WriteLine($"Menu Utama: " + menuUtama; );
}
public abstract double hitungTotalBill();

 
   
    
           

        
            