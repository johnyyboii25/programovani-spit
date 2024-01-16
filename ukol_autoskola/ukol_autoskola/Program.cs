

using System.Globalization;

while (true)
{
	Console.WriteLine("Kvíz z autoškoly.");
	Console.WriteLine("Pro skončení programu stiskněte q.");
	Console.WriteLine();

	LoadQuestion("questions.data");
}


string LoadQuestion(string path)
{
	string[] questions = File.ReadAllLines(path);

	string[] parts = questions.Split((char)124);
	Console.WriteLine(parts[0]);
	for (int i = 3; i < parts.Length - 1; i++)
	{
		Console.WriteLine(parts[i]);
	}
	Console.WriteLine($"Spravna odpoved {parts[2]}");

	return "0";
}
