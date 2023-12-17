 //Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// using System;

// public class Dz_1
// {
//     static void Main()
//     {
//         while(true)
//         {
//             Console.Write("Введите 'q' или число для выхода");
//             string input = Console.ReadLine();

//             if(input == "q")
//             {
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 int sum = 0;
//                 while (number > 0) // Вычисление суммы цифр числа
//                 {
//                     sum += number % 10; // Добавление последней цифры к сумме
//                     number /= 10; // Удаление последней цифры из числа
//                 }
//                 if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//                 {
//                     Console.WriteLine("[STOP]");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Ошибка введите правильно число или 'q'");
//             }
//         }
//     }
// }


//Подсчет количества четных чисел в массиве

// using System;
// using System.Globalization;
// public class Dz_2
// {    
//     static void Main()
//     {
//         int[] numbers = new int[10]; 
//         Random random = new Random(); 
//         int evenCount = 0; 
       
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); 
//             Console.Write(numbers[i] + " "); 
//             if (numbers[i] % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }
//         Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
//     }
// }