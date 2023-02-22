int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
}
void Product(int[] array)
{
    int product = 1;
    for (int i = 0; i < array.Length; i++)
    {
        product=array[i]*product;
    }
    Console.WriteLine(product);
}
PrintArray(numbers);
Console.WriteLine();
Product(numbers);