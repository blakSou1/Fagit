int[] typeRums = new int[] { 0, 1, 2, 3 };
int doors = 2;
int selectedDoor;
int bossRums = 10;

int maxHealth = 10;
int health = 10;

int enemyDamage = 1;
int bossDamage = 5;
int items = 1;
int moveRums = 0;

int lvl = 1;
int maxLvl = lvl;

string name = "<Игрок>";

Console.Write("Игра началась. ");

Play();

void Play()
{
    Console.WriteLine("создание аватара...");

    doors = 2;
    moveRums = 0;

    maxHealth = 10;
    health = 10;
    items = 1;

    enemyDamage = 1;
    bossDamage = 5;

    lvl = 1;

    Console.WriteLine($"Добро пожаловать {name}");
    Console.WriteLine("Благодарим что вы приняли участие в нашем эксперементе!");
    Console.WriteLine("в 1 этапе вам предстоит выжить преодолев ряд препятствий");
    Console.WriteLine("Мы надеемся на вашу удачу.");

    OneRums();
}

void OneRums()
{
    Console.WriteLine("*перед вами появилась табличка с текстом:");

    TwoRums();
}

void TwoRums()
{

    if(lvl > maxLvl)
    {
        maxLvl = lvl;
    }//проверяем преодолели ли мы свой рекорд по уровням если да меняем рекорд на новый

    Console.WriteLine("Табличка:");
    Console.WriteLine($"Ваше здоровье: {health}");
    Console.WriteLine($"Ваш ур: {lvl}");
    Console.WriteLine($"Ваш максимальный ур: {maxLvl}");
    Console.WriteLine($"Перед вами {doors} двери. введите цифру соответствующую двери в которую желаете войти");

    selectedDoor = Convert.ToInt32(Console.ReadKey());//получаем число от пользователя соответствующее 1 из доступных для входа дверей

    Doors();
}

void Doors()
{
    int randomRums = typeRums[new Random().Next(0, typeRums.Length)];
// генерирует рандомный элемент массива наших комнат
    for(int i = 0; i < doors;)
    {

        if (i > typeRums.Length)
        {
            Console.WriteLine("*Похоже что ты делаеш что-то не то. нужно вернутся");
            TwoRums();
        }
        else
        {

            if(selectedDoor == i)
            {

                if(moveRums == (lvl * bossRums))
                {
                    Console.WriteLine("Вы ступаете на арену");
                    Console.WriteLine("*атмосфера действительно пугающая вас не ждет ничего хорошего");
                    Console.WriteLine("*на вас несется минотавр что вы собираетесь делать?");
                    Console.WriteLine("чтобы бится нажмите <A> и <R> чтобы бежать");

                    lvl++;

                    BossRum();
                }
                else
                {

                    if(selectedDoor == randomRums)
                    {
                        ItemRum();
                    }
                    else if(selectedDoor < (randomRums - 1))
                    {
                        EnemyRum();
                    }
                    else if(selectedDoor == (randomRums + 1))
                    {
                        NullRum();
                    }
                    else if(selectedDoor > randomRums)
                    {
                        RumHil();
                    }
                    else
                    {
                        Console.WriteLine("*стоя здесь ты явно не продвинишся вперед");
                        TwoRums();
                    }// выбираем тип комнаты в которую попадает игрок в зависимости от условий рандомно го числа и числа которое ввёл игрок

                }

            }
            else
            {
                i++;
            }// проверяем корректные ли данные введены

        }

    }

}

void BossRum()
{
    string Action = Convert.ToString(Console.ReadKey());

    bossDamage += lvl;//увеличиваем урон босса и скелетов соответственно нынешнему уровню
    enemyDamage++;

    if(Action == "a")
    {
        health -= bossDamage;

        if(health < 1)
        {
            Console.WriteLine("*похоже что эта битва оказалась для вас последней...");
            Console.WriteLine("Оу... это неожиданно чтож вы были лучшем среди всех образцов думаю необходимо повторить эксперимент");
            Play();
        }
        else
        {
            Console.WriteLine("*после по настоящему тяжолого противостояния истекая кровью вы чувствуете удовольствие от преодоления трудностей");
            Console.WriteLine("вы наполняетесь решимостью");
            Console.WriteLine("Вы спускаетесь с арены");

            maxHealth++;

            OneRums();
        }//проверяем хватило ли нам здоровье чтобы пережить схватку если нет начинаем сначала

    }
    else if(Action == "r")
    {
        Console.WriteLine("*вы еле успепеваете спрыгнуть с арены, кажется опасность миновала...");
        OneRums();
    }
    else
    {
        Console.WriteLine("Инвалид! тебя щас сожрут! действуй быстрее!");
        BossRum();
    }//проверяем какое действие решил совершить игрок

}

void NullRum()
{
    Console.WriteLine($"Вы заходите в {moveRums} комнату");
    Console.WriteLine("*Эта комната абсолютно пустая даже поверхности идеально выглажены. Только двери выделяются из картины");

    moveRums++;//считаем сколько комнат мы посетили
    
    if (doors > 3)
    {
        doors--;
    }// редактируем доступное для выбора количество дверей этот момент продумано не до конца из-за чего рушится баланс

    OneRums();
}

void EnemyRum()
{
    Console.WriteLine($"Вы заходите в {moveRums} комнату");
    Console.WriteLine("*перед вами самый настоящий скелет! вам не остается ничего кроме как принять бой");
    Console.WriteLine("*кажется вас ранили. - здоровье");
    Console.WriteLine("Ты не можеш сдатся сейчас... ты должен идти вперед");

    moveRums++;

    health -= enemyDamage;

    if (health < 1)
    {
        Console.WriteLine("*похоже что эта битва оказалась для вас последней...");
        Console.WriteLine("ты жалок у тебя недостаточно power");
        Play();
    }
    else
    {
        Console.WriteLine("*хах вам повезло");
        Console.WriteLine("вы наполняетесь решимостью");
        Console.WriteLine("Вы проходите к следующей пачке дверей");
    }

    if (doors < 4)
    {
        doors++;
    }

    OneRums();
}//комната с противником 

void RumHil()
{
    Console.WriteLine($"Вы заходите в {moveRums} комнату");
    Console.WriteLine("*Вы вошли в дверь и увидели пруд с настолько чистой водой что свет отражающийся от брилиантового дна залил все помещение");
    Console.WriteLine("*Дверь позади вас растворилась, вы решаете испить воды из явно не отравленного водоема");

    moveRums++;

    if(health < maxHealth)
    {
        Console.WriteLine("здоровье +1");
        health++;
    }
    else
    {
        Console.WriteLine("У воды сладкий вкус и запах корицы");
    }

    if (doors > 2)
    {
        doors--;
    }

    Console.WriteLine("*вы подходите к противоположной стене");

    OneRums();
}// комната восполнения здоровья

void ItemRum()
{
    Console.WriteLine($"Вы заходите в {moveRums} комнату");

    moveRums++;

    Console.WriteLine("*как только вы вошли перед вами предстал ангел, как только его взор пал на вас он тутже растворился в воздухе вы решили идти дальше");
    Console.WriteLine("решимость+");

    maxHealth += items;

    if(doors < 3)
    {
        doors++;
    }

    OneRums();
}// комната бустер увеличивает макс значение здоровья
