

void InputArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.NextDouble();
}

Console.Clear();
int n = new Random().Next(1, 10);
double[] array = new double[n];
InputArray(array);
double max = array[0];
double min = array[0];
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if(array[i]<min)
        min=array[i];
    else if(array[i]>max)
        max=array[i];
}

Console.WriteLine(max-min);