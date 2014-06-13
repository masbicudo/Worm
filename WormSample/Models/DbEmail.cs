namespace WormSample.Models
{
    public class DbEmail : DbEntity
    {
        public string Description { get; set; }

        public string EmailAddress { get; set; }

        public int OwnerId { get; set; }
    }
}