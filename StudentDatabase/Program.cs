using static StudentDatabase.GetInput;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new StudentDatabase(); 
            } while(Continue());
        }
    }
}