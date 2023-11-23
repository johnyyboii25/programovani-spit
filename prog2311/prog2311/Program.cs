//int[] array = new int[] {-12,-5,-8,-64,-250,-13 };

//int FindMax(int[] array)
//{
//	int max = array[0];
//	for (int i = 0; i < array.Length; i++)
//	{
//		if (array[i] > max)
//		{
//			max = array[i];
//		}
//	}
//	return max;
////}


//int maximum = FindMax(array);
//Console.WriteLine($"maximum is {maximum}");

int[] array = new int[] { 12, -5, -8, 64, 25, -13 };

foreach (int i in array)
{
	Console.WriteLine(i);
}

static int FindMax(int[] array)
{
	int max = array[0];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
			index = i;
		}

	}
	return index;
}


int maximum = FindMax(array);
Console.WriteLine(maximum);
