﻿using System;


class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter the Number of the Table :");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + "x" + i + "=" + (num * i));
        }
        Console.ReadLine();
    }
}
