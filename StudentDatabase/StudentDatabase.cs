using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    internal class StudentDatabase
    {
        public StudentDatabase()
        {
            bool isCategory;

            string[] name = { "Troy Wilson" , "Barbara Baker", "Elyas Goddard" , "Marwan Lozano" , "Anayah Church" , "Kobi Preece" , "Tamara Chase" , "Dwayne Wilder" , "Blanche Hess" };
            string[] homeTown = { "Coral" , "Grand Rapids" , "Detroit", "Lansing", "Ann Arbor", "Flint", "Kalamazoo", "Saginaw", "Bay City" };
            string[] favoritFood = { "Pizza" , "Ice Cream" , "Steak", "Waffles", "Beef", "Bacon", "Chicken", "Corned beef", "Pancakes" };
           
            string[] home =  { "home town", "home", "town" , "h" , "t" };
            string[] food = { "favorit food", "favorit", "food" , "f"};

            uint intInput = GetInput.GetInt(name.Length);
            
            do
            {
                Console.Write($"Student {intInput} is {name[intInput - 1]}. What would you like to know? Enter \"hometown\" or \"favorite food\" : ");
                string strInput = Console.ReadLine().ToLower().Trim();

                if(home.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} is from {homeTown[intInput - 1]}");
                    isCategory = true;
                }
                else if(food.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} favorit food is {favoritFood[intInput - 1]}");
                    isCategory = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry that is not a valid input");
                    isCategory = false;
                } 
            } while(!isCategory);
        }
    }
}
