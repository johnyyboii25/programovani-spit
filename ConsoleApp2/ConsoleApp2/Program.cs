while (true)
{
	double DoubleParse()
	{
		bool success;
		do
		{
			string ting = Console.ReadLine();
			success = double.TryParse(ting, out double result);
			return result;
		} while (success == false);
	}
	int IntParse()
	{
		bool success;
		do
		{
			string ting = Console.ReadLine();
			success = int.TryParse(ting, out int result);
			return result;
		} while (success == false);
	}

	void PrintSquare()
	{
		Console.WriteLine("You have chosen square");
		Console.WriteLine("Enter length of a side: ");
		double a = DoubleParse();
		Console.WriteLine($"Circumference: {4 * a}");
		Console.WriteLine($"Area: {Math.Pow(a, 2)}");
	}
	void PrintTriangle()
	{
		Console.WriteLine("You have chosen triangle");
		Console.WriteLine("Enter length of side a: ");
		double a = DoubleParse();
		Console.WriteLine("Enter length of side b: ");
		double b = DoubleParse();
		Console.WriteLine("Enter length of side c: ");
		double c = DoubleParse();
		if (c > a + b)
		{
			double s = (a + b + c) / 2;
			double area = s * (s - a) * (s - b) * (s - c);
			Console.WriteLine($"Circumference: {a + b + c}");
			Console.WriteLine($"Area: {Math.Sqrt(area)}");
		} 
		else
		{
			Console.WriteLine("");
		}
	}
	void PrintRectangle()
	{
		Console.WriteLine("You have chosen rectangle");
		Console.WriteLine("Enter length of the reactangle: ");
		double a = DoubleParse();
		Console.WriteLine("Enter width of the rectangle: ");
		double b = DoubleParse();
		Console.WriteLine($"Circumference: {2 * (a + b)}");
		Console.WriteLine($"Area: {a * b}");
	}
	void PrintCircle()
	{
		Console.WriteLine("You have chosen circle");
		Console.WriteLine("Enter length of the radius: ");
		double r = DoubleParse();
		Console.WriteLine($"Circumference: {2 * Math.PI * r}");
		Console.WriteLine($"Area: {Math.PI * Math.Pow(r, 2)}");
	}
	void PrintCube()
	{
		Console.WriteLine("You have chosen cube");
		Console.WriteLine("Enter length of a side: ");
		double a = DoubleParse();
		Console.WriteLine($"Surface area: {6 * Math.Pow(a, 2)}");
		Console.WriteLine($"Volume: {Math.Pow(a, 3)}");
	}
	void PrintCuboid()
	{
		Console.WriteLine("You have chosen triangle");
		Console.WriteLine("Enter heigth: ");
		double a = DoubleParse();
		Console.WriteLine("Enter width: ");
		double b = DoubleParse();
		Console.WriteLine("Enter length: ");
		double c = DoubleParse();
		Console.WriteLine($"Surface area: {2 * ((a*b) + (b*c) + (a*c))}");
		Console.WriteLine($"Volume: {a*b*c}");
	}
	void PrintSphere()
	{
		Console.WriteLine("You have chosen sphere");
		Console.WriteLine("Enter length of the radius: ");
		double r = DoubleParse();
		Console.WriteLine($"Surface area: {4 * Math.PI * Math.Pow(r, 2)}");
		Console.WriteLine($"Volume: {(4 / 3) * Math.PI * Math.Pow(r, 3)}");
	}
	void PrintCone()
	{
		Console.WriteLine("You have chosen cone");
		Console.WriteLine("Enter radius : ");
		double r = DoubleParse();
		Console.WriteLine("Enter height: ");
		double h = DoubleParse();
		Console.WriteLine($"Surface area: {Math.PI * r * (r + Math.Sqrt((Math.Pow(r, 2) + Math.Pow(h, 2))))}");
		Console.WriteLine($"Volume: {(Math.PI * h * Math.Pow(r, 2)) / 3}");
	}

	Console.WriteLine("Select shape with index:");
	Console.WriteLine("1 for square");
	Console.WriteLine("2 for rectangle");
	Console.WriteLine("3 for triangle");
	Console.WriteLine("4 for circle");
	Console.WriteLine("5 for cube");
	Console.WriteLine("6 for sphere");
	Console.WriteLine("7 for cuboid");
	Console.WriteLine("8 for cone");
	int volba = IntParse();
	switch (volba)

	{

		case 1:
			PrintSquare();
			break;
		case 2:
			PrintRectangle();
			break;
		case 3:
			PrintTriangle();
			break;
		case 4:
			PrintCircle();
			break;
		case 5:
			PrintCube();
			break;
		case 6:
			PrintSphere();
			break;
		case 7:
			PrintCuboid();
			break;
		case 8:
			PrintCone();
			break;
		case 9:
			return;
		default:
			Console.WriteLine("Neplatná volba.");
			break;

	}

	Console.WriteLine("\nStiskněte libovolnou klávesu pro pokračování.");

	Console.ReadKey();

	Console.Clear(); // Vymaže konzoli pro další volby

}