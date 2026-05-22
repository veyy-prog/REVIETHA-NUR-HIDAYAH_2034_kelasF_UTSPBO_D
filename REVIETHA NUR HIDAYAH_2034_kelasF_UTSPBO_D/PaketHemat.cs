using System;

namespace REVIETHA_NUR_HIDAYAH_2034_kelasF_UTSPBO_D
{
    class PaketHemat : PesananMakanan
    {
        private double hargaPerPorsi { get;set }
        public override double hitungTotalBill(int jumlahPorsi()
        {
            return jumlahPorsi * hargaPerPorsi;
        }
    }
}
