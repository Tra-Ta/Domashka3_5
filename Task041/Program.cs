// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter the number of digits ->");
int numberDigits =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the digits ->");

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Counting(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++; 
    }
    return count;
}
int[] arr = CreateArrayRndInt(numberDigits);
PrintArray(arr);
int res =Counting(arr);
Console.WriteLine(res);
