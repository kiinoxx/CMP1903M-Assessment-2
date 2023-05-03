using System;

namespace CMP1903M_A01_2223
{
    public class MathOperator
    {
        public MathCard OperatorCard { get; set; }

        public MathOperator(MathCard operatorCard)
        {
            if (operatorCard.IsOperator())
            {
                OperatorCard = operatorCard;
            }
            else
            {
                throw new ArgumentException("MathCard provided is not an operator.");
            }
        }

        public double PerformOperation(double firstNumber, double secondNumber)
        {
            switch (OperatorCard.Value)
            {
                case 1: // Addition
                    return firstNumber + secondNumber;
                case 2: // Subtraction
                    return firstNumber - secondNumber;
                case 3: // Multiplication
                    return firstNumber * secondNumber;
                case 4: // Division
                    if (secondNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return firstNumber / secondNumber;
                default:
                    throw new InvalidOperationException("Invalid operator.");
            }

        }
    }
}
