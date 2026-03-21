public static class PrimeSieve
{
    public static bool GenerateSieve(int n)
    {
        bool[] is_prime = new bool[n + 1];
        Array.Fill(is_prime, true);
        is_prime[0] = is_prime[1] = false;

        for (int p = 2; p * p <= n; p++)
        {
            if (is_prime[p])
            {
                for (int multiple = p * p; multiple <= n; multiple += p)
                {
                    is_prime[multiple] = false;
                }
            }
        }

        return is_prime[n];  // return whether n itself is prime
    }
}

public static class Primebuzz
{
    public static void checkPrimebuzz(int n)
    {
        bool isPrime = PrimeSieve.GenerateSieve(n);
        bool isBuzz = n % 5 == 0;

        if (isPrime && isBuzz)
            Console.WriteLine("Primebuzz");
        else if (isBuzz)
            Console.WriteLine("Buzz");
        else if (isPrime)
            Console.WriteLine("Prime");
        else
            Console.WriteLine(n);
    }
}
