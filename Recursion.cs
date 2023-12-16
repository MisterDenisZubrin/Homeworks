using System;

class Task1 {
    static void Main() {
        Console.WriteLine("Введите два числа:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        PrintNaturalNumbersInRange(m, n);
    }

    static void PrintNaturalNumbersInRange(int start, int end) {
        if (start <= end) {
            Console.Write(start + " ");
            PrintNaturalNumbersInRange(start + 1, end);
        }
    }
}

class Task2 {
    static void Main() {
        int m = 3;
        int n = 4;
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int AckermannFunction(int m, int n) {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0) {
            return AckermannFunction(m - 1, 1);
        }
        else {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

class Task3 {
    static void Main() {
        int[] impr_massive = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(impr_massive, impr_massive.Length - 1);}
    static void PrintArrayReverse(int[] arr, int index) {
        if (index < 0) { 
            return; 
        }
    Console.WriteLine(arr[index]);
    PrintArrayReverse(arr, index - 1);}
}