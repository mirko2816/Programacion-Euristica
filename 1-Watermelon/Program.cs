class Program 
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 2)
        {
            Console.WriteLine("NO");
        }
        else if(n % 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else 
        {
            Console.WriteLine("NO");
        }
    }
}