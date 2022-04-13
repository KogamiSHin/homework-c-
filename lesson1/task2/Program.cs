Console.Write("Ввидите первое число => "); // приглашение 
string inputA = Console.ReadLine(); // ввод
int numberA = int.Parse(inputA); // конвертация

Console.Write("Ввидите второе число => ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

Console.Write("Ввидите третье число => ");
string inputC = Console.ReadLine();
int numberC = int.Parse(inputC);

int max = numberA; 

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine(max);