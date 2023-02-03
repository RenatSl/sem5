// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

using System;
    Console.Write("n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next()%100-50;
    }
    
    Console.Write("your array: ");
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    
    int imin = 0, imax = 0;
    
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > array[imax])
            imax = i;
        if (array[i] < array[imin])
            imin = i;
    }
    Console.WriteLine("min : array[" + imin + "] = " + array[imin]);
    Console.WriteLine("max : array[" + imax + "] = " + array[imax]);
    
    int prod = 1, from = Math.Min(imin, imax)+1, to = Math.Max(imin, imax)-1;
    for (int i = from; i <= to; i++) 
    {
        prod *= array[i];
    }
    Console.WriteLine("prod from " + from + " to " + to + " : " + prod);
