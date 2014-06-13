namespace WormSample.Models
{
    public class DbAddress : DbEntity
    {
        public string Country { get; set; }

        public string Place { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string Code { get; set; }
    }
}