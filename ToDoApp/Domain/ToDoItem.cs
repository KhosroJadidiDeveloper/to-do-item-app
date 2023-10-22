namespace ToDoApp.Domain;

/// <summary>
/// Represents a to-do item.
/// </summary>
public class ToDoItem
{
    /// <summary>
    /// Gets or sets the unique identifier of the to-do item.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the to-do item.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the description of the to-do item.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the to-do item is done.
    /// </summary>
    public bool IsDone { get; set; }
}