using System.Diagnostics;

namespace Exercise_13_06_01
{

//    Задание 13.6.1
//Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.
    internal class Program
    {
        static void Main(string[] args)
        {
            var timeListInsert=new Stopwatch();
            #region Считываем текст(оригинал и для вставки) из файла и переводим в List
            string pathOriginalText = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-01\Text1.txt";
            string pathInsertText = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-01\О Гончарове.txt";
            
            string originalText=File.ReadAllText(pathOriginalText);
            string insertText=File.ReadAllText(pathInsertText);

            string[] originalTextWords = originalText.Split(" ");
            
            var ListOriginalWords = new List<string>(originalTextWords);
            
            #endregion


            timeListInsert.Start();
            ListOriginalWords.Insert(1,insertText);
            timeListInsert.Stop();

            Console.WriteLine($"Время вставки для List: {timeListInsert.Elapsed.TotalNanoseconds} нс");

        }
    }
}
