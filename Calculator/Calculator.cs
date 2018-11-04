namespace Calculator
{
    public static class Calculator
    {
        public static decimal Sum(decimal firstAddend, decimal secondAddend)
        {
            return firstAddend + secondAddend;
        }

        public static decimal Sub(decimal minuend, decimal subtrahend)
        {
            return minuend - subtrahend;
        }

        public static decimal Mul(decimal firstMultiply, decimal secondMultiply)
        {
            return firstMultiply * secondMultiply;
        }

        public static decimal Div(decimal dividend, decimal devider)
        {
            return dividend / devider;
        }
    }
}
