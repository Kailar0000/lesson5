

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
		Console.Write($"Введите {i+1}-ой элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int x=0;
int z=0;
InputArray(array);

for (int i = 0; i < array.Length; i++)
{
	if(array[i]%2 == 0)
		x++;
	else
		z++;
}
int[] three = new int[z];
int[] four = new int[x];
x=0;
z=0;
for (int i = 0; i < array.Length; i++)
{
	if(array[i]%2 == 0)
    {
        four[x]=array[i];
		x++;
    }
	else
    {
        three[z]=array[i];
		z++;
    }
}
if(x>z)
{
    Console.WriteLine($"[{string.Join(", ", three)}]");
    Console.WriteLine($"[{string.Join(", ", four)}]");
    Console.WriteLine("Да");
}
else if(x<z)
{
    Console.WriteLine($"[{string.Join(", ", three)}]");
    Console.WriteLine($"[{string.Join(", ", four)}]");
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine($"[{string.Join(", ", three)}]");
    Console.WriteLine($"[{string.Join(", ", four)}]");
    Console.WriteLine("Возможно");
}