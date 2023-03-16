using assignmentmethods;
namespace CS_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice!=5)
            {
                Console.WriteLine("Please enter the relevant choice from 1 to 5");
                Console.WriteLine("1. Get Cube of number till n number");
                Console.WriteLine("2. Display the multiplication table vertically from 1 to n");
                Console.WriteLine("3. Check whether a person is eligible for vote or not based on the age?");
                Console.WriteLine("4. Check whether a person is eligible for admission in a professional course based on the PCM marks?");
                Console.WriteLine("5. Quit the program");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        methods.calculateCube();
                        break;
                    case 2:
                        methods.printMultiplicationTable();
                        break;
                    case 3:
                        methods.isEligibleToVote();
                        break;
                    case 4:
                        methods.isEligibleForAdmission();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("You've entered the wrong choice");
                        break;
                }
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
            
        }

     
    }
}