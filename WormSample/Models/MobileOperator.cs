namespace WormSample.Models
{
    public class MobileOperator
    {
        public string Name { get; private set; }

        public MobileOperator(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
