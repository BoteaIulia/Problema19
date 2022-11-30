using System;

public static class Globals
{
    internal static void Main()

    {
        Console.Write("Determinati daca numarul X e format doar cu doua cifre care se pot repeta");

        Console.Write("\n");

        int x = 0;
        int a = x % 10;
        int b = -1;
        int ok = 1;

        Console.Write("x = ");
        x = Convert.ToInt32(Console.ReadLine());

        x = x / 10;
        while (x > 0)
        {
            if (b == -1)
            {
                if ((x % 10) != a)
                {
                    b = x % 10;
                }
            }
            else
            {
                if (x % 10 != b && x % 10 != a)
                {
                    ok = 0;
                }
            }
            x = x / 10;
        }
        if (ok == 0)
        {
            Console.Write("NU");
        }
        else
        {
            Console.Write("DA");
        }
    }
}
