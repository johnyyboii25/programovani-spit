using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

while (true)
{
	bool success;
	double a;
	double b;
	double c;

	double DoubleParse()
	{
		string ting = Console.ReadLine();
		success = double.TryParse(ting, out double result);
		return result;
	}

	//zadavani koeficientu
	Console.WriteLine("Enter coefficients for equation: ax^2 + bx + c = 0");
	do
	{
		Console.Write("Enter coefficient a: ");
		a = DoubleParse();
	} while (success == false);

	do
	{
		Console.Write("Enter coefficient b: ");
		b = DoubleParse();
	} while (success == false);

	do
	{
		Console.Write("Enter coefficient c: ");
		c = DoubleParse();
	} while (success == false);

	//pocitani
	double diskriminant = b * b - 4 * c * a;
	if (a == 0)
	{
		Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has 1 solutions");
		Console.WriteLine($"x = {(-c)/b}");
	}
	else if ((a == 0) && (b == 0))
	{
		Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has 1 solutions");
		Console.WriteLine($"x = {-c}");
	}
	else if ((a == 0) && (b == 0) && (c == 0))
	{
		Console.WriteLine("0 = 0");
	}
	else if (diskriminant < 0)
	{
		Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has 0 solutions");
	}
	else if (diskriminant > 0)
	{
		Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has 2 solutions");
		Console.WriteLine($"x = {(-b - Math.Sqrt(diskriminant)) / (2 * a)}");
		Console.WriteLine($"x = {(-b + Math.Sqrt(diskriminant)) / (2 * a)}");
	}
	else if (diskriminant == 0)
	{
		Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has 1 solutions");
		Console.WriteLine($"x = {(-b + Math.Sqrt(diskriminant)) / (2 * a)}");
	}

	//stop?
	Console.WriteLine("Enter parameter x for evaluation(type 'stop' to stop):");
	while (true)
	{
		string stringx;
		double x = 0;
		bool found = false;

		do
		{
			stringx = Console.ReadLine();
			if (stringx == "stop")
			{
				found = true;
				break;
			}
			success = double.TryParse(stringx, out x);
		} while (success == false);	

		if (found)
		{
			break;
		}
		double reseniparametr = a * x * x + b * x + c;
		Console.WriteLine($"{a}*{x}^2 + {b}*{x} + {c} = {reseniparametr}");
	}

	//konec?
	Console.WriteLine("Do you want to exit the program? ('y' for exit)");
	string y = Console.ReadLine();
	if (y == "y") 
	{
		break;
	}
}
