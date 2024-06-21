using System;

public class Program
{
    public static void Main()
    {
      
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

  
        int[] arr = new int[size];

     
        Console.WriteLine($"Enter {size} elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

       
        InsertionSort(arr);

    
        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
           
        }
        Console.ReadLine();
    }
}

