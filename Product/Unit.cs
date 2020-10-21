using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Entity
{
    [Serializable]
    public class Unit
    {
        public string name;
        public Appearance appearance;

        public override string ToString()
        {
            return $"name: {name}, appearance: {appearance}";
        }
    }
}
