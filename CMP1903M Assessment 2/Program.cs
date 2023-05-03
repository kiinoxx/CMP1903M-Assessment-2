using System;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();

            Console.WriteLine("Welcome to the card-based arithmetic application!");
            Console.WriteLine("The pack contains {0} cards.", pack.GetPack().Count);
            Console.WriteLine();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1: Instructions");
                Console.WriteLine("2: Deal 3 cards (2 numbers + operator)");
                Console.WriteLine("3: Quit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ShowInstructions();
                            break;
                        case 2:
                            DealMathCards(pack);
                            break;
                        case 3:
                            exit = true;
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            }
        }

        private static void ShowInstructions()
        {
            Console.WriteLine("\nInstructions:");
            Console.WriteLine("The application will deal 3 cards. Two cards represent numbers, and the third card represents an arithmetic operator.");
            Console.WriteLine("You will be asked to enter the result of the operation.");
            Console.WriteLine("The application will then tell you if your answer is correct or not.");
            Console.WriteLine();
        }

        private static void DealMathCards(Pack pack)
        {
            pack.ShuffleCardPack();
            MathCard[] cards = pack.DealMathCards();

            Console.WriteLine("Dealing 3 cards:");
            Console.WriteLine("{0} {1} {2}", cards[0].GetCard(), cards[1].GetCard(), cards[2].GetCard());

            Console.Write("Enter the result: ");
            double userAnswer;
            if (double.TryParse(Console.ReadLine(), out userAnswer))
            {
                MathOperator mathOperator = new MathOperator(cards[1]);
                double correctAnswer = mathOperator.PerformOperation(cards[0].Value, cards[2].Value);
                if (Math.Abs(userAnswer - correctAnswer) < 0.001)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is {0}.", correctAnswer);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.WriteLine();
        }
    }
}
