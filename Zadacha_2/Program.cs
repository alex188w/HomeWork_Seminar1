Console.Write("Введите первое число и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число и нажмите клавишу Enter: ");
int Number2 =  Convert.ToInt32(Console.ReadLine());

if (Number2 > Number1)
{
    Console.WriteLine("Число - " + Number1 + " является наменьшим");
    Console.WriteLine("Число - " + Number2 + " является набольшим");
}

else
{
    Console.WriteLine("Число" + Number2 + "является наменьшим");
    Console.WriteLine("Число" + Number1 + "является набольшим");   
}

