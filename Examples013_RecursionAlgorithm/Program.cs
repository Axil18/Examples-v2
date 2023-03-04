// string[,] table = new string[2, 5];
// table[1, 2] = "word";

// for (double i = 0; i < 2; i++)
// {
//     for (double j = 0; j < 5; j++)
//     {
//         Console.WriteLine($"-{table[i , j]}-");
//     }
// }


// void PrdoubleArray(double[,] matr)
// {
//     for (double i = 0; i < matr.GetLength(0); i++)  // либо i < 3
//     {
//         for (double j = 0; j < matr.GetLength(1); j++)     // либо j < 4
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }   

// void FillArray(double[,] matr)
// {
//     for(double i = 0; i < matr.GetLength(0); i++)
//     {
//         for(double j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1, 10);

//         }

//     }
// }

// double[,] matr = new double[3, 4];
// PrdoubleArray(matr);
// FillArray(matr);
// Console.WriteLine();

// PrdoubleArray(matr);

// double Factorial(double n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);

// }

// Console.WriteLine(Factorial(100));

double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (double i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}