Console.Write("Введите число и нажмите клавишу Enter: ");
int Number1 =  Convert.ToInt32(Console.ReadLine());
int start = 2;

    while (start <= Number1)
    {
    int Remaind = (start % 2);
       if (Remaind == 0)
       {
       Console.Write(start + ", ");
       }
           
       start++; //увеличиваем start на единицу
    }
Console.WriteLine();