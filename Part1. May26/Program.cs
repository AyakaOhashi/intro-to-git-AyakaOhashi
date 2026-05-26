using CompanyManagement.Models;

namespace CompanyManagement
{
    class Program
    {
        static void Main()
        {
            Client client1 = new Client("SnowTech Solutions", "info@snowtech.com");

            Client client2 = new Client(
                Guid.NewGuid(),
                "Mountain Market",
                "contact@mountain.com",
                DateTime.Now,
                true
            );

            Console.WriteLine(client1.GetSummary());
            Console.WriteLine();

            client2.Deactivate();
            Console.WriteLine(client2.GetSummary());
        }
    }
}