namespace PlatziEntityFramework.Model
{
    public class task
    {
        public Guid TaskId { get; set; }

        public Guid CategoryId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        public DateTime DateCreate { get; set; }

        public Category Category { get; set; }

    }
}

public enum Priority
{
    Low,

    Medium, 
    
    High
}
