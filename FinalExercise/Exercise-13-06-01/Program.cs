namespace Exercise_13_06_01
{

//    Задание 13.6.1
//Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.Для этого используйте уже знакомый вам StopWatch.
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Считываем текст из файла
            string path = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-01\Text1.txt";
            string originalText=File.ReadAllText(path);
            #endregion


            string[] textWords = originalText.Split(' ');
            var ListWords=new List<string>(textWords);
           
            
        }
    }
}
