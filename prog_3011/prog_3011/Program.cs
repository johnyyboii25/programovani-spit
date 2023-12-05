
while (true)
{
	string[] shapes = { "square", "rectangle", "circle", "cube", "cuboid", "sphere", "cone", "triangle" };
	Console.WriteLine("Choose shape (square, rectangle, circle, cube, cuboid, sphere, cone, triangle) or end program with 'exit':");
	string selectedShape = Console.ReadLine().ToLower();

	if (selectedShape == "exit")
	{
		Console.WriteLine("Program ended.");
		break;
	}

	if (Array.IndexOf(shapes, selectedShape) == -1)
	{
		Console.WriteLine("Error. Try again.");
		continue;
	}

	switch (selectedShape)
	{

		case "square":
			PrintSquare();
			break;
		case "rectangle":
			PrintRectangle();
			break;
		case "triangle":
			PrintTriangle();
			break;
		case "circle":
			PrintCircle();
			break;
		case "cube":
			PrintCube();
			break;
		case "sphere":
			PrintSphere();
			break;
		case "cuboid":
			PrintCuboid();
			break;
		case "cone":
			PrintCone();
			break;
		case "exit":
			return;
		default:
			Console.WriteLine("Error, try again");
			break;

	}

	Console.WriteLine("\nPress any key to continue.");
	Console.ReadKey();
	Console.Clear();

}

double DoubleParse()
{
	bool success;
	double result;
	do
	{
		success = double.TryParse(Console.ReadLine(), out result);
	} while (success == false);
	return result;
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
	if ((c < a + b) && (a < c + b) && (b < c + a))
	{
		double s = (a + b + c) / 2;
		double area = s * (s - a) * (s - b) * (s - c);
		Console.WriteLine($"Circumference: {a + b + c}");
		Console.WriteLine($"Area: {Math.Sqrt(area)}");
	}
	else
	{
		Console.WriteLine("Doesn't follow triangle inequality.");
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
	Console.WriteLine($"Surface area: {2 * ((a * b) + (b * c) + (a * c))}");
	Console.WriteLine($"Volume: {a * b * c}");
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
