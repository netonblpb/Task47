// Написать программу копирования массива.

Console.Clear();

Console.Write("Укажите длину массива: ");
int len = int.Parse(Console.ReadLine());
int[] oldmass = new int[len];
int[] newmass = new int[len];
Random rnd = new Random();

void MassFill(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = rnd.Next(10, 100);
    }
}

async void MassCopy(int[] x, int[] y)
{
    for (int i = 0; i < x.Length; i++)
    {
        y[i] = x[i];
    }
}

void MassPrint(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        Console.Write(x[i] + "   ");
    }
    Console.WriteLine();
}

MassFill(oldmass);
MassCopy(oldmass, newmass);
MassPrint(oldmass);
MassPrint(newmass);