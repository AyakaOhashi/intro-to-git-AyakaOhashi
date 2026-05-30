namespace CompanyManagement.Models
{
    public class Client
    {
        public Guid Id;
        public string Name;
        public string Email;
        public DateTime CreatedOn;
        private bool IsActive;

        public Client(string name, string email)
        {
            Id = Guid.NewGuid();//create random id
            Name = name;
            Email = email;
            CreatedOn = DateTime.Now;//write time
            IsActive = true;
        }

        public Client(Guid id, string name, string email, DateTime createdOn, bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            CreatedOn = createdOn;
            IsActive = isActive;
        }

        public string GetSummary()
        {
            string status;

            if (IsActive)
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }

            return "Client: " + Name +
                   "\nEmail: " + Email +
                   "\nStatus: " + status +
                   "\nCreated: " + CreatedOn;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
        public bool GetIsActive()
        {
            return IsActive;
        }
    }
}