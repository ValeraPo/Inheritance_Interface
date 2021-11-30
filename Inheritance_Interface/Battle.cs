using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    class Battle
    {
        public static bool Fight(Monster monster, Hero hero)
        {
            Random _rnd = new Random();
            int damage = monster.GetAttack(_rnd.Next(0, 20));
            Console.WriteLine($"{monster.Name} наносит {damage} очков урона");
            hero.Wounds(damage);
            if (hero.IsDie)
            {
                Console.WriteLine($"{hero.Name} умирает\n {monster.Name} победил\n");
                return false;
            }
            Console.WriteLine($"У {hero.Name} осталось {hero.HP} очков здоровья\n");
            damage = hero.GetAttack(_rnd.Next(0, 20));
            Console.WriteLine($"{hero.Name} наносит {damage} очков урона");
            monster.Wounds(damage);
            if (hero.IsDie)
            {
                Console.WriteLine($"{monster.Name} умирает с криками  {monster.DieCry}\n{hero.Name} победил\n");
                return false;
            }
            Console.WriteLine($"У {monster.Name} осталось {monster.HP} очков здоровья\n");
            return true;
        }
    }
}
