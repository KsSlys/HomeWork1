Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number < N)
{
    if (number % 2 == 1)
    {
        number ++;
    }
    else
    {
        Console.WriteLine(number + ", ");
        number ++;
    }
}
