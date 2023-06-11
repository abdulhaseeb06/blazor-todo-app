using System.ComponentModel.DataAnnotations;
using TodoApp.Data;

namespace TodoApp.Models.Todos
{
    public class UpdateTodoDto
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        [MaxLength(Todo.MaxTitleLength)]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
