// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetHighThenZero (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            sum++;
        }
    }
    return sum;
}


void FillMassive(int [] array) 
{
    int length = array.Length;
    Console.WriteLine("Заполните массив цифрами: ");
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("В массиве [");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int mNumber = GetInput("Введите размер массива : ");
int [] array = new int [mNumber];
FillMassive(array);
Console.WriteLine($" колличество эллементов больше 0 равно --> {GetHighThenZero(array)}");