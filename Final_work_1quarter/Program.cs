// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArrayFromString(string str)
{
  return str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

string[] FilterArray(string[] array)
{  
  string[] res = new string[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      Array.Resize(ref res, res.Length + 1);
      res[res.Length - 1] = array[i];
    }
  }
  return res;
}

void PrintArray(string[] mass)
{
  for (int i = 0; i < mass.Length; i++)
  {
    Console.Write($"{mass[i]}");
    if (i != mass.Length - 1)
    {
      Console.Write(", ");
    }
  }
}

Console.Clear();
Console.Write("Введите массив строк: ");
string str = Console.ReadLine()!;
string[] array = GetArrayFromString(str);
string[] res = FilterArray(array);
PrintArray(res);
Console.WriteLine();

