using static StudentDatabase.GlobalVariables;

namespace StudentDatabase
{
    internal class StudentDatabase
    {
        public StudentDatabase()
        {
            bool isCategory;

            uint intInput = GetInput.GetInt();
            do
            {
                Console.Write($"Student {intInput} is {name[intInput - 1]}. What would you like to know? Enter \"hometown\" or \"favorite food\" : ");
                string strInput = Console.ReadLine().ToLower().Trim();

                if(GlobalVariables.home.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} is from {homeTown[intInput - 1]}.");
                    isCategory = true;
                }
                else if(food.Contains(strInput))
                {
                    Console.WriteLine($"{name[intInput - 1]} favorit food is {favoritFood[intInput - 1]}.");
                    isCategory = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry that is not a valid category.");
                    isCategory = false;
                } 
            } while(!isCategory);
        }
    }
}
