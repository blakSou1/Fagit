int[] rums = new int[] { 0, 1, 2, 3 };
int colRum = 2;
int maxHealth = 10;
int health = 10;
int enemyDamage = 1;
int bossDamage = 5;
int items = 1;
int moveRums = 0;
int lvl = 1;
string name = "<Игрок>";

Console.Write("Игра началась. ");

St();

void St()
{

    Console.WriteLine($"Добро пожаловать {name}");
    Console.WriteLine("Благодарим что вы приняли участие в нашем эксперементе!");
    Console.WriteLine("в 1 этапе вам предстоит выжить преодолев ряд препятствий, мы надеемся на вашу удачу");

    Op();

}

void Op()
{

    Console.WriteLine("*вы шокированы");
    Console.WriteLine("*перед вами появилась табличка с текстом:");

    Rum();

}

void Rum()
{

    Console.WriteLine("Табличка:");
    Console.WriteLine($"Ваше здоровье: {health}");
    Console.WriteLine($"Перед вами {colRum} двери. введите цифру соответствующую двери в которую желаете войти");

    vo();

}

void vo()
{

    string p = Console.ReadLine();
    int r = rums[new Random().Next(0, rums.Length)];

    int pRum = Convert.ToInt32(p);

    if(moveRums == (lvl * 10))
    {

        Console.WriteLine($"Вы заходите в {moveRums} комнату");

        moveRums++;

        Console.WriteLine("*атмосфера действительно пугающая нас не ждет ничего хорошего");
        Console.WriteLine("*на вас несется минотавр что вы собираетесь делать?");
        Console.WriteLine("чтобы бится нажмите <A> и <R> чтобы бежать");

        lvl++;
        bossRum();

    }
    else
    {

        if(pRum == r)
        {

            ItemRum();

        }
        else if(pRum < r)
        {

            EnemyRum();

        }
        else if(pRum == (r + 1))
        {

            RumHil();

        }
        else if(pRum > r)
        {

            nullRum();

        }
        else
        {

            Console.WriteLine("*стоя здесь ты явно не продвинишся вперед");
            vo();

        }

    }

}

void bossRum()
{

    string s = Convert.ToString(Console.ReadLine());

    bossDamage += lvl;

    if(s == "a")
    {

        health -= bossDamage;
        if(health < 0)
        {

            Console.WriteLine("*похоже что эта битва оказалась для вас последней...");

        }
        else
        {

            Console.WriteLine("*после по настоящему тяжолого противостояния истекая кровью вы чувствуете удовольствие от преодоления трудностей");
            Console.WriteLine("вы наполняетесь решимостью");
            maxHealth++;

            Rum();

        }

    }
    else if(s == "r")
    {

        Console.WriteLine("ты еле успепеваеш зайти в ближайшую дверь, кажется опасность миновала...");
        Rum();

    }
    else
    {

        Console.WriteLine("Инвалид! тебя щас сожрут! действуй быстрее!");
        bossRum();

    }

}

void nullRum()
{

    Console.WriteLine($"Вы заходите в {moveRums} комнату");

    moveRums++;

    Console.WriteLine("*Эта комната абсолютно пустая даже поверхности идеально выглажены. Только двери выделяются из картины");

    Rum();

}

void EnemyRum()
{

    Console.WriteLine($"Вы заходите в {moveRums} комнату");

    Console.WriteLine("*перед вами самый настоящий скелет! вам не остается ничего кроме как принять бой");
    Console.WriteLine("*кажется вас ранили. - здоровье");
    Console.WriteLine("Ты не можеш сдатся сейчас... ты должен идти вперед");

    moveRums++;

    health -= enemyDamage;

    if (colRum > 2)
    {

        colRum--;

    }

    Rum();

}

void RumHil()
{

    Console.WriteLine($"Вы заходите в {moveRums} комнату");

    moveRums++;

    Console.WriteLine("*Вы вошли в дверь и увидели пруд с настолько чистой водой что свет отражающийся от брилиантового дна залил все помещение");
    Console.WriteLine("*Дверь позади вас растворилась, вы решаете испить воды из явно не отравленного водоема");

    if(health < maxHealth)
    {

        Console.WriteLine("здоровье +1");
        health++;

    }
    else
    {

        Console.WriteLine("У воды сладкий вкус и запах корицы");

    }

    if(colRum < 4)
    {

        colRum++;

    }

    Console.WriteLine("*вы подходите к противоположной стене");

    Rum();

}

void ItemRum()
{

    Console.WriteLine($"Вы заходите в {moveRums} комнату");

    moveRums++;

    Console.WriteLine("*как только вы вошли перед вами предстал ангел, как только его взор пал на вас он тутже растворился в воздухе вы решили идти дальше");
    Console.WriteLine("решимость+");

    maxHealth += items;

    if (colRum < 4)
    {

        colRum++;

    }

    Rum();

}