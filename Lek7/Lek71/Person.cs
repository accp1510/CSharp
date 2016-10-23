using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek71
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            if (this.GetHashCode()!=obj.GetHashCode())
            {
                return false;
            }
            return true;
        }

    }
}
