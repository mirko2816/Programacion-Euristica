// https://codeforces.com/problemset/problem/116/A

int n = int.Parse(Console.ReadLine());
int total = 0;
int totalMax = 0;

for (int i = 0; i < n; i++)
{
    int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int salen = nums[0];
    int entran = nums[1];

    total = total - salen;
    total = total + entran;

    if (total > totalMax)
    {
        totalMax = total;
    }
}

Console.WriteLine(totalMax);

