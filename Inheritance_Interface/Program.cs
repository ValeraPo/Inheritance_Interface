using System;

namespace Inheritance_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster first_monster = new Monster("Гриша", MonsterTypes.cat, 499, 340, 10, 100, "мур-мур", "мяу");
            Monster second_monster = new Monster("Феодосий", MonsterTypes.dragon, 299, 250, 7, 68, "крхпркч", "упс");
            Monster third_monster = new Monster("Валентин", MonsterTypes.orc, 188, 143, 9, 50, "омн-омн-омн", "ыыыы");
            Monster fourth_monster = new Monster("Епифан", MonsterTypes.undead, 230, 190, 5, 76, "шшшшшш", "и че?");
            Monster fifth_monster = new Monster("Лютик", MonsterTypes.demon, 221, 170, 6, 23, "аааоооааао", "о нет");
            Monster sixth_monster = new Monster("Васёк", MonsterTypes.mutant, 250, 230, 8, 78, "слышь", "епт");
            Monster seventh_monster = new Monster("Гульнара", MonsterTypes.hydra, 156, 150, 3, 67, "бульбульбуль", "плюх");
            Monster eigth_monster = new Monster("Анжела", MonsterTypes.gargoulie, 99, 40, 2, 20, "*пищит ультразвуком*",
                "вы знаете кто мой отец?!");
            Monster ninth_monster = new Monster("Алёша", MonsterTypes.troll, 180, 178, 1, 56, "есть че поесть?", "азазаза");
            Monster tenth_monster = new Monster("Олежка", MonsterTypes.goblin, 228, 217, 8, 65, "моргенштерн", "кек");
            Hero first_hero = new Hero("Лара Крофт", HumanoidTypes.human, 450, 400, 230, 5, 90);
            Hero second_hero = new Hero("Скоятаэль", HumanoidTypes.elf, 346, 340, 180, 7, 67);
            Hero third_hero = new Hero("Петя", HumanoidTypes.ork, 240, 200, 110, 5, 43);
            Hero fourth_hero = new Hero("Леонид", HumanoidTypes.dwarf, 230, 230, 90, 8, 68);

            Monster[] my_monsters = new Monster[10];
            my_monsters[0] = first_monster;
            my_monsters[1] = second_monster;
            my_monsters[2] = third_monster;
            my_monsters[3] = fourth_monster;
            my_monsters[4] = fifth_monster;
            my_monsters[5] = sixth_monster;
            my_monsters[6] = seventh_monster;
            my_monsters[7] = eigth_monster;
            my_monsters[8] = ninth_monster;
            my_monsters[9] = tenth_monster;
            Hero[] my_heroes = new Hero[10];
            my_heroes[0] = first_hero;
            my_heroes[1] = second_hero;
            my_heroes[2] = third_hero;
            my_heroes[3] = fourth_hero;


            Random rnd = new Random();
            Monster first_fighter = my_monsters[rnd.Next(0, my_monsters.Length)];
            Hero second_fighter = my_heroes[rnd.Next(0, my_heroes.Length)];


            Console.WriteLine($"В правом углу {first_fighter.GetInfo()}");
            Console.WriteLine($"В левом углу {second_fighter.GetInfo()}");
            Console.WriteLine("Эта битва будет легендарной!\n");

            do
            {
                System.Threading.Thread.Sleep(500);
            } while (Battle.Fight(first_fighter, second_fighter));


            Console.ReadKey();
        }
    }
}
