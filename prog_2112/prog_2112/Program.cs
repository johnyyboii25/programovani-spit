string[] pokemons = File.ReadAllLines("pokedexnew.txt");
string longestName = "";
foreach (string pokemon in pokemons)
{
	string[] parts = pokemon.Split((char)44);
	Console.WriteLine(parts[1]);
	Console.WriteLine($"{parts[1]} Type: {parts[2]}");
	Console.WriteLine($"{parts[1]} Health: {parts[5]}");
	Console.WriteLine();

	if (parts[1].Length > longestName.Length)
	{
		longestName = parts[1];
	}
}

Console.WriteLine(longestName);
//while (true)
//{
//	var rnd = new Random();
//	int i = rnd.Next(720);
//	Console.WriteLine(pokemons[i]);
//	Console.ReadLine();	
//}
