namespace ToDoApp.Presentation;

/// <summary>
/// Interface for displaying messages on the console with different colors based on the message type.
/// </summary>
public interface IConsoleDisplay
{
    /// <summary>
    /// Displays an informational message in white color.
    /// </summary>
    /// <param name="message">The message to display.</param>
    void DisplayInfo(string message);

    /// <summary>
    /// Displays an error message in red color.
    /// </summary>
    /// <param name="message">The message to display.</param>
    void DisplayError(string message);

    /// <summary>
    /// Displays a success message in green color.
    /// </summary>
    /// <param name="message">The message to display.</param>
    void DisplaySuccess(string message);

    /// <summary>
    /// Displays a warning message in yellow color.
    /// </summary>
    /// <param name="message">The message to display.</param>
    void DisplayWarning(string message);
}