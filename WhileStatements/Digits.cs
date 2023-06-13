namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            ulong num = n;

            while (num != 0)
            {
                ulong digit = num % 10;
                sum += digit;
                num /= 10;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong product = 1;
            ulong num = n;
            if (num != 0)
            {
                while (num != 0)
                {
                    ulong digit = num % 10;
                    product *= digit;
                    num /= 10;
                }

                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}
