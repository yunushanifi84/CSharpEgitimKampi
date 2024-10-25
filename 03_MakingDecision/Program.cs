using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string sifre;
            //sifre = Console.ReadLine();
            //if (sifre == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}

            //string baskent, ulke;

            //Console.Write("Başkenti Giriniz: ");
            //baskent = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //ulke = Console.ReadLine();

            //if (baskent == "ankara" & ulke == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int sayi;

            //Console.Write("Sayıyı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int sinav1, sinav2, sinav3, ortalama;
            //string sonuc = "Hata!";

            //Console.Write("Sınav1: ");
            //sinav1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //sinav2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //sinav3 = int.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + ortalama);

            //if (ortalama > 0 & ortalama <= 50)
            //{
            //    sonuc = "Sonuç vasat";
            //}
            //if(ortalama > 50 & ortalama <= 70)
            //{
            //    sonuc = "Sonuç orta";
            //}
            //if (ortalama > 70 & ortalama <= 84)
            //{
            //    sonuc = "Sonuç iyi";
            //}
            //if (ortalama > 84)
            //{
            //    sonuc = "Sonuç çok iyi";
            //}

            //Console.WriteLine(sonuc);

            //string sehir;

            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //sehir = Console.ReadLine();

            //if (sehir == "ankara" | sehir == "adana" | sehir == "istanbul" | sehir == "giresun")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
            //string kullaniciAdi = Console.ReadLine();
            //if (kullaniciAdi != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}



            #endregion

            #region Mod işlemleri

            //int sayi = 26;
            //int kalan = sayi % 5;
            //Console.WriteLine(kalan);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int kalanSonuc = sayi1 % sayi2;

            //Console.Write("1. sayının 2. sayıya bölü münden kalan: " + kalanSonuc);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int tekCiftSayi = int.Parse(Console.ReadLine());

            //if (tekCiftSayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else {
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char değişkenleri karar yapıları

            //char takim;
            //Console.Write("Lütfen takımınızın sembolünü giriniz: ");
            //takim = char.Parse(Console.ReadLine());

            //if (takim == 'g' | takim == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (takim == 'f' | takim == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (takim == 'b' | takim == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Uygulama Projesi
            //Console.WriteLine("C# Eğitim Kampı Restoran");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuSecim;

            //Console.Write("Lütfen detayı görmek istediğiniz menüyü seçiniz: ");
            //menuSecim = Console.ReadLine();

            //if (menuSecim == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Etli Pilav");
            //    Console.WriteLine("4- Fırında Makarna");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}

            //if (menuSecim == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Kremalı Tavuk Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}

            //if (menuSecim == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}

            //if (menuSecim == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}

            //if (menuSecim == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Profiterol");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int ayNumarasi = int.Parse(Console.ReadLine());

            //switch (ayNumarasi)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi yaptınız"); break;
            //}

            #endregion

            #region Hesap Makinesi

            //int sayi1, sayi2, islemSonucu;
            //char islemSembol;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapacağınız işlemi giriniz: ");
            //islemSembol = char.Parse(Console.ReadLine());

            //switch (islemSembol) {
            //
            //    case '+': 
            //        islemSonucu = sayi1 + sayi2;
            //        Console.WriteLine("Toplam: " + islemSonucu);
            //        break;

            //    case '-': 
            //        islemSonucu = sayi1 - sayi2;
            //        Console.WriteLine("Fark: " + islemSonucu); 
            //        break;

            //    case '*': 
            //        islemSonucu = sayi1 * sayi2;
            //        Console.WriteLine("Çarpım: " + islemSonucu); 
            //        break;

            //    case '/': 
            //        islemSonucu = sayi1 / sayi2;
            //        Console.WriteLine("Bölüm: " + islemSonucu); 
            //        break;

            //    default: Console.Write("Hatalı veri girişi."); break;
            //}

            #endregion

            Console.Read();

        }
    }
}
