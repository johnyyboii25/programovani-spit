
internal class ElectronicProduct : Product
{
	public string Manufacturer;

	public ElectronicProduct(string Name, double Price, string Manufacturer) : base(Name, Price)
	{
		this.Manufacturer = Manufacturer;
	}
	public override void PrintInfo()
	{
		base.PrintInfo();
		Console.WriteLine("Manufacturer: " + Manufacturer);
	}

}
