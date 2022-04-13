Console.Write("Ввидите первое число => "); // приглашение 
string inputA = Console.ReadLine(); // ввод
int numberA = int.Parse(inputA); // конвертация

if(numberA % 2 == 0 )
{
    Console.WriteLine($"введйнное число: {numberA} чётное! ");
}
else
{
     Console.WriteLine($"введйнное число: {numberA} нечётное! ");
}