// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int  N = int.Parse(Console.ReadLine());
int b = 0;
    if (N > 100)
    {
        while (N > 1000)
    
        {
           N = N / 10; 
        }
        Console.WriteLine($"вот третье число введеной цифры {b = N % 10}");
    }
    else
    {
        Console.WriteLine("нет третьей цифры!");
    }
  
	