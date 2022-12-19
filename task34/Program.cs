void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

Console.Clear();
int n = new Random().Next(1, 10);
int[] array = new int[n];
int num = 0;
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
	if(array[i]%2 == 0)
		num= num + 1;
}

Console.WriteLine($"Чётных чисел в массиве {num}");