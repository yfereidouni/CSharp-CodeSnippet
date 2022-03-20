using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecords.PositionalRecords
{
    public record PersonPositionalRecord01
    {
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record PersonPositionalRecord02(int Id, string FirstName, string LastName);
    public record PersonPositionalRecord03(int Id, string FirstName, string LastName)
    {
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
