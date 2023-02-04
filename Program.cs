System.Console.WriteLine("Задача первая.");
System.Console.WriteLine("Введите строку чисел, разделённых пробелом");

string input = Console.ReadLine();
if (input != null)
{
    int[] result = ConvertStringToArray(input);
    Console.WriteLine(string.Join(", ", result));

    System.Console.WriteLine("Положительных чисел: " + CountNumbersGreaterThanZero(result));
}

static int[] ConvertStringToArray(string input)
{
    string[] splitInput = input.Split(' ');
    int[] result = Array.ConvertAll(splitInput, int.Parse);
    return result;
}
int CountNumbersGreaterThanZero(int[] numbers)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    }


System.Console.WriteLine("Задача вторая.");
System.Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if(k1 == k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}