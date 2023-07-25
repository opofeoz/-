//Задача 2. Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal elements of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal elements of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
myArray = InvertArray(myArray);
PrintArray(myArray);
