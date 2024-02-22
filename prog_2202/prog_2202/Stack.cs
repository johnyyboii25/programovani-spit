class Stack
{
	int[] array;
	int LastIndex;

	public Stack(int capacity)
	{
		array = new int[capacity];
	}

	public void Add(int value)
	{
		array[LastIndex++] = value;
		LastIndex++;
		Console.WriteLine();
	}

	public int Get()
	{
		int value = array[LastIndex];
		LastIndex--;
		Console.WriteLine();
		return value;
	}
}
