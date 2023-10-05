// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write password: ");
string password = Console.ReadLine();

//prikaz if a else
if (password == "1234")
{
	Console.WriteLine("You're in");
}
else
{
	Console.WriteLine("Wrong password");
}


//procviceni
Console.WriteLine("What's your name");
string jmeno = Console.ReadLine();
Console.WriteLine("Hello, " + jmeno + "!");


for (int i = 1; i < 10; i++)
{
	Console.WriteLine(i);
}

Console.WriteLine("Czklus ");


int number = 0;
while (number < 10)
{
	console.writeline(number);
	number = number + 1;
	/*jiny zapis
	 * number += 1;
	 * number++;
	 */
}


Console.WriteLine("Cyklus while: ");
int otherNumber = 7;
do
{
	Console.WriteLine(otherNumber);
	otherNumber = otherNumber + 1;
} while (otherNumber < 10);



prevod string na int


bool success;
do
{
	Console.WriteLine("enter number: ");
	string num1string = Console.ReadLine();
	success = int.TryParse(num1string, out int num2);
	Console.WriteLine("success = " + success);

	for (int i = 1; i <= num2; i++)
	{
		Console.WriteLine(i);
	}

	if (success == false)
	{
		Console.WriteLine("Try again");
	}

} while (success == false);
