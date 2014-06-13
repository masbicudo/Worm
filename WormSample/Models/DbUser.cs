namespace WormSample.Models
{
    public class DbUser : DbPerson
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}