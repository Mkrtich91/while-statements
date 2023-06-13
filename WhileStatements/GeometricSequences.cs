namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            uint term = a;
            uint i = 0;

            while (i < n)
            {
                sum += term;
                term *= r;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint commonRatio = 3;

            uint sum = 0;
            uint term = firstTerm;
            uint i = 0;

            while (i < n)
            {
                sum += term;
                term *= commonRatio;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint term = a;
            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;
            uint term = a;

            while (count < n)
            {
                if (term >= minTerm)
                {
                    break;
                }

                term *= r;
                count++;
            }

            return n - count;
        }
    }
}
