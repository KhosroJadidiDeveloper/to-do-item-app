namespace ToDoApp.Infrastructure;


using ToDoApp.Domain;

/// <summary>
/// Interface for a repository that manages to-do items.
/// </summary>
public interface IToDoItemRepository
{
    /// <summary>
    /// Gets a to-do item by its ID.
    /// </summary>
    /// <param name="id">The ID of the to-do item to get.</param>
    /// <returns>The to-do item with the specified ID, or null if it does not exist.</returns>
    ToDoItem Get(int id);

    /// <summary>
    /// Gets all to-do items.
    /// </summary>
    /// <returns>An enumerable collection of all to-do items.</returns>
    IEnumerable<ToDoItem> GetAll();

    /// <summary>
    /// Adds a new to-do item.
    /// </summary>
    /// <param name="item">The to-do item to add.</param>
    void Add(ToDoItem item);

    /// <summary>
    /// Adds multiple to-do items.
    /// </summary>
    /// <param name="items">The to-do items to add.</param>
    void AddMany(IEnumerable<ToDoItem> items);

    /// <summary>
    /// Updates an existing to-do item.
    /// </summary>
    /// <param name="item">The to-do item to update.</param>
    void Update(ToDoItem item);

    /// <summary>
    /// Deletes a to-do item by its ID.
    /// </summary>
    /// <param name="id">The ID of the to-do item to delete.</param>
    void Delete(int id);

    /// <summary>
    /// Deletes all to-do items.
    /// </summary>
    void DeleteAll();
}