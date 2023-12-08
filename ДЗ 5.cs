// Задача 1

Random random = new Random();
int[,] arr = new int[3, 5]; 

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 5; j++) {
        arr[i, j] = random.Next(1, 10); 
    }
}

Console.WriteLine("Введите позицию (номер строчки и столбика пожалуйста):");
int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());

if (row >= 0 && row < 3 && col >= 0 && col < 5) {
    int result = arr[row, col];
    Console.WriteLine("Значение элемента: " + result);
}
else {
    Console.WriteLine("Такого элемента не существует"); 
}

// Задача 2

Random random = new Random();
int[,] arr2 = new int[2, 3];

for (int a = 0; a < 2; a++) {
    for (int b = 0; b < 3; b++) {
        arr2[a, b] = random.Next(1, 10); 
    }
}

    
    Console.WriteLine("Исходный массив:");
for (int c = 0; c < 2; c++) {
    for (int d = 0; d < 3; d++) {
        Console.Write(arr2[c, d] + " ");
    }
    Console.WriteLine();
}

for (int e = 0; e < 3; e++) {
    int temp = arr2[0, e];
    arr2[0, e] = arr2[1, e];
    arr2[1, e] = temp;
}

Console.WriteLine("Измененный массив:");
for (int f = 0; f < 2; f++) {
    for (int g = 0; g < 3; g++) {
        Console.Write(arr2[f, g] + " ");
    }
    Console.WriteLine();
}

// Задача 3

int rows = 4;
int numbers = 3;
int[,] matrix = new int[rows, numbers];
Random rand = new Random();

for (int x = 0; x < rows; x++) {
    for (int y = 0; y < numbers; y++) {
        matrix[x, y] = rand.Next(1, 10);
        Console.Write(matrix[x, y] + "\t");
    }
    Console.WriteLine();
}

int[] rowSums = new int[rows];
for (int m = 0; m < rows; m++) {
    int min1 = Int32.MaxValue;
    int min2 = Int32.MaxValue;

    for (int n = 0; n < numbers; n++) {
        if (matrix[m, n] < min1) {
            min2 = min1;
            min1 = matrix[m, n];
        }
        else if (matrix[m, n] < min2) {
            min2 = matrix[m, n];
        }
    }

    rowSums[m] = min1 + min2;
}

int minSum = rowSums[0];
int minRow = 0;
for (int z = 1; z < numbers; z++) {
    if (rowSums[z] < minSum) {
        minSum = rowSums[z];
        minRow = z;
    }
}

Console.WriteLine($"Строка с суммой наименьших элементов: {minRow + 1}");
