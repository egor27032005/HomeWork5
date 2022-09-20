Console.Clear();

int x=0;
int[] CreateArrayRndlnt(int size, int min,int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        array[i]= rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        if (i<array.Length - 1) Console.Write($"{array[i]}. ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr =CreateArrayRndlnt(16, 100, 999);
for (int j =0; j<arr.Length; j++)
   {
    if (arr[j]%2==0)
    x=x+1;
   }
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("четных чисел: "+ x);

