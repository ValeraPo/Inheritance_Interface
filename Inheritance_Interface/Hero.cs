using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    class Hero : Humanoid, ICombatan
    {
        // Конструкторы
        public Hero() { }

        public Hero(string name) : this()
        {
            Name = name;
        }
        public Hero(string name, HumanoidTypes humanoid_type) : this(name)
        {
            HumanoidType = humanoid_type;
        }
        public Hero(string name, HumanoidTypes humanoid_type, int max_hp, int hp, int intelligence)
            : this(name, humanoid_type)
        {
            MaxHP = max_hp;
            HP = hp;
            Intelligence = intelligence;
        }
        public Hero(string name, HumanoidTypes humanoid_type, int max_hp, int hp, int intelligence, int minAttack, int maxAttack)
           : this(name, humanoid_type,  max_hp, hp, intelligence)
        {
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }
        //Минимальный наносимый урон
        int _minAttack;
        public int MinAttack
        {
            get => _minAttack;
            set
            {
                if (value < 5 || value > 15)
                    throw new Exception("Недопустимое значение минимальной атаки");
                _minAttack = value;
            }
        }
        // Максимальный наносимый урон
        int _maxAttack;
        public int MaxAttack
        {
            get => _maxAttack;
            set
            {
                if (value < 15 || value > 120)
                    throw new Exception("Недопустимое значение максимальной атаки");
                _maxAttack = value;
            }
        }
        // Атака героя
        Random _rnd = new Random();
        public new int GetAttack(int bonus) => _rnd.Next(MinAttack, MaxAttack + 1) * Intelligence / 100 + bonus;
        // Информация о монстре
        public new string GetInfo() => $"----> {TypeText} по имени {Name}\n" +
                $"Максимальный уровень здоровья {MaxHP}\n" +
                $"Текущий уровень здоровья {HP}\n" +
                $"Интеллект {Intelligence}\n" +
                $"Минимальный наносимый урон {MinAttack}\n" +
                $"Максимальный наносимый урон {MaxAttack}\n";
    }
}
