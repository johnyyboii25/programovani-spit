using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
	public string name;
	public string BirthDate;
	public int RodneCislo;
	public string Adrress;
	public int NumFingers;
	public string gender;
	public float Height;

	public void PrintPerson()
	{
		Console.WriteLine(name);
		Console.WriteLine(BirthDate);
		Console.WriteLine(RodneCislo);
		Console.WriteLine(Adrress);
		Console.WriteLine(NumFingers);
		Console.WriteLine(gender);
		Console.WriteLine(Height);	
	}
}