namespace ToDoApp.Presentation;

public interface IConsoleDisplay
{
    void DisplayInfo(string message);
    void DisplayError(string message);
    void DisplaySuccess(string message);
    void DisplayWarning(string message);
}