// int a = 10;
// int b = 15;
// int ?c = 20;
// bool d = a > b;
// Console.WriteLine(d);

// Логические операции
// bool a = (10<15) | (4>10);
// bool b = (10>15) | (4>10);
// Console.WriteLine((a));
// Console.WriteLine((b));

// Конструкция if..else и тернарная операция
// int a = 10;
// int b = 20;
// if (a > b)
// {
//     Console.WriteLine($"number {a} > number {b}");
// }else if (a !=b)
// {
//     Console.WriteLine(($"не равны{a} и {b}"));
// }
// else
// {
//     Console.WriteLine("ты дурак, схавал?");
// } 

// int v = 10;
// int z = 5;
// string i = v > z ? "lox" : "krasava";
// Console.WriteLine((i));

// Циклы

// for (int i = 0; i <= 4; i++)
// {
//     Console.WriteLine((i));
// }

// var a = 1;
// for (Console.WriteLine("begin cycles"); a < 4; Console.WriteLine($"a={a}"))
// {
//     a++;
// }
//
// for (int i = 1, j = 10; i < 100; i++, j++)
// {
//     Console.WriteLine($"{i*j}");
// }
// int  i = 6;
// do
// {
//     Console.WriteLine(i);
//     i--;
// } while (i > 0);

// int i = 1;
// while (i < 10)
// {
//     Console.WriteLine((i));
//     i++;
// }
// foreach(var c in "Vasya"){
//     Console.WriteLine((c));
// }
//
// for (int i = 1; i < 10; i++)
// {
//     if(i>5) break;
//     Console.WriteLine(i);
// }
// for (int i = 10; i < 100; i++)
// {
//     if(i % 2!=0)continue;
//     Console.WriteLine((i));
// }
// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.Write($"{i*j}\t");
//     }
//     Console.WriteLine();
// }


// Массивы
// int[] arr = new int[4];
// int[] arr2 = new int[4]{1,2,3,4};
//
// string[] cars = { "BMV", "LADA","Toyota" };
// Console.WriteLine(cars[^1]);
// int[] boys = { 1, 2, 3 };
// foreach (var i in boys)
// {
//     Console.WriteLine((i));
// }
// int [,] people = {{1,2,3}, {4,5,6}};
// foreach (var i in people)
// {
//     Console.WriteLine($"{i}");
// }
// int [,] numbers = {{1,2,3},{4,5,6}};
// int rows = numbers.GetUpperBound(0)+1;
// int colums = numbers.Length/rows;
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < colums; j++)
//     {
//         Console.Write($"{numbers[i,j]}\t");
//     }
//     Console.WriteLine();
// }
// int[,,] mas = { { { 1, 2 },{ 3, 4 } }, 
//     { { 4, 5 }, { 6, 7 } }, 
//     { { 7, 8 }, { 9, 10 } }, 
//     { { 10, 11 }, { 12, 13 } }
// };
// foreach (var i in mas)
// {
//     Console.WriteLine($"({i})");
// }