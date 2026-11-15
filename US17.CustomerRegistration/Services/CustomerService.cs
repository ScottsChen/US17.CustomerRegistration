
using US17.CustomerRegistration.Domain;
using US17.CustomerRegistration.Repositories;

namespace US17.CustomerRegistration.Services;

public class CustomerService
{
    private readonly CustomerRepository _repository;

    public CustomerService(CustomerRepository repository)
    {
        _repository = repository;
    }

    public Customer CreateCustomer(string firstName, string lastName,
                                   string email, string phone)
    {
        var customer = new Customer(firstName, lastName, email, phone);

        _repository.AddCustomer(customer);

        return customer;
    }
}


