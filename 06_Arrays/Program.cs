using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] renkler = new string[4];
            //renkler[0] = "Kırmızı";
            //renkler[1] = "Sarı";
            //renkler[2] = "Beyaz";
            //renkler[3] = "Mavi";

            //Console.WriteLine(renkler[2]);

            //string[] sehirler = new string[5];

            //sehirler[0] = "Milano";
            //sehirler[1] = "Budapeşte";
            //sehirler[2] = "Lyon";
            //sehirler[3] = "Kahire";
            //sehirler[4] = "Üsküp";

            //Console.WriteLine(sehirler[4]);

            //int[] sayilar = new int[10];

            //sayilar[0] = 50;
            //sayilar[1] = 40;
            //sayilar[2] = 698;
            //sayilar[3] = 24;
            //sayilar[7] = 748;

            //Console.WriteLine(sayilar[5]);

            //string[] ulkeler = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(ulkeler[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] renkler = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < renkler.Length; i++)
            //{
            //    Console.WriteLine(renkler[i]);
            //}

            //int[] sayilar = { 4, 85, 96, 74, 125, 638, 488, 7456, 2365, 1122 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            //char[] semboller = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < semboller.Length; i++)
            //{
            //    Console.WriteLine(semboller[i]);
            //}


            //int[] benimDizim = { 47, 85, 96, 87, 32, 152, 658, 140 };

            //int enBuyukSayi = benimDizim[0];

            //for (int i = 0; i < benimDizim.Length; i++)
            //{
            //    if (benimDizim[i] > enBuyukSayi)
            //    {
            //        enBuyukSayi = benimDizim[i];
            //    }
            //}

            //Console.WriteLine(enBuyukSayi);

            //string[] kisiler = { "ali", "ahmet", "ayşe", "birgül", "cem", "deniz" };
            //Console.WriteLine(kisiler.Length);

            //int[] sayilar = { 1, 2, 45, 82, 86, 10, 35 };

            //Array.Sort(sayilar);  // Küçükten Büyüğe sıralama

            //for (int i = 0; i < sayilar.Length; i++) { 
            //    Console.WriteLine(sayilar[i]);
            //}

            //int[] sayilar = { 1, 2, 45, 82, 86, 10, 35 };
            //Array.Reverse(sayilar);  // Diziyi tersten yazır

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            #endregion

            #region Dizi Metodları

            //string[] musteriler = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(musteriler, "merve"); // index numarası

            //Console.WriteLine(index);

            //int[] sayilar = { 45, 83, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + sayilar.Max() 
            //    + " Dizinin en küçük elemanı: " +  sayilar.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] sehirler = new string[5];

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    sehirler[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            //int[] sayilar = { 10, 20, 30, 40, 50 };
            //int toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}

            //Console.WriteLine(toplam);

            //int[] sayilar = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 1)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}


            #endregion

            Console.Read();


        }
    }
}
