using static StudentDatabase.GlobalVariables;

namespace StudentDatabase
{
    internal class StudentDatabase
    {
        public StudentDatabase()
        {

            uint intInput = GetInput.GetInt();

                Console.Write($"Student {intInput} is {name[intInput - 1]}. What would you like to know? Enter \"Hometown\" or \"Favorite Food\" : ");
                string strInput = Console.ReadLine().ToLower().Trim();

                if(home.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} is from {homeTown[intInput - 1]}.");
                }
                else if(food.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} favorit food is {favoritFood[intInput - 1]}.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry that is not a valid category.");
                } 
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}