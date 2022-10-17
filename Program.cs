Console.WriteLine("input array length");
int arLength = int.Parse(Console.ReadLine()!);

Console.WriteLine("input max string length");
int maxLength = int.Parse(Console.ReadLine()!);

string[] InputArray(int Length)
{
    Console.WriteLine("input array elements");
    string[] arrInt = new string[Length];
    for (int i = 0; i < Length; i++)
    {
        arrInt[i] = Console.ReadLine()!;
    }
    return arrInt;
}