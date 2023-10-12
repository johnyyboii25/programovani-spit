


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
int number1;
int number2;
string znak;
do
{
    Console.WriteLine("Zadej první číslo");
    string cislo1 = Console.ReadLine();
    success1 = int.TryParse(cislo1, out  number1);

} while (!success1);

do 
{
    Console.WriteLine("Zadej druhé číslo");
    string cislo2 = Console.ReadLine();
    success2 = int.TryParse(cislo2, out number2);
}while (!success2);

do
{
    Console.WriteLine("Zvol operaci (+, -, *, /) ");
    znak = Console.ReadLine();
} while (znak != "+") ;

    if (znak == "+")
    {
        int sum = number1 + number2;
        Console.WriteLine("Výsledek: ");
        Console.WriteLine(sum);
    }

    if (znak == "-")
    {
        int sum = number1 - number2;
        Console.WriteLine("Výsledek: ");
        Console.WriteLine(sum);
    }

    if (znak == "*")
    {
        int sum = number1 * number2;
        Console.WriteLine("Výsledek: ");
        Console.WriteLine(sum);
    }

    if (znak == "/")
    {
        int sum = number1 / number2;
        Console.WriteLine("Výsledek: ");
        Console.WriteLine(sum);
    }