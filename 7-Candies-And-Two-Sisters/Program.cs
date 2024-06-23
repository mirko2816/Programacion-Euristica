// https://codeforces.com/problemset/problem/1335/A

int t = int.Parse(Console.ReadLine());
int[] n = new int[t];
for (int i = 0; i < t; i++)
{
    n[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n.Length; i++)
{
    int cont = 0;
    if (n[i] > 2)
    {
        if (n[i] % 2 == 0)
        {
            cont = (n[i]/2)-1;
        }   
        else
        {
            cont = n[i]/2;
        }
        Console.WriteLine(cont);
    }
    else
    {
        Console.WriteLine(cont);
    }
}

