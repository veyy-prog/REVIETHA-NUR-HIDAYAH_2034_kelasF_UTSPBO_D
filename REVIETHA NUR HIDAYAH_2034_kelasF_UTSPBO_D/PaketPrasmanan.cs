using System;
namespace REVIETHA_NUR_HIDAYAH_2034_kelasF_UTSPBO_D
{
    public class PaketPrasmanan : PesananMakanan
    {
        public double hargaPerPorsi { get; set; }
        public double biayaService { get; set; }
        public override double hitungTotalBill(int jumlahPorsi)
        {
            return (jumlahPorsi * hargaPerPorsi) + biayaService;
        }
    }
}
