using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //int counter;

            //for (counter = 0; counter <= 5; counter++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int number = 1; number <= 20; number++)
            //{ 
            //    Console.WriteLine(number);
            //}

            //for (int multipleOfThree = 3; multipleOfThree <= 50; multipleOfThree += 3)
            //{
            //    Console.WriteLine(multipleOfThree);
            //}

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int targetValue = int.Parse(Console.ReadLine());

            //for(int count = 0; count < targetValue; count++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Loop with Decision Structures

            //for (int value = 0; value <= 100; value++)
            //{
            //    if (value % 5 == 0)
            //    {
            //        Console.WriteLine(value);
            //    }
            //}

            //int sumValue = 0;
            //for (int value = 1; value <= 10; value++)
            //{
            //    sumValue += value;
            //}

            //Console.WriteLine(sumValue);

            //int evenSumValue = 0;

            //for (int value = 1; value < 20; value++) 
            //{
            //    if (value % 2 == 0) 
            //    { 
            //        evenSumValue += value;
            //        Console.WriteLine(value);
            //    }   
            //}

            //Console.WriteLine("-------------");
            //Console.WriteLine(evenSumValue);

            //int divisibleCount = 0;
            //for (int value = 1; value <= 50; value++)
            //{
            //    if (value % 7 == 0)
            //    {
            //        divisibleCount++;
            //    }
            //}

            //Console.WriteLine(divisibleCount);

            //int bacteriaCount = 1;
            //for (int hour = 1; hour <= 24; hour++)
            //{
            //    bacteriaCount *= 2;
            //    Console.WriteLine(hour + ", Saat Sonunda: " + bacteriaCount);
            //}

            #endregion

            #region While Loop

            //int iterator = 1;

            //while (iterator <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    iterator++;
            //}

            //int index = 1;
            //while (index <= 10)
            //{
            //    if (index % 3 == 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //    index++;
            //}

            //int numberIndex = 1, totalSum = 0;
            //while (numberIndex <= 10) 
            //{
            //    totalSum += numberIndex;
            //    numberIndex++;
            //}
            //Console.WriteLine(totalSum);

            #endregion

            #region Example Question

            //int userInput, sumResult = 0, loopCounter, digit;

            //Console.Write("Lütfen 3 basamaklı sayı giriniz: ");
            //userInput = int.Parse(Console.ReadLine());

            //for (loopCounter = 0; loopCounter < 3; loopCounter++)
            //{
            //    digit = userInput % 10;
            //    userInput = userInput - digit;
            //    userInput = userInput / 10;
            //    sumResult += digit;
            //}

            //Console.WriteLine("Toplam: " + sumResult);

            #endregion

        }
    }
}
