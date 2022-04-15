using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.HierarchicalData;

public class Person
{
    private readonly ILazyLoader lazyLoader;

    //public Person(string firstName)
    //{
    //    FirstName = "Mr. " + firstName;
    //    LastName = "My LastName";
    //}
    private readonly Action<object, string> action;
    public Person(Action<object,string> action)
    {
        this.action = action;
    }
    public Person(ILazyLoader lazyLoader)
    {
        this.lazyLoader = lazyLoader;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private List<Address> addresses;
    public List<Address> Addresses { get=> lazyLoader.Load(this,ref addresses); set => addresses = value; }

}
public class Address
{
    public int Id { get; set; }
    public string City { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
}
