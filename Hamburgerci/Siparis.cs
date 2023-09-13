using Hamburgerci.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    public class Siparis
    {
        public Menuler Menu { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
        public Boyut MenuBoyutu { get; set; }
        public decimal Adet { get; set; }
        public static decimal ToplamTutar { get; set; }




        private string malzemeListesi="";

        public decimal EnToplamTutar()
        {
            return ToplamTutar;
        }
        public decimal MalzemeFiyati()
        {
            decimal toplamFiyat=0;
            foreach (Malzeme malzeme in Malzemeler)
            {
                toplamFiyat += malzeme.Fiyat;
            }
            return toplamFiyat;
        }
    public decimal ToplamFiyat()
        {
            decimal toplamFiyat = Menu.Fiyat;
            foreach (Malzeme malzeme in Malzemeler)
            {
                toplamFiyat += malzeme.Fiyat;
            }
            switch(MenuBoyutu)
            {
                case Boyut.Kucuk:
                    break;
                case Boyut.Orta:
                    toplamFiyat += 5;
                    break;
                    case Boyut.Buyuk: 
                    toplamFiyat += 10;
                    break;
            }
            toplamFiyat = toplamFiyat * Adet;
            return toplamFiyat; 
        }


        public override string ToString()
        {
            foreach (Malzeme malzeme in Malzemeler)
            {
                malzemeListesi =malzemeListesi+malzeme.Ad + ",";
            }
            return $"{Adet} Adet x {Menu.Ad}, {MenuBoyutu} Boy, {malzemeListesi} ₺{ToplamFiyat()}  ";
        }
    }
}
