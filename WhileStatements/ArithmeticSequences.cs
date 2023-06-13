namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + i;
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += 17 + (i * 33);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            int sum = 0, i = 0;

            while (i < n)
            {
                sum += a + (i * 3);
                i++;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                int term = a + ((i - 1) * d);
                sum += term;
                i++;
            }

            return sum;
        }
    }
}
