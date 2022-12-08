
int [] array = new int [8];

void FillArray(int[]array)
{
    int length = array.Length;
    for (int index = 0; index < length; index++)
    {
        array[index]=new Random().Next(0,2);
        Console.Write(array[index]);
    }
        return;
}
FillArray(array);

