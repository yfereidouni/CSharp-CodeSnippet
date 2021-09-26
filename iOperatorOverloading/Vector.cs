using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iOperatorOverloading
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static bool operator ==(Vector v1, Vector v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            var vector = (Vector)obj;

            return (vector.X == this.X && vector.Y == this.Y && vector.Z == this.Z);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
