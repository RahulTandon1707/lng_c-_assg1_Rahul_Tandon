namespace assignmentmethods
{
    public class methods
    {
        static public void calculateCube()
        {
            Console.WriteLine("Enter the number to get cube from 1 till the number:-");
            int numberForCube = int.Parse(Console.ReadLine());
            Console.WriteLine($"The cube of numbers from 1 till {numberForCube} are");
            for (int i = 1; i <= numberForCube; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }

        static public void printMultiplicationTable()
        {
            Console.WriteLine("Enter the number to get multiplication table from 1 till the number:-");
            int numberForMultiplication = int.Parse(Console.ReadLine());
            Console.WriteLine("The multiplication table from 1 till n are:-");
            for (int i = 1; i <= numberForMultiplication; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Table of {i}:-");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");

                }
            }
        }


        static public void isEligibleToVote()
        {
            Console.WriteLine("Enter the age:-");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }

        static public void isEligibleForAdmission()
        {
            Console.WriteLine("Enter your marks in Physics:-");
            int marksInPhysics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in Chemistry:-");
            int marksInChemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in Mathematics:-");
            int marksInMaths = int.Parse(Console.ReadLine());
            if (marksInPhysics >= 55 && marksInChemistry >= 50 && marksInMaths >= 65)
            {
                int totalMarks = marksInPhysics + marksInChemistry + marksInMaths;
                if (totalMarks >= 180)
                {
                    Console.WriteLine("Eligible For Admission");
                }
                else
                {
                    Console.WriteLine("Not Eligible For Admission");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible For Admission");
            }
        }
    }
}