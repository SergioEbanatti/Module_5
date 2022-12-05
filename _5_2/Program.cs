using System;

namespace _5_2
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Перестановка слов в предложении\n");
            Console.WriteLine("Введите длинное предложение");

            string userInputString = Console.ReadLine();

            Console.WriteLine(ReverseText(userInputString)); //Вывод инвертированного предложения
            Console.ReadLine();

        }

        /// <summary>
        /// Метод инвертирует предложение
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>инвертированное предложение</returns>
        private static string ReverseText(string inputText)
        {
            string[] stringParts = SplitText(inputText);
            string resultString = "";

            for (int index = stringParts.Length - 1; index >= 0; index--)
            {
                resultString += stringParts[index] + " ";
            }

            return resultString;
        }

        /// <summary>
        /// Разделение предложения на массив, состоящий из слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns>массив string, состоящий из слов</returns>
        private static string[] SplitText(string text)
        {
            return text.Split();
        }

    }
}
