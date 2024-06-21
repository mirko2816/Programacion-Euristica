// https://codeforces.com/problemset/problem/266/B

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int n = nums[0];
        int x = nums[1];

        char[] fila = Console.ReadLine().ToCharArray();

        if (n > 1)
        {
            // debe estar dentro de otro bucle que vaya de 0 a x
            for (int j = 0; j < x; j++)
            {
                for(int i = 0; i < fila.Length-1; i++)
                {
                    if(fila[i] == 'B' && fila[i+1] == 'G')
                    {
                        fila[i] = 'G';
                        fila[i+1] = 'B';
                        i++; // para que el indice salte dos posiciones enves de una
                    }
                }
            }

            Console.WriteLine(fila);
        }else
        {
            Console.WriteLine(fila);
        }
    }
}