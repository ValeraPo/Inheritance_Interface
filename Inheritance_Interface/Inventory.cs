using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    class Inventory : IEnumerable
    {
        int _max_size = 5;
        private LinkedList<Item> _inventory;
        // Конструкторы
        public Inventory(Humanoid humanoid)
        {
            _inventory = new LinkedList<Item>();
            Owner = humanoid.Name;
        }
        public Inventory(int roominess, Humanoid humanoid) : this(humanoid) => _max_size = roominess;

        //владелец инвентаря
        public string Owner
        {
            get => Owner;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Строка не может быть пустой");
                Owner = value;
            }
        }
        //размер
        public int Size => _inventory.Count;
        //предельный размер
        public int MaxSize
        {
            get => _max_size;
            set
            {
                if (value < 0) throw new ArgumentException("Максимальный размер не может быть отрицацтельным");
                _max_size = value;
            }
        }
        //добавить предмет
        public void AddItem(Item item)
        {
            if (Size == MaxSize)
                throw new InvalidOperationException("Инвентарь заполнен полностью.");
            _inventory.AddLast(item);
        }
        //удалить предмет
        public void Remove(Item item) => _inventory.Remove(item);

        public IEnumerator GetEnumerator() => _inventory.GetEnumerator();

    }
}
