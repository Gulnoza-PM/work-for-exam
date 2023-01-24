/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*/
string[] arrayA = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrayB = new string[arrayA.Length];
void Array2(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
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
Array2(arrayA, arrayB);
PrintArray(arrayB);
