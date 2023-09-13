Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
if (num >= 100 && num <= 999)
Console.WriteLine(num % 10);
else Console.WriteLine("Enter next number");