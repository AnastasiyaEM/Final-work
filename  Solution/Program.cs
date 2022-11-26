// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на стране выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


void ArrayFormation(string[] arr, string[] arrNew)
{
    int strLength = 3; // макс. длина строк массива
    int k = 0; //счетчик
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= strLength) 
        {
            arrNew[k] = arr[i];
            k++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arr = new string[4] { "1232", "345", "5557", "63"}; // инициализация массива
string[] arrNew = new string[arr.Length]; // необходимый объем памяти для массива

ArrayFormation(arr, arrNew);
Console.WriteLine("Вывод массива из строк, длина которых меньше либо равно 3 символа ");
PrintArray(arrNew);

