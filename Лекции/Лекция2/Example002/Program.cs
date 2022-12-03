// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2>result) result=arg2;
//     if (arg3>result) result=arg3;
//     return result;
// }

// int [] array = new {1,2,3,14,5,6,7,8,9}; 
// int index = 1;
// int max = array[0];
// while (index<array.Length)
//     {
//     if (array[index]>max)
//         {
//         max=array[index];
//         }
//         index++;

//     }

// Console.WriteLine (max);
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index =0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++; 
    }
} 

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index<count)
    {
        if (collection[index]==find)
        {
            position=index;
        break;
        }
        index++;
    }
    return position;
}



int[]array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos =  IndexOf(array, 4);
Console.WriteLine(pos);
