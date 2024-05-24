using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace Exercise_13_06_02
{
//    Задание 13.6.2
//Ваша задача — написать программу, которая позволит понять, какие 10 слов чаще всего встречаются в тексте.
    internal class Program
    {
        static void Main(string[] args)
        {
            var place = 1;
            string pathOriginalText = @"D:\Programming\Skillfactory\C#_projects\Module_13\FinalExercise\FinalExercise\Exercise-13-06-02\Text1.txt";
            string originalText=File.ReadAllText(pathOriginalText);
            var noPunctuationText = new string(originalText.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] text = noPunctuationText.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsRepeat=new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (wordsRepeat.ContainsKey(word))
                {
                    wordsRepeat[word]++;
                }
                else
                {
                    wordsRepeat[word] = 1;
                }
            }
           
            var sortedWordsRepeat=wordsRepeat.OrderByDescending(x => x.Value);                    
            var topTenWords=sortedWordsRepeat.Take(10).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var topList in topTenWords)
            {
                Console.WriteLine($"{place} место:   Слово'{topList.Key}' - встречается {topList.Value} раз");
                place++;
            }








        }
    }
}
