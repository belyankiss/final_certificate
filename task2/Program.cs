int [] array = {12, 34, 28, 5, 6, 0, 12, 43};
InverseArray(array, array.Length-1);

static void InverseArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        InverseArray(array, index-1);
    }
}
