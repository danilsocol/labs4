using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks.Dataflow;

namespace labs4
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите текст!");
            string Text = Console.ReadLine();

            string NoPunctuation = Text.Replace(",", "").Replace(".", "").Replace("!", "");

            Console.WriteLine("\nПервое задние");
            Console.WriteLine(onejob(Text));

            Console.WriteLine("\nВторое задние");
            Console.WriteLine(twojob(Text));

            Console.WriteLine("\nТретье задание");
            Console.WriteLine(threejob(NoPunctuation));

            Console.WriteLine("\nЧетвёртое задание");
            string LongWord = fourjob(NoPunctuation);
            Console.WriteLine(LongWord);

            Console.WriteLine("\nПятое задание");
            Console.WriteLine(fivejob(LongWord));
        }


        static int onejob(string Text)
        {
            return Text.Count(char.IsPunctuation);
        }



        static string twojob(string Text)
        {
            string[] str = Text.Split(new char[] { '.' });
            for (int a = 1; a < str[a].Length; a++)
            {
                str[a] = str[a].Remove(0,1);
            }
            for (int b = 0; b < str.Length; b++)
            {
                Console.WriteLine(str[b]);

            }
            return "";
        }



        static string threejob(string NoPunctuation)
        {

            string[] word = NoPunctuation.Split(' ');

            string EveryTwo = "";
            for (int c = 0; c < word.Length; c++)
            {
                if (c % 2 == 0)
                {
                    EveryTwo += $"{word[c]} ";
                }
            }
            string[] EveryTwoWord = EveryTwo.Split(' ');
            return String.Join(", ", EveryTwoWord);
        }



        static string fourjob(string NoPunctuation)
        {
            string[] word = NoPunctuation.Split(' ');
            int NumLongWord = MN(NoPunctuation);
            return word[NumLongWord];

        }

        static int MN(string NoPunctuation)
        {
            string[] word = NoPunctuation.Split(' ');

            int MaxNum = 0;
            int maxIndex = 0;
            int Num;

            for (int d = 0; d < word.Length; d++)
            {


                Num = word[d].Length;
                if (Num > MaxNum)
                {
                    MaxNum = Num;
                    maxIndex = d;
                }

            }
            return maxIndex;
        }
 


        static string fivejob(string LongWord)
        {
            int MaxNum = LongWord.Length;

            if (MaxNum % 2 == 0)
            {
                int x = MaxNum / 2;
                LongWord = LongWord.Remove(0, x);
                return LongWord;
            }
            else
            {
                int y = MaxNum / 2;
                LongWord = LongWord.Insert(y,"*");
                return LongWord;
            }
        }

    }
}

        