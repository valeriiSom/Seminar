Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max =");
Console.WriteLine(max);