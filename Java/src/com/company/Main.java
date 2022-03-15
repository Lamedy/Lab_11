package com.company;
public class Main {
    public static void main(String[] args) {
	int LENGHT = 3;
        point[] arr1 = new point[LENGHT];
        for (int i = 0; i < LENGHT; i++)
        {
            arr1[i] = new point();
        }
        System.out.print("Odnomerny array Size = " + LENGHT + ":\n");
        for (int i = 0; i < LENGHT; i++)
        {
            arr1[i].x = i;
            arr1[i].y = i + i;
        }
        for (int i = 0; i < LENGHT; i++)
        {
            System.out.print("X = " + arr1[i].x + "\t");
            System.out.println("Y = " + arr1[i].y);
        }
        point arr2[][] = new point[LENGHT] [LENGHT];
        for (int i = 0; i < LENGHT; i++)
        {
            for (int q = 0; q < LENGHT; q++)
            {
                arr2[i][q] = new point();
            }
        }
        System.out.print("Dvymerniy array Size = " + LENGHT + "x" + LENGHT + ":\n");
        for (int i = 0; i < LENGHT; i++)
        {
            for (int q = 0; q < LENGHT; q++)
            {
                arr2[q][i].x = i + q;
                arr2[q][i].y = i + i + q + q;
            }
        }
        for (int i = 0; i < LENGHT; i++)
        {
            for (int q = 0; q < LENGHT; q++)
            {
                System.out.print("X = " + arr2[q][i].x + "\t");
                System.out.print("Y = " + arr2[q][i].y + "\n");
            }
        }
    }
}
