Console.WriteLine("Hello, World!");

int x;
x = 2;

int y = 3;



double procento = 0.344;
//vypis promenneeeee

/*
 * tvoje mamam]\
 * ,mi dala
 * */

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);

//pozdrav me
string name = "honza";
Console.WriteLine("ahoj " + name);
Console.WriteLine("Hello, {0}", name);


//pocitani
double number1 = 69;
double number2 = 42;


Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2); //jeden zapis
Console.WriteLine($"{number1} + {number2} = {number1 + number2}");  //druhy zapis
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);


//pretypovani promenne (explicitni)
double result = number1 / number2;
Console.WriteLine(result);
int resultINT = (int)result;
Console.WriteLine(resultINT);


//true or false
bool bool1 = true;
bool bool2 = false;


Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);
Console.WriteLine("!{0} = {1}", bool1, !bool1);


//funkce readline

Console.WriteLine("What's your name? ");
string jmenokdo = Console.ReadLine();
Console.WriteLine($"Hello, {jmenokdo}!");

//funkce try parse parse

string cislooduyivaTELEEL = Console.ReadLine();
int cisloprouyivaTELEEL;
int.TryParse(cislooduyivaTELEEL, out cisloprouyivaTELEEL);
Console.WriteLine(cisloprouyivaTELEEL + 45);

