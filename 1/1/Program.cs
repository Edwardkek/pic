Console.WriteLine("Пишите числа, которые вы хотите, но останутся только четные, так как будет произведена нечетная чистка.");
Console.WriteLine("Введите значения: ");

int q = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());
int t = Convert.ToInt32(Console.ReadLine());

if (q % 2 == 0)
    {
        Console.Write(q + ", ");
    }
if (w % 2 == 0)
    {
        Console.Write(w + ", ");
    }
if (e % 2 == 0)
    {
        Console.Write(e + ", ");
    }
if (r % 2 == 0)
    {
        Console.Write(r + ", ");
    }
if (t % 2 == 0)
    {
        Console.Write(t);
    }