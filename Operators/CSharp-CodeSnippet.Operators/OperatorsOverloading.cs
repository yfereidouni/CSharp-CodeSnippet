using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CodeSnippet.Operators
{
    public class OperatorsOverloading : IEquatable<OperatorsOverloading>
    {
        public int InnerValue { get; set; }

        public override string ToString() => InnerValue.ToString();

        public static OperatorsOverloading operator +(OperatorsOverloading p1, OperatorsOverloading p2)
            => new OperatorsOverloading() { InnerValue = p1.InnerValue + p2.InnerValue };

        public static OperatorsOverloading operator -(OperatorsOverloading p1, OperatorsOverloading p2)
            => new OperatorsOverloading() { InnerValue = p1.InnerValue - p2.InnerValue };

        public static bool operator ==(OperatorsOverloading p1, OperatorsOverloading p2)
            => p1.InnerValue == p2.InnerValue;

        public static bool operator !=(OperatorsOverloading p1, OperatorsOverloading p2)
            => !(p1 == p2);

        public bool Equals(OperatorsOverloading? other)
            => this == other;

        public override bool Equals(object obj)
            => Equals(obj as OperatorsOverloading);

        public override int GetHashCode()
            => this.InnerValue.GetHashCode();

    }
}
