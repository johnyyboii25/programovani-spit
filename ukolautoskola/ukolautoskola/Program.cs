
string[] questions = File.ReadAllLines("questions.data");


static string[] shuffleQuestions(string[] questions)
{
	Random random = new Random();
	var shuffledQuestions = new List<string>();

	while (shuffledQuestions.Count < questions.Length)
	{
		int randomIndex = random.Next(questions.Length);

		if (!shuffledQuestions.Contains(questions[randomIndex]))
		{
			shuffledQuestions.Add(questions[randomIndex]);
		}
	}

	return shuffledQuestions.ToArray();
}

questions = shuffleQuestions(questions);

Console.WriteLine("Welcome to the driving school quiz, type \"q\" to quit");
Console.WriteLine();

int correctAnswers = 0;
int incorrectAnswers = 0;

foreach (string question in questions)
{
	string[] questionParts = question.Split('|');
	string questionText = questionParts[0];
	string[] answerOptions2 = new string[] { "A", "B", "C" };

	Console.WriteLine(questionText);

	
	Console.WriteLine($"A) {questionParts[2]}");
	Console.WriteLine($"B) {questionParts[3]}");
	if (questionParts.Length > 4)
	{
		Console.WriteLine($"C) {questionParts[4]}");
	}


	string userAnswer = "";
	while (!answerOptions2.Contains(userAnswer))
	{
		userAnswer = promptUserForAnswer();
		if (!answerOptions2.Contains(userAnswer))
		{
			Console.WriteLine("Invalid input");
		}
	}

	Console.Clear();

	if (userAnswer == questionParts[1])
	{
		correctAnswers++;
		Console.WriteLine("Correct answer ;))");
	}
	else
	{
		incorrectAnswers++;
		Console.WriteLine("Incorrect answer :((");
		Console.WriteLine("Correct answer is:");

		if (questionParts[1] == "A")
		{
			Console.WriteLine($"A) {questionParts[2]}");

		}
		else if (questionParts[1] == "B")
		{
			Console.WriteLine($"B) {questionParts[3]}");

		}
		else
		{
			Console.WriteLine($"C) {questionParts[4]}");

		}
	}

	Console.WriteLine();
}

calculatePercentage();

string promptUserForAnswer()
{
	string answer = Console.ReadLine().Trim().ToUpper();
	if (answer == "Q")
	{
		calculatePercentage();
		Environment.Exit(0);
	}

	return answer;
}

void calculatePercentage()
{
	Console.WriteLine("End of quiz");
	int totalquestions = correctAnswers + incorrectAnswers;
	double percentage = (double)correctAnswers / totalquestions;
	Console.WriteLine($"Correct answers: {correctAnswers} out of {totalquestions}");
	Console.WriteLine($"Your percentage: {(percentage)* 100}%");
}
