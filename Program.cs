using System;

public class rect

{

    public static void Main()

    {





        program(7, 9, 1.5, 9.3, 2.2, 3.3, 7.0, 2.9, 3.1, 8.0);



    }

    public static void program(int x, int y, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)

    {

        if (x > x1 && x < x2 && y > y1 && y < y2)

        {

            if (x > x3 && x < x4 && y > y3 && y < y4)

            {

                Console.WriteLine("True");

            }

        }

        else

            Console.WriteLine("False");

    }
}
