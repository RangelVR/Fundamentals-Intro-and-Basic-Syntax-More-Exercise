int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
	if (n1 >= n2 && n1 >= n3)
	{
		Console.WriteLine(n1);
		n1 = int.MinValue;
	}
	else if (n2 >= n1 && n2 >= n3)
	{
		Console.WriteLine(n2);
		n2 = int.MinValue;
	}
	else if (n3 >= n1 && n3 >= n2)
	{
		Console.WriteLine(n3);
		n3 = int.MinValue;
	}
}