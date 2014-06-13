using MemoryTables;

namespace TablesSample
{
    public class SampleDatabase : IDatabase
    {
        public ITable<AddressRow> AddressTable { get; set; }

        public ITable<EmailRow> EmailTable { get; set; }

        public ITable<PersonRow> PersonTable { get; set; }

        public ITable<PhoneRow> PhoneTable { get; set; }

        public ITable<GenderRow> GenderTable { get; set; }
    }
}