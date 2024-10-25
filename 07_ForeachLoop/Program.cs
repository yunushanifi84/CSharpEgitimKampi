using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Loop

            //string[] sehirler = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}

            //int[] sayilar = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 285, 6578, 1245 };

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //int[] sayilar = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 285, 6578, 1245 };

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}

            //int[] sayilar = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 285, 6578, 1245 };

            //int toplam = 0;

            //foreach (int sayi in sayilar)
            //{
            //    toplam += sayi;
            //}

            //List<int> sayilarListesi = new List<int>() { 1, 2, 3, 4, 5, 8 };

            //foreach (int sayi in sayilarListesi)
            //{
            //    Console.WriteLine(sayi);
            //}

            //string kelime = "Merhaba";

            //foreach (char harf in kelime)
            //{
            //    Console.WriteLine(harf);
            //}

            #endregion

            #region Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci var: ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayan diziler
            string[] ogrenciIsimleri = new string[ogrenciSayisi];
            double[] ogrenciNotOrtalamalari = new double[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                ogrenciIsimleri[i] = Console.ReadLine();

                double toplamNot = 0;

                // Her öğrenci için 3 adet sınav notu girişi alıyoruz
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ogrenciIsimleri[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double notDegeri = double.Parse(Console.ReadLine());
                    toplamNot += notDegeri; // Notları topluyoruz
                }
                Console.WriteLine();

                ogrenciNotOrtalamalari[i] = toplamNot / 3;
            }

            // Öğrencilerin sınav ortalaması
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine("----------------------------------");

                Console.WriteLine($"{ogrenciIsimleri[i]} adlı öğrencinin ortalaması: {ogrenciNotOrtalamalari[i]}");

                // Öğrencilerin geçip kalma durumu
                if (ogrenciNotOrtalamalari[i] >= 50)
                {
                    Console.WriteLine($"{ogrenciIsimleri[i]} adlı öğrenci dersi başarıyla geçti.");
                }
                else
                {
                    Console.WriteLine($"{ogrenciIsimleri[i]} adlı öğrenci dersten başarısız oldu.");
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
