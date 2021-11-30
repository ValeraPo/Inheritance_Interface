using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    public class Monster : Creature, ICombatan
    {
        // Конструкторы
        public Monster() { }

        public Monster(string name) : this()
        {
            Name = name;
        }
        public Monster(string name, MonsterTypes monster_type) : this(name)
        {
            MonsterType = monster_type;
        }
        public Monster(string name, MonsterTypes monster_type, int max_hp)
            : this(name, monster_type)
        {
            MaxHP = max_hp;
        }
        public Monster(string name, MonsterTypes monster_type, int max_hp, int hp,
            int min_attack, int max_attack)
            : this(name, monster_type, max_hp)
        {
            HP = hp;
            MinAttack = min_attack;
            MaxAttack = max_attack;
        }
        public Monster(string name, MonsterTypes monster_type, int max_hp, int hp,
            int min_attack, int max_attack, string war_cry, string die_cry)
            : this(name, monster_type, max_hp, hp, min_attack, max_attack)
        {
            WarCry = war_cry;
            DieCry = die_cry;
        }

        // Тип монстра
        public MonsterTypes MonsterType { get; set; }
        //Минимальный наносимый урон
        int _minAttack;
        public int MinAttack
        {
            get => _minAttack;
            set
            {
                if (value < 1 || value > 10)
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
                if (value < 10 || value > 100)
                    throw new Exception("Недопустимое значение максимальной атаки");
                _maxAttack = value;
            }
        }
        // Боевой крик
        string _warCry;
        public string WarCry
        {
            get => _warCry;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой");
                _warCry = value;
            }
        }
        // Предсмертный крик
        string _dieCry;
        public string DieCry
        {
            get => _dieCry;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой");
                _dieCry = value;
            }
        }
        // Тип монстра на русском
        public string TypeText 
        {
            get
            {
                return (MonsterType == MonsterTypes.dragon ? "дракон"
                    : (MonsterType == MonsterTypes.undead ? "нежить"
                    : (MonsterType == MonsterTypes.demon ? "демон"
                    : (MonsterType == MonsterTypes.mutant ? "мутант"
                    : (MonsterType == MonsterTypes.hydra ? "гидра"
                    : (MonsterType == MonsterTypes.gargoulie ? "гаргулья"
                    : (MonsterType == MonsterTypes.troll ? "троль"
                    : (MonsterType == MonsterTypes.goblin ? "гоблин" : "кот"))))))));
            }
        }
        
        // Информация о монстре
        public new string GetInfo() => $"----> {TypeText} по имени {Name}\n" +
                $"Максимальный уровень здоровья {MaxHP}\n" +
                $"Текущий уровень здоровья {HP}\n" +
                $"Минимальный наносимый урон {MinAttack}\n" +
                $"Максимальный наносимый урон {MaxAttack}\n";
        // Атака монстра
        Random _rnd = new Random();
        public int GetAttack(int bonus) => _rnd.Next(MinAttack, MaxAttack + 1) + bonus;
        // Ранение монстра
        public void Wounds(int damage)
        {
            if (HP > damage) HP -= damage;
            else HP = 0;
        }
        // Оздоровление монстра
        public void Heal() => HP = MaxHP;
        
    }
}
