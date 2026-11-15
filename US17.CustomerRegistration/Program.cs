
using US17.CustomerRegistration.Repositories;
using US17.CustomerRegistration.Services;

var repository = new CustomerRepository();
var service = new CustomerService(repository);

Console.WriteLine("Registrera ny kund");

bool registered = false;

while (!registered)
{
    Console.WriteLine();

    Console.Write("Ange förnamn: ");
    string firstName = Console.ReadLine() ?? "";

    Console.Write("Ange efternamn: ");
    string lastName = Console.ReadLine() ?? "";

    Console.Write("Ange e-post: ");
    string email = Console.ReadLine() ?? "";

    Console.Write("Ange telefonnummer: ");
    string phone = Console.ReadLine() ?? "";

    try
    {
        var customer = service.CreateCustomer(
            firstName,
            lastName,
            email,
            phone
        );

        Console.WriteLine();
        Console.WriteLine("Kunden har registrerats!");
        Console.WriteLine($"Kund-ID: {customer.Id}");
        Console.WriteLine($"Namn: {customer.FirstName} {customer.LastName}");
        Console.WriteLine($"E-post: {customer.Email}");
        Console.WriteLine($"Telefon: {customer.Phone}");
        Console.WriteLine($"Antal sparade kunder: {repository.GetCustomerCount()}");

        registered = true;
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine();
        Console.WriteLine($"Registreringen misslyckades: {ex.Message}");
        Console.WriteLine("Försök igen.");
    }
}

Console.WriteLine();
Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();
