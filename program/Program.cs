string[] array1 = new string[8] { "Yes", "No", "Goodbye", "String", ":-)", "-2", ";-(", "5688" };
string[] array2 = new string[array1.Length];
void NewStringArray(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[   ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -4)
            Console.Write($"'{array[i]}', ");
        else 
            Console.Write($"{array[i]}"); 
    }
    Console.WriteLine("  ]");
}

NewStringArray(array1, array2);
Console.Write("Массив со значениями 3 и менее строк --> ");
PrintArray(array2);
