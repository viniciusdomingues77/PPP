using Company.Domain.Shared;

namespace Company.Domain.Entities
{
    public class Company: EntityBase
    {
     
        public string Name { get; set; }
        public string WelcomeMessage { get; set; }
     

    }
}