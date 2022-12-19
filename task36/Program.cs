

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

Console.Clear();
int n = new Random().Next(1, 10);
int[] array = new int[n];
int sum = 0;
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 1; i < array.Length; i=i+2)
{
	sum= sum + array[i];
}

Console.WriteLine(sum);