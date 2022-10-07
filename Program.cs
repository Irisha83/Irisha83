// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input a first number: ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int b=Convert.ToInt32(Console.ReadLine());

// if (a > b)
// Console.WriteLine("max: " +  a + " , min: " + b);

// else 
// Console.WriteLine("max: " +  b + " , min: " + a); 

// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 
//  Console.WriteLine("Input a first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a second number: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if(max < b)
//   {
//  max = b;
//   }  
//     if (max < c)
//     max = c;

// Console.WriteLine("Oure max is: " + (max));

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)

// Console.WriteLine("The number is even namber");

// else 
// Console.WriteLine("The number is not even namber");

// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;
 
while (current <=n)
    {
        if (current % 2 == 0)
        Console.Write(current + " ");
        current = current + 1;
    }
