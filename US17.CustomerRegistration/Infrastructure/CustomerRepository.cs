
using US17.CustomerRegistration.Domain;

namespace US17.CustomerRegistration.Repositories;

public class CustomerRepository
{
    private readonly List<Customer> _customers = new();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public int GetCustomerCount()
    {
        return _customers.Count;
    }

}

