using System;

namespace _5_1
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Метод разделения строки на слова\n");
            Console.WriteLine("Введите длинное предложение");

            string userInputString = Console.ReadLine();
            string[] splitedTextArray = SplitText(userInputString);

            SeparateArrayOutput(splitedTextArray);
            Console.ReadLine();

        }

        /// <summary>
        /// Разделение введённого пользователем предложения на массив, состоящий из слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns>массив string, состоящий из слов</returns>
        private static string[] SplitText(string text)
        {
            return text.Split();
        }

        /// <summary>
        /// Вывод каждого элемента массива string в отдельной строке
        /// </summary>
        /// <param name="arrayToSeparate"></param>
        private static void SeparateArrayOutput(string[] arrayToSeparate)
        {
            for (int index = 0; index < arrayToSeparate.Length; index++)
            {
                Console.WriteLine($"\n{arrayToSeparate[index]}");
            }
        }
    }
}
