namespace ToDoApp.Infrastructure;


using ToDoApp.Domain;

public interface IToDoItemRepository
{
    ToDoItem Get(int id);
    IEnumerable<ToDoItem> GetAll();
    void Add(ToDoItem item);
    void AddMany(IEnumerable<ToDoItem> items);
    void Update(ToDoItem item);
    void Delete(int id);
    void DeleteAll();
}