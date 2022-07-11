Console.Write("Введите первое число и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите клавишу Enter: ");
int Number2 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число и нажмите клавишу Enter: ");
int Number3 =  Convert.ToInt32(Console.ReadLine());

int max = Number1;

if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;

Console.WriteLine("Число - " + max + " является максимальным");


