using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.RelationConfigurationExtera.OwnedTypeSample;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    public Car Car { get; set; }
    public List<Money> Money { get; set; }
}
public class Car
{
    public string CarName { get; set; }
}

public class Money
{
    public int Id { get; set; }
    public int Value { get; set; }
}
