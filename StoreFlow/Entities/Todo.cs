namespace StoreFlow.Entities
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string? Priority { get; set; }
    }
}
