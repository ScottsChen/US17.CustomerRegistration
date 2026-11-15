
using US17.CustomerRegistration.Repositories;
using US17.CustomerRegistration.Services;

// Skapa repository och service
var repository = new CustomerRepository();
var service = new CustomerService(repository);

// Registrera kund
Console.WriteLine("=== Registrera ny kund ===");

Console.Write("Ange förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Ange efternamn: ");
string lastName = Console.ReadLine() ?? "";

Console.Write("Ange e-post: ");
string email = Console.ReadLine() ?? "";

Console.Write("Ange telefonnummer: ");
string phone = Console.ReadLine() ?? "";

// Försök skapa och spara kunden
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
    Console.WriteLine($"Namn: {customer.FirstName} {customer.LastName}");
    Console.WriteLine($"E-post: {customer.Email}");
    Console.WriteLine($"Telefon: {customer.Phone}");

    Console.WriteLine($"Antal sparade kunder: {repository.GetCustomerCount()}");
}
catch (ArgumentException ex)
{
    Console.WriteLine();
    Console.WriteLine($"Registreringen misslyckades: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();
