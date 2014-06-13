namespace WormSample.Models
{
    public class DbFixedPhone : DbPhone
    {
        public string Description { get; set; }

        public string Number { get; set; }

        public DbAddress Address { get; set; }
    }
}