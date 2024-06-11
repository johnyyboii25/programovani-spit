
internal class Book : Product
{
	public string Author;
	public Book(string Name, double Price, string Author) : base(Name, Price)
	{
		this.Author = Author;
	}
	public override void PrintInfo()
	{
		base.PrintInfo();
		Console.WriteLine(Author);
	}
}
