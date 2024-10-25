using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void DisplayCustomerList()
            //{
            //    Console.WriteLine("1. Ahmet Demir");
            //    Console.WriteLine("2. Elif Demir");
            //    Console.WriteLine("3. Murat Çelik");
            //    Console.WriteLine("4. Zeynep Akın");
            //}

            //DisplayCustomerList();
            //DisplayCustomerList();
            //DisplayCustomerList();
            //DisplayCustomerList();

            //void AddNumbers()
            //{
            //    int a = 3, b = 5;
            //    int result = a + b;
            //    Console.WriteLine(result);
            //}

            //AddNumbers();

            #endregion

            #region Void Methods with String Parameters

            //void PrintCustomerName(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //PrintCustomerName("Serkan Kaya");

            //void PrintCustomerCard(string firstName, string lastName)
            //{
            //    Console.WriteLine("Müşteri: " + firstName + " " + lastName);
            //}

            //PrintCustomerCard("Emre", "Doğan");
            //PrintCustomerCard("Ebru", "Yılmaz");

            #endregion

            #region Void Methods with Int Parameters

            //void CalculateSum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //CalculateSum(7, 8, 9);

            #endregion

            #region Methods Returning Values

            //string GetCustomerName()
            //{
            //    return "Deniz Akın";
            //}

            //GetCustomerName();

            //string CreateStudentCard()
            //{
            //    string firstName = "Veli";
            //    string lastName = "Arslan";
            //    return firstName + " " + lastName;
            //}

            //Console.WriteLine(CreateStudentCard());

            #endregion

            #region Methods Returning String with Parameters

            //string GetCountryCard(string countryName, string capitalCity, string flagColors)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capitalCity + " - Bayrak Renkleri: " + flagColors;
            //    return cardInfo;
            //}

            //string a, b, c;

            //Console.Write("Ülke adını giriniz: ");
            //a = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //b = Console.ReadLine();

            //Console.Write("Bayrak Renklerini Giriniz: ");
            //c = Console.ReadLine();

            //Console.WriteLine(GetCountryCard(a, b, c));
            //Console.WriteLine(GetCountryCard("Almanya", "Berlin", "Siyah - Kırmızı - Sarı"));

            #endregion

            #region Methods Returning Int with Parameters

            //int CalculateTotal(int number1, int number2)
            //{
            //    int total = number1 + number2;
            //    return total;
            //}

            //Console.WriteLine(CalculateTotal(30, 70));
            //Console.WriteLine(CalculateTotal(12, 18));
            //Console.WriteLine(CalculateTotal(22, 33));
            //Console.WriteLine(CalculateTotal(7, 14));

            #endregion

            #region Example Application

            //string GetExamResult(string studentName, int score1, int score2, int score3)
            //{
            //    int average = (score1 + score2 + score3) / 3;
            //
            //    if (average >= 50)
            //    {
            //        return studentName + " isimli öğrenci sınavı geçti. Ortalama: " + average;
            //    }
            //    else
            //    {
            //        return studentName + " isimli öğrenci sınavı geçemedi. Ortalama: " + average;
            //    }
            //}

            //Console.WriteLine(GetExamResult("Fatma", 85, 55, 60));
            //Console.WriteLine(GetExamResult("Mustafa", 30, 40, 35));

            #endregion

            Console.Read();
        }
    }
}
