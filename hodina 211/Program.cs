//float AddOne(float x)
//{
//	return x * x + x + 1;
//}

//float x = 2;

//float y = AddOne(x);
//Console.WriteLine(y);

//void PrintNumber(string number)
//{
//	Console.WriteLine(number);
//}

//PrintNumber(Console.ReadLine());

//string x1 = Console.ReadLine();
//string y1 = Console.ReadLine();

//float.TryParse(x1, out float x2);
//float.TryParse(y1, out float y2);

//void Maximum(float x2, float y2)
//{
//	if (x2 > y2)
//	{
//		Console.WriteLine($"The bigger number is {x2}");
//	}
//	else if (x2 == y2)
//	{
//		Console.WriteLine("They are same");
//	}
//	else
//	{
//		Console.WriteLine($"The bigger number is {y2}");
//	}
//}

//Maximum(x2, y2);

double DoubleParse()
{
	Console.WriteLine("Enter number: ");
	string ting = Console.ReadLine();
	bool success = double.TryParse(ting, out double result);
	return result;
}

double number = DoubleParse();
