public class Program
{
    public static void Main(string[] args)
    {
        string? nick = Console.ReadLine();
        List<char> subnick = new List<char>();

        foreach (char ch in nick)
        {
            if (!subnick.Contains(ch))
            {
                subnick.Add(ch);
            }
        }
        
        if(subnick.Count % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }else
        {
            Console.WriteLine("IGNORE HIM!");
        }
    }
}