class Car
{
	public string Znacka;
	public string Barva;
	public int MaxRychlost;
	public int Hmotnost;
	public int PocetKoni;

	public void PrintCar()
	{
		Console.WriteLine($"Znacka: {Znacka}");
		Console.WriteLine($"Barva: {Barva}");
		Console.WriteLine($"MaxRychlost: {MaxRychlost}");
		Console.WriteLine($"Hmotnost: {Hmotnost}");
		Console.WriteLine($"PocetKoni: {PocetKoni}");

	}
}
