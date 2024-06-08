public class Program
{
    public static void Main(string[] args)
    {
        string firstInput, secondInput;
        int nroP, nroV; 

        firstInput = Console.ReadLine();
        string[] subString1 = firstInput.Split(' ');
        nroP = Convert.ToInt32(subString1[0]);
        nroV = Convert.ToInt32(subString1[1]);

        secondInput = Console.ReadLine();
        string[] subString2 = secondInput.Split(' ');
        int posicion = Convert.ToInt32(subString2[nroV-1]);

        int cont = 0;
        for (int i = 0; i < nroP; i++)
        {
            int num = Convert.ToInt32(subString2[i]);
            if (num >= posicion && num != 0)
            {
                cont ++;
            }
        }      

        Console.WriteLine(cont);
    }
}