
string yasmin;

Console.WriteLine("tradutor simples para a linguagem Leet Speak.");
yasmin = Console.ReadLine()!.Replace("A","4").ToUpper()
.Replace("E","3")
.Replace("I","1")
.Replace("L","1")
.Replace("O","0")
.Replace("T","7")
.Replace("S","5");

Console.WriteLine($"{yasmin}");
