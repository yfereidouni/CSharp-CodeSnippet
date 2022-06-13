namespace iSecurity.CSRF.GoodSite.Models;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Emtiaz { get; set; }
}

public interface ICustomerRepository
{
    Customer GetCustomer(int id);
    void SetEmtiaz(int customerId, int newEmtiaz);
    List<Customer> GetCustomers();
}

public class InMemoryCustomerRepository : ICustomerRepository
{
    private List<Customer> customers = new List<Customer>()
    {
        new Customer{Id =1, FullName = "Yasser Fereidouni", Emtiaz=100 },
        new Customer{Id =2, FullName = "Farid Taheri", Emtiaz=80 },
        new Customer{Id =3, FullName = "Masoud Ghorbani", Emtiaz=90 },
        new Customer{Id =4, FullName = "Mohammad Abbasi", Emtiaz=70 },
        new Customer{Id =5, FullName = "Shervin Souri", Emtiaz=45 },
        new Customer{Id =6, FullName = "Soroush Sarabi", Emtiaz=25 },
        new Customer{Id =7, FullName = "Karim Mehrabi", Emtiaz=50 },
    };

    public InMemoryCustomerRepository()
    {

    }

    public Customer GetCustomer(int id)
    {
        return customers.FirstOrDefault(c => c.Id == id);
    }

    public void SetEmtiaz(int customerId, int newEmtiaz)
    {
        customers.FirstOrDefault(c => c.Id == customerId).Emtiaz = newEmtiaz;
    }

    public List<Customer> GetCustomers()
    {
        return customers.ToList();
    }
}
