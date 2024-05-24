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
            var timeLinkedListInsert=new Stopwatch();

            #region Считываем текст(оригинал и для вставки) из файла и переводим в List
            string pathOriginalText = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-01\Text1.txt";
            string pathInsertText = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-01\О Гончарове.txt";
            
            string originalText=File.ReadAllText(pathOriginalText);
            string insertText=File.ReadAllText(pathInsertText);

            string[] originalTextWords = originalText.Split(" ");
            
            var ListOriginalWords = new List<string>(originalTextWords);
            var LinkedListOriginalWords= new LinkedList<string>(originalTextWords);
            #endregion

            #region Вставка текста в List
            timeListInsert.Start();
            ListOriginalWords.Insert(100,insertText);
            timeListInsert.Stop();
            #endregion

            #region Вставка текста в LinkedList
            timeLinkedListInsert.Start();
            LinkedListNode<string> node = LinkedListOriginalWords.Find("и");
            LinkedListOriginalWords.AddAfter(node,insertText);
            timeLinkedListInsert.Stop();
            #endregion

            #region Вывод результата
            Console.WriteLine($"Время вставки для List: {timeListInsert.Elapsed.TotalNanoseconds} нс");
            Console.WriteLine($"Время вставки для LinkedList: {timeLinkedListInsert.Elapsed.TotalNanoseconds} нс\n");
            
            if (timeLinkedListInsert.Elapsed.TotalNanoseconds< timeListInsert.Elapsed.TotalNanoseconds)
            {
                Console.WriteLine("Вставка в LinkedList работает быстрее!!!");
            }
            else if (timeLinkedListInsert.Elapsed.TotalNanoseconds > timeListInsert.Elapsed.TotalNanoseconds)
            {
                Console.WriteLine("Вставка в List работает быстрее!!!");
            }
            else
            {
                Console.WriteLine("Вставка в List и в LinkedList работают одинаково...");
            }
            #endregion
        }
    }
}
