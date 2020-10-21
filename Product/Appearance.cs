using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Entity
{
    [Serializable]
    public class Appearance
    {
        public string race;
        public string arms;
        public string size;

        public override string ToString()
        {
            return $"race: {race}, arms: {arms}, size: {size}";
        }
    }
}
