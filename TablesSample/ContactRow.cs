namespace TablesSample
{
    public abstract class ContactRow
    {
        public int ContactId { get; set; }

        public int OwnerPersonId { get; set; }

        public int Description { get; set; }
    }
}