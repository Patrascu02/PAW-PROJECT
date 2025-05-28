namespace PAW_CATALOG_PROJ.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int FromId { get; set; }
        public User From { get; set; } = null!;

        public int To { get; set; }
        public User Recipient { get; set; } = null!;

        public string Content { get; set; } = null!;
    }

}
