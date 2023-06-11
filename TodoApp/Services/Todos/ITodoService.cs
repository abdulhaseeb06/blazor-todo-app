using TodoApp.Data;

namespace TodoApp.Services.Todos
{
    public interface ITodoService
    {
        Task<Todo?> Get(int id);
        void Create(Todo todo);
        Task<Todo?> Update(int id, Todo todo);
        void Delete(int id);
        Task<List<Todo>> GetAll();
    }
}
