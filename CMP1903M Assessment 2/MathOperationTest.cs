namespace CMP1903M_A01_2223
{
    public class MathOperationTest
    {
        public void RunTests()
        {
            TestAddition();
            TestSubtraction();
            TestMultiplication();
            TestDivision();
        }

        private void TestAddition()
        {
            MathCard additionCard = new MathCard(1, 5);
            double result = additionCard.PerformOperation(3, 4) ?? 0;
            if (result == 7)
            {
                Console.WriteLine("Addition test passed");
            }
            else
            {
                Console.WriteLine("Addition test failed");
            }
        }

        private void TestSubtraction()
        {
            MathCard subtractionCard = new MathCard(2, 5);
            double result = subtractionCard.PerformOperation(7, 3) ?? 0;
            if (result == 4)
            {
                Console.WriteLine("Subtraction test passed");
            }
            else
            {
                Console.WriteLine("Subtraction test failed");
            }
        }

        private void TestMultiplication()
        {
            MathCard multiplicationCard = new MathCard(3, 5);
            double result = multiplicationCard.PerformOperation(3, 4) ?? 0;
            if (result == 12)
            {
                Console.WriteLine("Multiplication test passed");
            }
            else
            {
                Console.WriteLine("Multiplication test failed");
            }
        }

        private void TestDivision()
        {
            MathCard divisionCard = new MathCard(4, 5);
            double? result = divisionCard.PerformOperation(8, 4);
            if (result.HasValue && result.Value == 2)
            {
                Console.WriteLine("Division test passed");
            }
            else
            {
                Console.WriteLine("Division test failed");
            }
        }
    }
}
