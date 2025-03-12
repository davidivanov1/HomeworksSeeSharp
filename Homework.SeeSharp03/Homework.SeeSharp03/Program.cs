namespace Homework.SeeSharp03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int sum = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Enter number:{i + 1}:");
                numbers[i] = int.Parse( Console.ReadLine() );
            }

            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"The result is: {sum}");

            Console.WriteLine("============================");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Ana", "Ivana", "Jovana", "Maja", "Teodora" };

            Console.WriteLine("Enter student group :");
            int group = int.Parse( Console.ReadLine() );

            if (group == 1)
            {
                Console.WriteLine("The students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (group == 2)
            {
                Console.WriteLine("The students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid group number. Please enter 1 or 2.");
            }


        }
    }
}
