using CompanyManagement.Models;

namespace CompanyManagement.Services
{
    public class ClientRepository
    {
        private Dictionary<Guid, Client> clients =　new Dictionary<Guid, Client>();

        public void AddClient(Client client)
        {
            clients.Add(client.Id, client);
        }

        public Client? GetClientById(Guid id)
        {
            if (clients.ContainsKey(id))
            {
                return clients[id];
            }

            return null;
        }

        public List<Client> GetAllClients()
        {
            return new List<Client>(clients.Values);
        }

        public List<Client> GetActiveClients()
        {
            List<Client> activeClients =
                new List<Client>();

            foreach (Client client in clients.Values)
            {
                if (client.GetIsActive())
                {
                    activeClients.Add(client);
                }
            }

            return activeClients;
        }
    }
}