


//for (int i = 1; i <= 1000; i = i + 1)
//{

//	if (i % 13 == 0 && i % 69 == 0)
//	{
//		Console.WriteLine("FizzBuzz " + i);
//	}
//	else if (i % 69 == 0)
//	{
//		Console.WriteLine("Buzz " + i);
//	}
//	else if (i % 13 == 0)
//	{
//		Console.WriteLine("Fizz " + i);
//	}
//	else
//	{
//		Console.WriteLine(i);
//	}
//}

//kalkulacka


bool success1 = false;
bool success2 = false;
bool exit = false;
double number1 = 0;
double number2 = 0;
string znak;
string cislo1;
string cislo2;


while (true)
{
	//zadavani cisel

	do
	{
		Console.WriteLine("Zadej první číslo: ");
		cislo1 = Console.ReadLine();
		if (cislo1 == "exit")
		{
			break;
		}
		success1 = double.TryParse(cislo1, out number1);
	} while (!success1);

	if (cislo1 == "exit")
	{
		break;
	}


	do
	{
		Console.WriteLine("Zadej druhé číslo: ");
		cislo2 = Console.ReadLine();
		if (cislo2 == "exit")
		{
			break;
		}
		success2 = double.TryParse(cislo2, out number2);
	} while (!success2);

	if (cislo2 == "exit")
	{
		break;
	}

	do
	{
		Console.WriteLine("Zvol operaci (+, -, *, /, %) ");
		znak = Console.ReadLine();
		if (znak == "exit")
		{
			break;
		}
	} while (znak is not "+" and not "-" and not "*" and not "/" and not "%");
	if (znak == "exit")
	{
		break;
	}

	//vysledky

	if (znak == "+")
	{
		double sum = number1 + number2;
		Console.WriteLine("Výsledek: ");
		Console.WriteLine(sum);
	}
	if (znak == "-")
	{
		double sum = number1 - number2;
		Console.WriteLine("Výsledek: ");
		Console.WriteLine(sum);
	}
	if (znak == "*")
	{
		double sum = number1 * number2;
		Console.WriteLine("Výsledek: ");
		Console.WriteLine(sum);
	}
	if (znak == "/")
	{
		double sum = number1 / number2;
		Console.WriteLine("Výsledek: ");
		Console.WriteLine(sum);
	}
	if (znak == "%")
	{
		double sum = number1 % number2;
		Console.WriteLine("Výsledek: ");
		Console.WriteLine(sum);
	}

	//breaking

	Console.WriteLine("For end write exit");
	string konec = Console.ReadLine();
	if(konec == "exit")
	{ 
		break;
	}
}