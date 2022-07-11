Console.Write("Введите число для проверки и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
int Remaind = (Number1 % 2);

if (Remaind == 0)
{
    Console.WriteLine("Число - " + Number1 + " является четным");
    
}

else
{
    Console.WriteLine("Число - " + Number1 + " является нечетным");
}
