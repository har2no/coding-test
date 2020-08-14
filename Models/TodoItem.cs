namespace Suhartono_Backend.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string DateExp { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double PercentComplete { get; set; }
    }
}
