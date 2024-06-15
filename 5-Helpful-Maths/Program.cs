using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();

        List<int> ints = input
                            .Where(c => char.IsDigit(c))    // Filtra solo los caracteres numéricos
                            .Select(c => Convert.ToInt32(c.ToString())) // Convierte cada carácter a su valor entero
                            .ToList();

        ints.Sort();

        string finalString = string.Join("+", ints);

        Console.WriteLine(finalString);
    }
}