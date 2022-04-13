Console.Write("Ввидите первое число => "); // приглашение 
string inputA = Console.ReadLine(); // ввод
int numberA = int.Parse(inputA); // конвертация

int rangeA = 0 - numberA; 
Console.Write(rangeA+" ");
while (rangeA < numberA)
{
    rangeA = rangeA + 1;
    Console.Write(rangeA+" ");
}
