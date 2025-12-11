
Console.WriteLine("Welcome to the To-Do List Application!");
Console.WriteLine("What would you like to do today?");
Console.WriteLine($@"
A. Add a new task
B. View all tasks
C. Mark a task as completed
D. Remove a task
E. Save tasks to file
F. Quit
");
string choice = Console.ReadLine();

switch (choice.Trim().ToUpper())
{
    case "A":
        AddTask();
        break;
    case "B":
        ViewTasks();
        break;
    case "C":
        MarkTaskCompleted();
        break;
    case "D":
        RemoveTask();
        break;
    case "E":
        SaveTasksToFile();
        break;
    case "F":
        Console.WriteLine("Goodbye!");
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
}

void SaveTasksToFile()
{
    throw new NotImplementedException();
}

void RemoveTask()
{
    throw new NotImplementedException();
}

void MarkTaskCompleted()
{
    throw new NotImplementedException();
}

void ViewTasks()
{
    throw new NotImplementedException();
}

void AddTask()
{
    throw new NotImplementedException();
}