Console.Clear();

int sum=0;
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

int[] arr =CreateArrayRndlnt(10, -1000, 1000);
for (int j =1; j<arr.Length; j=j+2)
   {
    sum=sum+arr[j];
   }
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("сумма чисел на нечетных позициях: "+ sum);