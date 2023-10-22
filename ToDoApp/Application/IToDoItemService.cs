using ToDoApp.Domain;

namespace ToDoApp.Application;

/// <summary>
/// Interface for a service that manages to-do items.
/// </summary>
public interface IToDoItemService
{
    /// <summary>
    /// Gets a to-do item by its ID.
    /// </summary>
    /// <param name="id">The ID of the to-do item to get.</param>
    /// <returns>The to-do item with the specified ID.</returns>
    ToDoItem GetById(int id);

    /// <summary>
    /// Gets a to-do item by its title.
    /// </summary>
    /// <param name="title">The title of the to-do item to get.</param>
    /// <returns>The to-do item with the specified title.</returns>
    ToDoItem GetByTitle(string title);

    /// <summary>
    /// Gets a to-do item by its description.
    /// </summary>
    /// <param name="description">The description of the to-do item to get.</param>
    /// <returns>The to-do item with the specified description.</returns>
    ToDoItem GetByDescription(string description);

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
    /// Updates the title of a to-do item.
    /// </summary>
    /// <param name="id">The ID of the to-do item to update.</param>
    /// <param name="title">The new title for the to-do item.</param>
    void UpdateTitle(int id, string title);

    /// <summary>
    /// Updates the description of a to-do item.
    /// </summary>
    /// <param name="id">The ID of the to-do item to update.</param>
    /// <param name="description">The new description for the to-do item.</param>
    void UpdateDescription(int id, string description);

    /// <summary>
    /// Sets a to-do item to "done" status.
    /// </summary>
    /// <param name="id">The ID of the to-do item to set to "done".</param>
    void SetToDone(int id);

    /// <summary>
    /// Sets a to-do item to "not done" status.
    /// </summary>
    /// <param name="id">The ID of the to-do item to set to "not done".</param>
    void SetToNotDone(int id);

    /// <summary>
    /// Deletes a to-do item.
    /// </summary>
    /// <param name="id">The ID of the to-do item to delete.</param>
    void Delete(int id);

    /// <summary>
    /// Deletes multiple to-do items.
    /// </summary>
    /// <param name="ids">The IDs of the to-do items to delete.</param>
    void DeleteMany(IEnumerable<int> ids);

    /// <summary>
    /// Deletes all to-do items.
    /// </summary>
    void DeleteAll();
}