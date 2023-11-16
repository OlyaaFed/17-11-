Console.WriteLine("Введите числа");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

int dx = Math.Abs(x2 - x1);
int dy = Math.Abs(y2 - y1);

if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
