//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array= new string [4] { "Hello", "2", "world", ":-)" };
string[] NewArray= new string [array.Length];
void TwoArray(string [] array, string [] NewArray)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            NewArray[count]=array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
TwoArray(array, NewArray);
PrintArray (NewArray);