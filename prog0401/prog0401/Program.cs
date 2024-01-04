
//static void WriteFile()
//{
//	Console.WriteLine("Enter path:");

//	string path = Console.ReadLine();
//	string[] files = File.ReadAllLines(path);
//	foreach (string file in files)
//	{
//		string[] parts = file.Split((char)44);
//		Console.WriteLine(parts[1]);
//		Console.WriteLine($"{parts[1]} Type: {parts[2]}");
//		Console.WriteLine($"{parts[1]} Health: {parts[5]}");
//		Console.WriteLine();
//	}
//}
//while (true)
//{
//	try
//	{
//		WriteFile();
//	}
//	catch (FileNotFoundException e)
//	{
//		Console.WriteLine("ERROR, exception was:");
//		Console.WriteLine(e);
//	}

//	Console.WriteLine("End");
//}

static string GetPathFromUser()
{
	Console.WriteLine("Enter path");
	string path = Console.ReadLine();
	return path;
}

static void PrintErrorMessage()
{
	Console.WriteLine("File does not exist");
}

static string GetFileContents(string path)
{
	return File.ReadAllText(path);
}

static void PrintFileContents(string path)
{
	try
	{
		string contents = GetFileContents(path);
		Console.WriteLine(contents);
	}
	catch (Exception e)
	{
		PrintErrorMessage();
	}
}

static void UserReadFile()
{
	string path = GetPathFromUser();

	PrintFileContents(path);
}


UserReadFile();