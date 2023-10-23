# to-do-item-app
A simple console app assignement project for managing to-do tasks

## The goal:
- Create a simple console app for managing to-do tasks.
- The app should have the ability to save and load the tasks in a in-memory database(IToDoItemRepository). This means that the tasks will be lost when the app is closed.
- The app should be able to perform the To-Do related action that have been specified in IToDoItemService with the help of IToDoItemRepository.
- The app should be able to handle user input as specified in IUserInputService.
- The app should be able to display the result of the user actions as specified in IConsoleDisplay.

## An example of the app flow:
Note: This is just an Example for adding a TODO. Rest of the actions should be implemented as well.

- The app starts and displays the main menu.
- The user selects the "Add new task" option.
- The app asks for the task name.
- The user enters the task name.
- The app asks for the task description.
- The user enters the task description.
- The todo item is saved in the database.

The above flow is just an example, you can implement the app in any way you want.


## What to do:
- Clone this repository.
- Create a new branch.
- Use the provided code as a starting point.
- NOTHING is set in stone, you can change anything you want.

## Hints:
- Notice that every action that the user can perform is specified in the IToDoItemService interface. 

- However, this interface contains the Business Logic of the app (google business logic). 

- You may not expose the business logic directly to the user (For security purposes). So, think of a way to hide the business logic from the user. 

- Perhaps a new interface that is used to communicate with the user, or maybe modify the existing interface IConsoleDisplay, or something else all together.

- If you feel that the app needs error handling, then add it. The same goes for input validation, or  any other feature that you think is missing.

- Also notice that the provided code is not perfect, you may need to change it to fit your needs. It might not cover all the cases, so you may need to add more code to it.

- One good suggestion would be to start from the base, and work your way up:
Domain is in the base, and it dpeneds on nothing. Both Infrastructure and Application depend on Domain.  Presentation Depends on Application. So, you can start from Domain, then Infrastructure and Application, and finally Presentation.