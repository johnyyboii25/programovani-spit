//int[] a = new int[10];

//void PrintArray(int[] array)
//{
//	for (int i = 0; i < array.Length; i++)
//	{
//		Console.Write(array[i]);
//		if (i < array.Length - 1)
//		{
//			Console.Write(", ");
//		}
//	}
//	Console.WriteLine();
//}


//int[] number = { 5, 2, 4, 8 };
//PrintArray(number);

//int[] number2 = { 6, 12, 4, 85, 69 };
//PrintArray(number2);

//int[] numbers3 = number2;
//PrintArray(number2);
//PrintArray(numbers3);

//number2[0] = 1;
//PrintArray(number2);
//PrintArray(numbers3);

//using System;

//int[] pas = new int[10];
//Console.Write("0, ");
//for (int i = 2; i < new int[10].Length; i++)
//{
//	pas[0] = 0;	
//	pas[1] = 0;	
//	pas[2] = 1;
//	pas[i] = pas[i-1] + pas[i-2];
//	Console.Write(pas[i]);
//	if (i < pas.Length - 1)
//	{
//		Console.Write(", ");
//	}

//}


void PrintPolynomial(int[] polynomial)
{
	for (int i = 0; i < polynomial.Length; i++)
	{

		Console.Write($" {polynomial[i]}x^{polynomial.Length - i - 1} +");
		if (i == polynomial.Length - 1)
		{
			Console.Write($"{polynomial[i]}");
		}
	
	}
}

int[] coefficient = { 6, 5, -45, 12, 8, 4 };
PrintPolynomial(coefficient);