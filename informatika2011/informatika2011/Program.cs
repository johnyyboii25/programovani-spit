

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
		}while (success == false);
	}

	Console.WriteLine("Vyberte si tvar pro výpočet:");

	Console.WriteLine("1. Obdélník");

	Console.WriteLine("2. Čtverec");

	Console.WriteLine("3. Kruh");

	Console.WriteLine("4. Trojúhelník");

	Console.WriteLine("5. Konec");

	int volba;

	while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 5)

	{

		Console.WriteLine("Zadejte platnou možnost (1-5).");

	}

	double a, b, polomer, vyska, strana1, strana2, strana3;

	switch (volba)

	{

		case 1: // Obdélník

			Console.WriteLine("Zadejte délku strany a:");

			a = DoubleParse();

			Console.WriteLine("Zadejte délku strany b:");

			b = DoubleParse();

			Console.WriteLine($"Obvod obdélníku je: {2 * (a + b)}");

			Console.WriteLine($"Obsah obdélníku je: {a * b}");

			break;

		case 2: // Čtverec

			Console.WriteLine("Zadejte délku strany:");

			a = DoubleParse();

			Console.WriteLine($"Obvod čtverce je: {4 * a}");

			Console.WriteLine($"Obsah čtverce je: {a * a}");

			break;

		case 3: // Kruh

			Console.WriteLine("Zadejte poloměr kruhu:");

			polomer = DoubleParse();

			Console.WriteLine($"Obvod kruhu je: {2 * Math.PI * polomer}");

			Console.WriteLine($"Obsah kruhu je: {Math.PI * polomer * polomer}");

			break;

		case 4: // Trojúhelník

			Console.WriteLine("Zadejte délku strany a:");

			strana1 = DoubleParse();

			Console.WriteLine("Zadejte délku strany b:");

			strana2 = DoubleParse();

			Console.WriteLine("Zadejte délku strany c:");

			strana3 = DoubleParse();

			double obvod = strana1 + strana2 + strana3;

			double s = obvod / 2;

			double obsah = Math.Sqrt(s * (s - strana1) * (s - strana2) * (s - strana3));

			Console.WriteLine($"Obvod trojúhelníku je: {obvod}");

			Console.WriteLine($"Obsah trojúhelníku je: {obsah}");

			break;

		case 5: // Konec

			Console.WriteLine("Program ukončen.");

			return;

		default:

			Console.WriteLine("Neplatná volba.");

			break;

	}

	Console.WriteLine("\nStiskněte libovolnou klávesu pro pokračování.");

	Console.ReadKey();

	Console.Clear(); // Vymaže konzoli pro další volby

}

while (true)
{








}

