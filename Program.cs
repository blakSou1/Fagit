bool[] thimble = new bool[3] { false, false, true };

    Console.WriteLine("Игра в наперстки");
    Console.WriteLine();
    Console.WriteLine("под одним из трех наперстков находится шарик. Попробуй угадать в каком!");
    Console.WriteLine();
    Console.Write("Введите ваше число от 1 до 3");

c();

void c()
{

    int input = Convert.ToInt32(Console.ReadLine());

    if (thimble[input] == true)
    {

        Console.WriteLine("Угадал...");

    }
    else
    {

        Console.WriteLine("ты Не угадал! попробуй еще раз");
        c();

    }

}