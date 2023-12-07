
//int Fibonacci(int n)
//{
//	if (n == 1)
//	{
//		return 1;
//	}
//	if (n == 0)
//	{
//		return 0;
//	}
//	int x = Fibonacci(n - 1);
//	int y = Fibonacci(n - 2);
//	return x + y;
//}

//Console.WriteLine(Fibonacci(4));

//while (true)
//{
//	long Factorial(long n)
//	{
//		if (n == 0)
//		{
//			return 1;
//		}
//		if (n == 1)
//		{
//			return 1;
//		}
//		long previous = Factorial(n - 1);
//		return previous * n;
//	}
//	bool success = long.TryParse(Console.ReadLine(), out long result);
//	Console.WriteLine(Factorial(result));

//	Console.WriteLine("\nPress any key to continue.");
//	Console.ReadKey();
//	Console.Clear();
//}


//int[,] tictactoe = new int[,] { { 0, 12, 5 }, { 6, -4, 8 }, { 5, 48, 69 } };

//for (int i = 0; i < tictactoe.GetLength(0); i++)
//{

//	for (int j = 0; j < tictactoe.GetLength(1); j++)
//	{
//		Console.Write($"{tictactoe[i,j]} ");
//	}
//	Console.WriteLine();
//}

//int[][] tictactoeextreme = new int[][] { new[] {0,-12,5},
//										new[]{248,1,-56,48},
//										new[]{1},
//										new[]{2,12,-69,420,528} };

//Console.WriteLine();
//Console.WriteLine(tictactoeextreme[3].Length);
//Console.WriteLine();
//for (int i = 0; i < tictactoeextreme.Length; i++)
//{
//	for (int j = 0; j < tictactoeextreme[i].Length; j++)
//	{
//		Console.Write($"{tictactoeextreme[i][j]} ");
//	}
//	Console.WriteLine();
//}

while (true)
{
	Random random = new Random();
	int nahoda = random.Next(6);
	Random random2 = new Random();
	int nahoda2 = random.Next(6);
	Random random3 = new Random();
	int nahoda3 = random.Next(6);
	Console.WriteLine($"{nahoda} {nahoda2} {nahoda3}");

	if ((nahoda == nahoda2) && (nahoda2 == nahoda3))
	{
		Console.WriteLine("jackpot");
		break;
	}
	Console.WriteLine("\nPress any key to continue.");
	Console.ReadKey();
	Console.Clear();
}


//while (true)
//{
//	Console.WriteLine("Accept number:");
//	bool success = int.TryParse(Console.ReadLine(), out int number);

//	if (IsPrime(number))
//	{
//		Console.WriteLine("It is prime");
//	}
//	else
//	{
//		Console.WriteLine("It is not prime");
//	}
//	Console.WriteLine("\nPress any key to continue.");
//	Console.ReadKey();
//	Console.Clear();
//}
//bool IsPrime(int number)
//{
//	if (number <= 1)
//	{
//		return false;
//	}
//	if (number == 2)
//	{
//		return true;
//	}
//	if (number % 2 == 0)
//	{
//		return false;
//	}

//	var boundary = (int)Math.Floor(Math.Sqrt(number));

//	for (int i = 3; i <= boundary; i += 2)
//	{
//		if (number % i == 0)
//		{
//			return false;
//		}
//		return true;
//	}
//}