public static class FibBuzz
{
    public static bool IsFib(int n)
    {
        if (n<0) return false;

        int root1 = (int)Math.Sqrt((5*n*n)+4);
        int root2 = (int)Math.Sqrt((5*n*n)-4);

        if ((root1*root1==((5*n*n)+4)) || (root2*root2==((5*n*n)-4))) return true;
        else return false;
    }

    public static void IsFibBuzz(int n)
    {
        for (int i=1;i<=n;i++) 
        {
            if (IsFib(i)==true && i%7!=0) Console.WriteLine("Fib");
            else if (IsFib(i)==true && i%7==0) Console.WriteLine("FibBuzz");
            else if (IsFib(i)==false && i%7==0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }
}