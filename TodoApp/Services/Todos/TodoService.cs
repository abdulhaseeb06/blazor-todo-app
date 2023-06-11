using Microsoft.EntityFrameworkCore;
using TodoApp.Data;

namespace TodoApp.Services.Todos
{
    public class TodoService : ITodoService
    {
        private readonly ApplicationDBContext _dbContext;

        public TodoService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = _dbContext.Todos.FirstOrDefault(x => x.Id == id);
            if (todo is not null)
                _dbContext.Remove(todo);
            _dbContext.SaveChanges();
        }

        public async Task<List<Todo>> GetAll()
        {
            return await _dbContext.Todos.ToListAsync();
        }

        public async Task<Todo?> Update(int id, Todo todo)
        {
            var previousTodo = await _dbContext.Todos.FirstOrDefaultAsync(x => x.Id == id);
            if (previousTodo is not null)
            {
                previousTodo.Title = todo.Title;
                previousTodo.IsCompleted = todo.IsCompleted;
                _dbContext.Update(previousTodo);
                _dbContext.SaveChanges();
                return previousTodo;
            }
            return null;
        }
    }
}
