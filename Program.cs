namespace Topic_5._2___If_and_Else_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1

            int grade;

            Console.WriteLine("What was your grade?");
            Int32.TryParse(Console.ReadLine(), out grade);

            Console.WriteLine("");

            if (grade >= 50)
            {
                Console.WriteLine("You passed! Congratulations.");
            }

            else
            {
                Console.WriteLine("Better luck next time!");
            }

            //Format:
            //if (condition)
            //{
            // block of code to be executed if the condition is True
            //}
            //else
            //{
            // block of code to be executed if the prior condition is not True
            //}

            int age;

            Console.WriteLine("");
            Console.WriteLine("How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("");

            if (age >= 16)
            {
                Console.WriteLine("The roads are not safe!");
            }

            else
            {
                Console.WriteLine("I can drive without fear!");
            }

            //part 2

            int bet;

            Console.WriteLine("");
            Console.WriteLine("How much would you like to bet?");

            Console.WriteLine("");

            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet: " + bet.ToString("C"));
            }

            else
            {
                Console.WriteLine("That is not a valid number.");
                Console.WriteLine("Your bet will be set to the minimum of $1.00.");
                bet = 1;
            }

            Console.WriteLine("");

            //part 3

            int grade2;

            Console.WriteLine("What was your grade?");
            Int32.TryParse(Console.ReadLine(), out grade2);
            Console.WriteLine("");

            if (grade2 < 50)
            {
                Console.WriteLine("That is an F!");
            }

            else if (grade2 <= 65)
            {
                Console.WriteLine("That is a D!");
            }

            else if (grade2 <= 75)
            {
                Console.WriteLine("That is a C!");
            }

            else if (grade2 <= 85)
            {
                Console.WriteLine("That is a B!");
            }

            else if (grade2 > 85)
            {
                Console.WriteLine("That is an A!");
            }

            //programming tasks

            //task 1

            string answer;

            Console.WriteLine("");
            Console.WriteLine("What is the birthstone of March?");
            Console.WriteLine("");
            Console.WriteLine("\ta)\tAmethyst");
            Console.WriteLine("\tb)\tOnyx");
            Console.WriteLine("\tc)\tAquamarine");
            Console.WriteLine("\td)\tSapphire");
            Console.WriteLine("");
            Console.Write("Your answer: ");

            answer = Console.ReadLine();

            Console.WriteLine("");

            if (answer.ToLower() == "a")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Amethyst is the birthstone of February!");
            }
            else if (answer.ToLower() == "a)")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Amethyst is the birthstone of February!");
            }

            else if (answer.ToLower() == "b")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Onyx is not the birthstone of any month!");
            }
            else if (answer.ToLower() == "b)")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Onyx is not the birthstone of any month!");
            }

            else if (answer.ToLower() == "c")
            {
                Console.WriteLine("That is correct!");
                Console.WriteLine("March's birthstone is Aquamarine!");
            }
            else if (answer.ToLower() == "c)")
            {
                Console.WriteLine("That is correct!");
                Console.WriteLine("March's birthstone is Aquamarine!");
            }

            else if (answer.ToLower() == "d")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Sapphire is the birthstone of September!");
            }
            else if (answer.ToLower() == "d)")
            {
                Console.WriteLine("Incorrect! The correct answer is: c)");
                Console.WriteLine("Sapphire is the birthstone of September!");
            }

            //task 2

            Console.ReadLine();
        }
    }
}
