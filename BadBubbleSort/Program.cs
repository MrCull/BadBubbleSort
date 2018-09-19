using System;
public class z
{
    public static void Main(string[] args)
    {
        int[] a = { 3, 5, 0, 2 };
        int t;

        foreach (int aa in a)
            Console.Write(aa + " ");
        Console.WriteLine("\n- - - -");


        for (int p = 0; p <= a.Length - 2; p++)
        {

            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }

            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.WriteLine();
        }


        Console.WriteLine("- - - -");

        foreach (int aa in a)
            Console.Write(aa + " ");
        Console.WriteLine();

    }
}
