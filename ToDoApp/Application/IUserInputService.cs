namespace ToDoApp.Application;

/// <summary>
/// Interface for a service that provides user input functionality.
/// </summary>
public interface IUserInputService
{
    /// <summary>
    /// Gets a string input from the user.
    /// </summary>
    /// <returns>The string input provided by the user.</returns>
    string GetStringInput();

    /// <summary>
    /// Gets a numeric input from the user.
    /// </summary>
    /// <returns>The numeric input provided by the user.</returns>
    int GetNumericInput();
}