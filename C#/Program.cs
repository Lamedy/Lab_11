using System;

namespace Lab_11
{
    class point
    {
    public int x; public int y;
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            const int LENGHT = 3;
            point[] arr1 = new point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                arr1[i] = new point();
            }
           System.Console.Write("Odnomerny array Size = " + LENGHT + ":\n");
            for (int i = 0; i < LENGHT; i++)
            {
                arr1[i].x = i;
                arr1[i].y = i + i;
            }
            for (int i = 0; i < LENGHT; i++)
            {
                System.Console.Write("X = " + arr1[i].x + "\t");
                System.Console.WriteLine("Y = " + arr1[i].y);
            }

            point[,] arr2 = new point[LENGHT, LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                for (int q = 0; q < LENGHT; q++)
                {
                    arr2[i, q] = new point();
                }
            }


            System.Console.Write("Dvymerniy array Size = " + LENGHT + "x" + LENGHT + ":\n");
            for (int i = 0; i < LENGHT; i++)
            {
                for (int q = 0; q < LENGHT; q++)
                {
                    arr2[q,i].x = i + q;
                    arr2[q,i].y = i + i + q + q;
                }
            }

            for (int i = 0; i < LENGHT; i++)
            {
                for (int q = 0; q < LENGHT; q++)
                {
                    System.Console.Write("X = " + arr2[q,i].x + "\t");
                    System.Console.Write("Y = " + arr2[q,i].y + "\n");
                }
            }
            System.Console.WriteLine("\nPress enter to exit");
            System.Console.ReadLine();
        }
    }
}
