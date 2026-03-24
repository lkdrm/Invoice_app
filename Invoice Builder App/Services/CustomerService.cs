using Invoice_Builder_App.Models;

namespace Invoice_Builder_App.Services;

public class CustomerService
{
    private List<Customer> CustomersList { get; init; } = [];

    public void AddCustomer(Customer customer) => CustomersList.Add(customer);

    public List<Customer> GetCustomers() => CustomersList;
}
