namespace StoreFlow.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageDetail { get; set; }
        public string SenderNameSurname { get; set; }
        public string SenderImageUrl { get; set; }
        public DateTime Datetime { get; set; }
        public bool IsRead { get; set; }
    }
}
