using System;
using System.Text;
using System.IO;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 41 - "Сортировка подсчетом"
    /// (Время: 2 сек. Память: 128 Мб Сложность: 29%)
    /// 
    /// На планете «Аурон» атмосфера практически отсутствует, поэтому она известна своими перепадами температур в различных точках.
    /// Известно, что эти перепады колеблются от -100 до 100 градусов.
    /// Нашим специалистам удалось выяснить значения температур в N точках этой планеты.
    /// К сожалению, эти значения вычислены с большими погрешностями, поэтому их решили округлить до целых чисел.
    /// Хотелось бы наглядно видеть участки с повышенной и пониженной температурой.
    /// Вам требуется помочь. Вы должны упорядочить температуры участков по неубыванию.
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT задано натуральное число N - количество участков (N ≤ 10^6).
    /// Во второй строке через пробел записаны целые значения температур этих участков, не превосходящие 100 по абсолютной величине.
    /// 
    /// Выходные данные
    /// В единственную строку выходного файла OUTPUT.TXT нужно вывести разделенные пробелом значения температур
    /// всех известных участков, которые должны следовать друг за другом в порядке неубывания.
    /// </summary>
    public class Task0041
    {
        public static void Main()
        {
            GetInputData(out var array);
   
            var result = Solve(array);
   
            PrintResult(result);
        }
   
        private static void GetInputData(out int[] array)
        {
            var sr = new StreamReader("input.txt");
           
            var n = int.Parse(sr.ReadLine());
               
            array = new int[n];
            for (var i = 0; i < n; i++)
            {
                array[i] = ReadNumber(sr);
            }
           
            sr.Close();
        }
   
        public static int[] Solve(int[] array)
        {
            var counts = new int[201];
   
            foreach (var number in array)
            {
                counts[number + 100]++;
            }
               
            return counts;
        }
   
        private static void PrintResult(int[] result)
        {
            var sw = new StreamWriter("output.txt");
           
            for (var i = 0; i <= 200; i++)
            {
                for (var j = 1; j <= result[i]; j++)
                {
                    sw.Write($"{i - 100} ");
                }
            }
           
            sw.Close();
        }
        
        private static int ReadNumber(StreamReader sr)
        {
            var number = new StringBuilder();
   
            while (true)
            {
                var symbol = (char)sr.Read();
   
                if (char.IsDigit(symbol) || symbol == '-')
                {
                    number.Append(symbol);
                    continue;
                }
   
                if (number.Length != 0 || symbol == '\r')
                {
                    break;
                }
            }
   
            return int.TryParse(number.ToString(), out var result)
                       ? result
                       : throw new FormatException("Not found number in console line");
        }
    }
}