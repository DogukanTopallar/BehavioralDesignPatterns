using System;
using System.Collections.Generic;

namespace StrategyPattern
{


    // Ana strateji arayüzü
    interface IIndirimHesaplama
    {
        double IndirimHesapla(double tutar);
    }

    // Doğum günü indirim stratejisi
    class DogumGunuIndirimi : IIndirimHesaplama
    {
        public double IndirimHesapla(double tutar)
        {
            return tutar * 0.15;
        }
    }

    // Sezonluk indirim stratejisi
    class SezonlukIndirim : IIndirimHesaplama
    {
        public double IndirimHesapla(double tutar)
        {
            return tutar * 0.10;
        }
    }

    // Temmuz ayı indirim stratejisi
    class TemmuzIndirimi : IIndirimHesaplama
    {
        public double IndirimHesapla(double tutar)
        {
            return tutar * 0.20;
        }
    }

    // Sepet sınıfı
    class Sepet
    {
        private List<double> urunler = new List<double>();
        private IIndirimHesaplama indirimHesaplama;

        public void SepeteUrunEkle(double urunFiyati)
        {
            urunler.Add(urunFiyati);
        }

        public void IndirimUygula(IIndirimHesaplama hesaplama)
        {
            this.indirimHesaplama = hesaplama;
        }

        public double ToplamTutar()
        {
            double toplam = 0;

            foreach (var urun in urunler)
            {
                toplam += urun;
            }

            if (indirimHesaplama != null)
            {
                toplam -= indirimHesaplama.IndirimHesapla(toplam);
            }

            return toplam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();
            sepet.SepeteUrunEkle(100);
            sepet.SepeteUrunEkle(200);
            sepet.SepeteUrunEkle(50);

            // Doğum günü indirimi
            sepet.IndirimUygula(new DogumGunuIndirimi());
            Console.WriteLine(sepet.ToplamTutar()); // 297.5

            // Sezonluk indirimi
            sepet.IndirimUygula(new SezonlukIndirim());
            Console.WriteLine(sepet.ToplamTutar()); // 315

            // Temmuz ayı indirimi
            sepet.IndirimUygula(new TemmuzIndirimi());
            Console.WriteLine(sepet.ToplamTutar()); // 252
        }
    }
}
