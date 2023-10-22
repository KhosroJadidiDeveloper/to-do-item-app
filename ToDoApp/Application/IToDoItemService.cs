using ToDoApp.Domain;

namespace ToDoApp.Application;

public interface IToDoItemService
{
    ToDoItem GetById(int id);
    ToDoItem GetByTitle(string title);
    ToDoItem GetByDescription(string description);
    IEnumerable<ToDoItem> GetAll();
    void Add(ToDoItem item);
    void AddMany(IEnumerable<ToDoItem> items);
    void UpdateTitle(int id, string title);
    void UpdateDescription(int id, string description);
    void SetToDone(int id);
    void SetToNotDone(int id);
    void Delete(int id);
    void DeleteMany(IEnumerable<int> ids);
    void DeleteAll();
}