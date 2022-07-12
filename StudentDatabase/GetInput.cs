using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    internal class GetInput
    {
        public static uint GetInt(int range)
        {
            bool isGood = false;
            uint output = 0;

            do
            {
                Console.Clear();
                Console.Write($"Welcome! Which student would you like to learn more about? Enter a number 1-{range}: ");
                string input = Console.ReadLine().ToLower().Trim();
                try
                {
                    output = uint.Parse(input);
                    if(output > 0 && output <= range)
                    {
                        isGood = true;
                    }
                    else
                    {
                        Console.WriteLine("That index is not listed");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sorry that is not a number.");
                    isGood = false;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Sorry that number is out of range.");
                    isGood = false;
                }
                if(!isGood)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            } while(!isGood);

            return output;
        }
    }
}
