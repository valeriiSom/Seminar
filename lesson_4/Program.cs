Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = num * -1;

while (num0 <= num)
{
    Console.WriteLine(num0);
    num0 ++;
}