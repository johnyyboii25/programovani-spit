class Character
{
	private int health;
	private int attack;

	public Character(int health, int attack)
	{
		this.health = health;
		this.attack = attack;
	}

	public void DecreseHealth(int amount)
	{
		this.health -= amount;
	}

	public int GetAttack()
	{
		return this.attack;
	}

	public bool IsAlive()
	{
		return this.health > 0;
	}

	public virtual string TakeTurn()
	{
		return "";
	}

	public void PrintStats1()
	{
		Console.WriteLine($"Player1 HP: {health} ");
		Console.WriteLine($"Player1 attack: {attack} ");
	}
	public void PrintStats2()
	{
		Console.WriteLine($"Player2 HP: {health} ");
		Console.WriteLine($"Player2 attack: {attack} ");
	}
}

class Player : Character
{
	public Player(int health, int attack) : base(health, attack)
	{

	}

	public override string TakeTurn()
	{
		Console.WriteLine("Press 'a' for attack, 'w' for wait");
		string turn = Console.ReadLine();
		if (turn == "a")
		{
			return "attack";
		}
		else
		{
			return "waiting";
		}
	}
}

class AI : Character
{
	public AI(int health, int attack) : base(health, attack)
	{

	}

	public override string TakeTurn()
	{
		Random rnd = new Random();

		int turn = rnd.Next(0, 2);
		if (turn == 1)
		{
			return "attack";
		}
		else
		{
			return "waiting";
		}
	}
}