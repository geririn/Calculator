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

        public static decimal[][] ArraySum(decimal[][] firstArray, decimal[][] secondArray)
        {
            var resultArray = new decimal[firstArray.Length][];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = new decimal[firstArray[i].Length];
                for (int j = 0; j < resultArray[i].Length; j++)
                {
                    resultArray[i][j] = firstArray[i][j] + secondArray[i][j];
                }
            }
            return resultArray;
        }
    }
}
