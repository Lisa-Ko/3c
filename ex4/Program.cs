int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
}
void FindKube(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        {   if(array[i] % 2 ==0)
            {array[i] = array[i]*array[i]*array[i];
            Console.WriteLine(array[i]);
            }
        }
    }
}
PrintArray(numbers);
Console.WriteLine();
FindKube(numbers);