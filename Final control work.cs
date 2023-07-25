
string[] CreateArray()
{
    Console.WriteLine("Введите Первоначальный массив через пробел, по окончании ввода нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null)
    {
        enterSymbols = "";
    };
    char[] separators = new char[] { ',', ' ' };
    string[] array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

void CreateNewArray(string[] tempArray, string[] array2)
{
    int count = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i].Length <= 3)
        {
            array2[count] = tempArray[i];
            count++;
        }
    }
}
void PrintArray(string[] tempArray)
{
    for (int i = 0; i < tempArray.Length; i++)
    {
        Console.Write($"{tempArray[i]} ");
    }
    Console.WriteLine();
}

string[] tempArray = CreateArray();
string[] array2 = new string[tempArray.Length];

CreateNewArray(tempArray, array2);
System.Console.WriteLine();
PrintArray(array2);
