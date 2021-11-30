using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    class Humanoid : Creature
    {
       
        
        // Расса гуманоида
        public HumanoidTypes HumanoidType { get; set; }
        // Тип монстра на русском
        public string TypeText
        {
            get
            {
                return HumanoidType == HumanoidTypes.elf ? "эльф"
                    : (HumanoidType == HumanoidTypes.ork ? "орк"
                    : (HumanoidType == HumanoidTypes.human ? "человек" : "дварф"));
            }
        }
        // Интеллект
        int _intelligence;
        public int Intelligence 
        {
            get => _intelligence;
            set
            {
                if (value < 0) throw new ArgumentException("Интеллект не может быть ниже нуля");
                _intelligence = value;
            }
        }
        // Инвентарь 
        public Inventory Inventory { get; set; }
        // 
        Random rnd = new Random();
        public int GetAttack(int bonus) => rnd.Next(100, 500) * Intelligence / 100 + bonus;

        public void Wounds(int damage)
        {
            double coefficient = HumanoidType == HumanoidTypes.elf ? 1.1
                    : (HumanoidType == HumanoidTypes.dwarf ? 0.9 : 1);
            damage = (int)(damage * coefficient);
            if (HP > damage) HP -= damage;
            else HP = 0;
        }
    }
}
