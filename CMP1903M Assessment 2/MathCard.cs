using System;

namespace CMP1903M_A01_2223
{
    public class MathCard : Card
    {
        public MathCard(int value, int suit) : base(value, suit)
        {
        }

        public override string GetCard()
        {
            if (Suit == 5)
            {
                return GetOperator();
            }
            else
            {
                return base.GetCard();
            }
        }
        public double? PerformOperation(double num1, double num2)
        {
            switch (Value)
            {
                case 1:
                    return num1 + num2;
                case 2:
                    return num1 - num2;
                case 3:
                    return num1 * num2;
                case 4:
                    return num2 != 0 ? num1 / num2 : (double?)null;
                default:
                    return null;
            }
        }
        public bool IsOperator()
        {
            return Suit == 5;
        }

        private string GetOperator()
        {
            switch (Value)
            {
                case 1:
                    return "Addition (+)";
                case 2:
                    return "Subtraction (-)";
                case 3:
                    return "Multiplication (*)";
                case 4:
                    return "Division (/)";
                default:
                    return "";
            }
        }
    }
}
