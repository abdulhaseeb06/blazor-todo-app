using System.ComponentModel.DataAnnotations;
using TodoApp.Data;

namespace TodoApp.Models.Todos
{
    public class CreateTodoDto
    {
        [Required]
        [MaxLength(Todo.MaxTitleLength)]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
