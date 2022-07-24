Random rand = new Random();

int n = rand.Next(100, 1000);
int digit1 = n / 100;
int digit3 = n % 10;
Console.WriteLine(n);
Console.WriteLine(digit1 * 10 + digit3);// Решение 1 (математическое)
Console.WriteLine("" + digit1 + digit3);// Решение 2 (склеивание строк)
Console.WriteLine($"{digit1}{digit3}");//  Решение 3
