Console.Clear();

double max=0;
double min=10000000;
double x;
double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i=0; i<size; i++)
    {
        array[i]= Math.Round(rnd.NextDouble(), 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        if (i<array.Length - 1) Console.Write($"{array[i]}. ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
double[] arr =CreateArrayRndDouble(10);
for (int j =0; j<arr.Length; j=j+1)
   {
    if(arr[j]<min)
    min=arr[j];
    if(arr[j]>max)
    max=arr[j];

   }
x=max-min;
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Разность максимума и минимума: "+x);