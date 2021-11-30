using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    public abstract class Creature
    {
        // Имя
        string _name;
        public string Name 
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой");
                _name = value;
            }
        }
        // хп
        int _hp;
        public int HP
        {
            get => _hp;
            set
            {
                if (value < 0 || value > MaxHP)
                    throw new Exception("Недопустимое значение здоровья");
                _hp = value;
            }
        }
        // максимальное хп
        int _maxHP;
        public int MaxHP
        {
            get => _maxHP;
            set
            {
                if (value < 0 || value > 500)
                    throw new Exception("Недопустимое значение здоровья");
                _maxHP = value;
            }
        }
        // Проверка на смерть
        public bool IsDie => HP == 0;
        // Перегрузка логических операторов чтобы боец не сражался сам с собой
        public static bool operator ==(Creature first, Creature second)
        {
            if (first.Name == second.Name) return true;
            return false;
        }
        public static bool operator !=(Creature first, Creature second)
        {
            if (first.Name != second.Name) return true;
            return false;
        }
        // Информация о существе
        public new string GetInfo() => $"----> Существо по имени {Name}\n" +
                $"Максимальный уровень здоровья {MaxHP}\n" +
                $"Текущий уровень здоровья {HP}\n";

    }
}
