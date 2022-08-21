Console.WriteLine("Enter a three-digit number :");
int n = int.Parse(Console.ReadLine());
int n1 = n/100;
int n2 = n % 10;
Console.WriteLine(n1*10+n2);