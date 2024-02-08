class Game
{
	private Player player1;
	private AI player2;

	public Game(Player player1, AI player2)
	{
		this.player1 = player1;
		this.player2 = player2;
	}


	public void PlayGame()
	{
		while (true)
		{
			Console.WriteLine();
			Console.WriteLine("Player1 FIGHT!!");
			string result = player1.TakeTurn();
			Console.WriteLine($"Player1 plays {result}");
			player1.PrintStats1();
			switch (result)
			{
				case "attack":
					player2.DecreseHealth(player1.GetAttack());
					break;

				case "wait":
					break;
			}

			if (!player2.IsAlive())
			{
				Console.WriteLine();
				Console.WriteLine("Player1 WINS!!!");
				return;
			}

			Console.WriteLine();
			
			string result2 = player2.TakeTurn();
			Console.WriteLine($"Player2 plays {result2}");
			player2.PrintStats2();
			switch (result2)
			{
				case "attack":
					player1.DecreseHealth(player2.GetAttack());
					break;

				case "wait":
					break;
			}

			if (!player1.IsAlive())
			{
				Console.WriteLine();
				Console.WriteLine("Player2 WINS!!!");
				return;
			}
		}
	}
}