using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Interface
{
    public interface ICombatan
    {
        public void Wounds(int damage);
        public int GetAttack(int bonus);
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

    }
}
