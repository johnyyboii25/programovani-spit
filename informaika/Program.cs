//while (true)
//{
//	Console.WriteLine("Rovnice: ax+b=0");
//	Console.Write("a = ");
//	string vstupA = Console.ReadLine();
//	Console.Write("b = ");
//	string vstupB = Console.ReadLine();

//	bool success1 = double.TryParse(vstupA, out double intvstupA);
//	bool success2 = double.TryParse(vstupB, out double intvstupB);

//	if (intvstupA != 0)
//	{
//		double vystupNE = -intvstupB/intvstupA;
//		if ( intvstupB == 0 ) 
//		{
//			vystupNE = 0;
//		}
//		Console.WriteLine($"Resenim rovnice je: {vystupNE}");

//	}
//	else if (intvstupB == 0)
//	{
//		Console.WriteLine("Rovnice ma nekonecne mnoho reseni.");
//	}
//	else
//	{
//		Console.WriteLine("Rovnice nema reseni.");
//	}
//}



using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

while (true)
{
	bool success;
	double vstupA;
	double vstupB;
	double vstupC;

	double DoubleParse()
	{
		string ting = Console.ReadLine();
		success = double.TryParse(ting, out double result);
		return result;
	}

	do
	{
		Console.WriteLine("Enter coefficients for equation: ax^2+bx+c=0");
		Console.Write("Enter coefficient a: ");
		vstupA = DoubleParse();	

		if (vstupA == 0)
		{
			Console.WriteLine("Neni to kvadraticka rovnice, zadej nenulové číslo.");
		}
	} while (success == false);

	do
	{
		Console.Write("Enter coefficient b: ");
		vstupB = DoubleParse();	
	} while (success == false);

	do
	{
		Console.Write("Enter coefficient c: ");
		vstupC = DoubleParse();
	} while (success == false);

	double diskriminant = vstupB * vstupB - 4 * vstupC * vstupA;
	double reseni1 = (-vstupB + Math.Sqrt(diskriminant)) / (2 * vstupA);
	double reseni2 = (-vstupB - Math.Sqrt(diskriminant)) / (2 * vstupA);

	if (diskriminant < 0)
	{
		Console.WriteLine($"The equation {vstupA}x^2 + {vstupB}x + {vstupC} = 0 has 0 solutions");
	}
	else if (diskriminant > 0)
	{
		Console.WriteLine($"The equation {vstupA}x^2 + {vstupB}x + {vstupC} = 0 has 2 solutions");
		Console.WriteLine($"x = {reseni1}");
		Console.WriteLine($"x = {reseni2}");
	}
	else if (diskriminant == 0)
	{
		Console.WriteLine($"The equation {vstupA}x^2 + {vstupB}x + {vstupC} = 0 has 1 solutions");
		Console.WriteLine($"x = {reseni1}");
	}
	Console.WriteLine("Enter parameter x for evaluation(type 'stop' to stop):");

	string stringvstupX = Console.ReadLine();
	if (stringvstupX == "stop")
	{
		break;
	}
	success = double.TryParse(stringvstupX, out double vstupX);
	double reseniparametr = vstupA * vstupX * vstupX + vstupB * vstupX + vstupC;
	Console.WriteLine($"{vstupA}*{vstupX}^2 + {vstupB}*{vstupX} + {vstupC} = {reseniparametr}");
	


}
