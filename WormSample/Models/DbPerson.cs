using System.Collections.Generic;

namespace WormSample.Models
{
    public class DbPerson : DbEntity
    {
        public string Name { get; set; }

        public DbGender Gender { get; set; }

        public List<DbPhone> Phones { get; set; }

        public List<DbPhone> Emails { get; set; }

        public List<DbAddress> Addresses { get; set; }
    }
}