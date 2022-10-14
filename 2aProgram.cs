using System;

public class Countstring
{
    public static void Main()
    {
        String str1 = "Supercalifragilisticexpialidocious";
        int count = 0;

        for (int n = 0; n < str1.Length; n++)
        {
            if (str1[n] != ' ')
                count++;
        }

        Console.WriteLine("Total number of characters in a string: " + count);
    }
}

