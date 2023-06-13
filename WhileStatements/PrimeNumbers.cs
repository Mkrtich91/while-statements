namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            uint i = 2;
            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return 0;
            }

            while (n >= 2)
            {
                if (IsPrimeNumber(n))
                {
                    return n;
                }

                n--;
            }

            return 0;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0;
            uint primesFound = 0;
            uint currentNumber = n;

            while (currentNumber > 0 && primesFound < count)
            {
                if (IsPrimeNumber(currentNumber))
                {
                    sum += currentNumber;
                    primesFound++;
                }

                currentNumber--;
            }

            return sum;
        }
    }
}
