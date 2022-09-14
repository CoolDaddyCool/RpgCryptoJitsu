namespace RpgCryptoJitsu.Models
{
    public class Adventure
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int XpRewords { get; set; }
        public int GoldReword { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }


        public Adventure()
        {

        }
    }
}
