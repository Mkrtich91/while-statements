namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long sum = 0;
            long n = 1;
            long term = 0;

            while (term <= maxTerm)
            {
                term = (a * n * n) + (b * n) + c;

                if (term <= maxTerm)
                {
                    sum += term;
                }

                n++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0;
            long n = startN;
            long i = 0;

            while (i < count)
            {
                long term = (a * n * n) + (b * n) + c;
                sum += term;
                n++;
                i++;
            }

            return sum;
        }
    }
}
