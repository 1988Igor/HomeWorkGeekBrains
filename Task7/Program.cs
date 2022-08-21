Console.WriteLine("Enter a number from [10,99]");
int n = int.Parse(Console.ReadLine());
int n1 = n/10;
int n2 = n%10;
int max = 0;
if (n1>n2) max = n1;
if (n1<n2) max = n2;
Console.WriteLine($"The maximal number is {max}");