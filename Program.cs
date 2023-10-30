using System;

class Numbers
{
    private int a;
    private int b;

    public Numbers()
    {
        a = 0;
        b = 0;
    }
    public Numbers(int aVal, int bVal)
    {
        a = aVal;
        b = bVal;
    }

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public bool Correct()
    {
        return (a > 0 && b > 0);
    }

    public int Nod()
    {
        int x = a;
        int y = b;
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    public int Nok()
    {
        return (a * b) / Nod();
    }

    public void Print()
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
          
            Numbers num = new Numbers();

          
            int aInput, bInput;
            Console.Write("Введіть значення a: ");
            aInput = int.Parse(Console.ReadLine());
            Console.Write("Введіть значення b: ");
            bInput = int.Parse(Console.ReadLine());

            
            num.A = aInput;
            num.B = bInput;

           
            Console.WriteLine("\nЗначення полів об'єкта num:");
            num.Print();

          
            if (num.Correct())
            {
                
                Console.WriteLine("НСД (Найбільший Спільний Дільник): " + num.Nod());
                Console.WriteLine("НСК (Найменше Спільне Кратне): " + num.Nok());
            }
            else
            {
                Console.WriteLine("Об'єкт не може існувати, оскільки числа не є натуральними.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка в програмі.");
        }
    }
}
