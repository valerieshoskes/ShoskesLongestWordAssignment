using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesLongestWordAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] sentenceArray = sentence.Split();
            string longestWord = "";
            int mostLetters = 0;
            foreach (string word in sentenceArray)
            {
                if (word.Length >= mostLetters)
                {
                    mostLetters = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
