Console.Write("Ввидите первое число => "); // приглашение 
string inputA = Console.ReadLine(); // ввод
int numberA = int.Parse(inputA); // конвертация

Console.Write("Ввидите второе число => ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

if (numberA > numberB)
{
    Console.WriteLine($"большее число {numberA}");
}
else
{
    Console.WriteLine($"большее число {numberB}");
}
