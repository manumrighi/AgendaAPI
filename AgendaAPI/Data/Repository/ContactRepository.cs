using AgendaAPI.Entities;

namespace AgendaAPI.Data.Repository
{
    public class ContactRepository
    {
        public static List<Contact> FakeContacts = new List<Contact>()
        {
            new Contact()
            {
                Description = "el vale",
                Name = "Vale",
                CelularNumber = 3458054230,
                Id = 1
            },
            new Contact()
            {
                Description = "el dino",
                Name = "Dino",
                CelularNumber = 05986394584,
                Id = 2
            },
            new Contact()
            {
                Description = "el gero",
                Name = "Gero",
                CelularNumber = 9827432894,
                Id = 3
            }
        };

        public List<Contact> GetAllContacts()
        {
            return FakeContacts;
        }

    }
}
