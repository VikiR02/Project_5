using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    internal class Program 
    {
        /// <summary>
        /// Разделение входной строки  на слова
        /// </summary>
        /// <param name="input">строка  для деления </param>
        /// <returns> массив слов строки </returns>
        static string[] Split(string input)
        {
            string[] result = input.Split(' ');
            return result;
        }

        /// <summary>
        /// Вывод слов  
        /// </summary>
        /// <param name="str"> массив слов </param>
        static void Print(string[] str)
        {
            foreach (string s in str) Console.WriteLine(s);
        }

        /// <summary>
        /// Перестановка слов в предложении
        /// </summary>
        /// <param name="input"> предложение для перестановки </param>
        /// <returns> получившаеся предложение </returns>
        static string ReverseString(string input)
        {
            string[] stringParts = Split(input);
            string resultString = "";
            for(int i = stringParts.Length - 1; i >= 0; i--)
            {
                resultString += stringParts[i] + " ";
            }
            return resultString;
        }
        static void Main(string[] args)
        {   
            //задание 1
            Console.WriteLine("Введите предложение");
            string  str =Console.ReadLine();
            Console.WriteLine("Задание 1: разделение предложения на слова");
            Print(Split(str));
            Console.WriteLine("Зaдание 2: заданное предложение  в обратном порядке");
            Console.WriteLine(ReverseString(str));
            Console.ReadKey();
        }
        
    }
}
