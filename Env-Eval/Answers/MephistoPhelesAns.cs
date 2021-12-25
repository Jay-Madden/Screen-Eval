using System;

namespace Env_Eval.Answers
{
    public class MephistoPhelesAns : IAnswer
    {
        public void Part1()
        {
            PrintBox(int.Parse(Console.In.ReadLine()),int.Parse(Console.In.ReadLine()));
        }

        public void PrintBox(int x, int y, char letter = 'x')
        {
            string print = "";
            for (int i = 0; i < x; i++)
            {
                print += letter;
            }
            print += '\n';
            for (int i = 2; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == 0 || j == x - 1)
                    {
                        print += letter;
                    }
                    else
                    {
                        print += ' ';
                    }
                }

                print += '\n';
            }

            if (x > 1)
            {
                for (int i = 0; i < x; i++)
                {
                    print += letter;
                }
            }
            Console.Out.WriteLine(print);
        }

        public void Part2()
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Part2Input.txt");
            foreach (var x in lines)
            {
                var first = x.IndexOf(':');
                var second = x.IndexOf(':', first+1);
                var firstnum = x.Substring(0, first);
                var secondnum = x.Substring(first + 1, second - (first + 1));
                PrintBox(int.Parse(firstnum), int.Parse(secondnum),x[^1]);
            }
        }
    }
}