using System.ComponentModel.DataAnnotations;

namespace TodoApp.Data
{
    public class Todo
    {
        public const int MaxTitleLength = 50;
        public int Id { get; set; }
        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
