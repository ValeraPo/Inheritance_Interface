using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    class Item
    {
        // Конструкторы
        public Item() { }

        public Item(string name) : this()
        {
            Name = name;
        }
        public Item(string name, ItemTypes item_type) : this(name)
        {
            ItemType = item_type;
        }
        public Item(string name, ItemTypes item_type, int price)
            : this(name, item_type)
        {
            Price = price;
        }
        public Item(string name, ItemTypes item_type, int price, int weight)
            : this(name, item_type, price)
        {
            Weight = weight;
        }
        // Название
        public string Name
        {
            get => Name; 
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой");
                Name = value;
            }
        }
        // Тип инвентаря
        public ItemTypes ItemType { get; set; }
        public string TypeText
        {
            get
            {
                return (ItemType == ItemTypes.sword ? "меч"
                    : (ItemType == ItemTypes.shield ? "щит"
                    : (ItemType == ItemTypes.bow ? "лук"
                    : (ItemType == ItemTypes.spear ? "копье"
                    : (ItemType == ItemTypes.axe ? "топор"
                    : (ItemType == ItemTypes.armer ? "доспех"
                    : (ItemType == ItemTypes.helmet ? "шлем"
                    : null)))))));
            }
        }
        // Цена
        public int Price
        {
            get => Price;
            set
            {
                if (value < 0)
                    throw new Exception("Цена не может быть отрицательной");
                Price = value;
            }
        }
        // Вес
        public int Weight
        {
            get => Weight;
            set
            {
                if (value <= 0 )
                    throw new Exception("Вес не может быть отрицательным или равным нулю");
                Weight = value;
            }
        }
    }
}
