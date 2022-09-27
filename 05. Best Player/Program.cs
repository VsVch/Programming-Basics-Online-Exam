using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string newName = Console.ReadLine();
            int newScore = 0;
            string maxMane = string.Empty;
            int maxScore = 0;

            while (newName != "END")
            {
                
                newScore = int.Parse(Console.ReadLine());
               

                if (newScore > maxScore)
                {
                    maxScore = newScore;
                    maxMane = newName;
                }

                if (newScore >= 10)
                {
                    break;
                }
                newName = Console.ReadLine();
                //newName = Console.ReadLine();

            }


            Console.WriteLine($"{maxMane} is the best player!");

            if (maxScore >= 3)
            {
                
                Console.WriteLine($"He has scored {maxScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxScore} goals.");
            }

        }
    }
}
