//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
System.Console.WriteLine("Input number M:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N:");
int n = Convert.ToInt32(Console.ReadLine());
void F(int m, int n)
{
  if (m != n)
  {
    if (m > n)
    {
      System.Console.Write(m + " ");
      F(m - 1, n);

    }
    else
    {
      System.Console.Write(m + " ");
      F(m + 1, n);


    }

  }
  else
  {
    System.Console.Write(m + " ");
  }

}

F(m, n);
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Input number M:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N:");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if ((m > 0) && (n == 0))
  {
    return Akkerman(m - 1, 1);
  }
  else if ((m > 0) && (n > 0))
  {
    return Akkerman(m - 1, Akkerman(m, n - 1));
  }
  else
  {
    return n + 1;
  }
}

System.Console.WriteLine(Akkerman(m, n));
//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
//Создание массива
int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int [] array = CreateArray(size, min, max);
//Обычная песать массива для проверки
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("    ");
}
//Печать массива наоборот с помощью рекурсии
void PrintArrayReverse(int [] array, int size)
{
  if (size > 0)
  {
    System.Console.Write(array[size-1] + " ");
    PrintArrayReverse(array, size-1);
    
  }
}

PrintArray(array);
PrintArrayReverse(array, size);
