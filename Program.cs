using System.Runtime.CompilerServices;

int magicNumber = 4;

Con();

void Con()
{

    Console.WriteLine("Угадай число");
    Console.WriteLine("");
    Console.WriteLine("Загадано число от 1 до 5. попробуйте его отгадать!");
    Console.WriteLine();
    Console.Write("Введите ваше число: ");

    int input = Convert.ToInt32(Console.ReadLine());

    if(magicNumber == input)
    {

        Console.WriteLine("Да! Это число" + magicNumber + "!");

    }
    else
    {

        Console.WriteLine("Нет! Это не" + input + "!");
        Console.WriteLine("попоробуете еще раз?");
        Console.WriteLine("чтобы закончить нажмите А");

        if (Console.ReadLine() != "A")
        {

                magicNumber = new Random().Next(0, 5);

        }

    }

}