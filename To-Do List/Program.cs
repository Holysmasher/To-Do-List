using System.Text.Json;
using System.IO;
using To_Do_List;

List<TodoTask> tasks = LoadTasks();


List<TodoTask> LoadTasks()
{
    if (!File.Exists("tasks.json"))
    {
        return new List<TodoTask>();
    }

    string json = File.ReadAllText("tasks.json");
    return JsonSerializer.Deserialize<List<TodoTask>>(json);
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
}

void AddTask()
{
    Console.WriteLine("Enter the title of the new task:");
    string title = Console.ReadLine();

    var newTask = new TodoTask
    {
        Title = title,
        IsCompleted = false
    };

    tasks.Add(newTask);

    SaveTasks(tasks);

    Console.WriteLine($"Task '{title}' added successfully!");
    Console.WriteLine("Press any key to return to the menu.");
    Console.ReadKey();
}

void SaveTasks(List<TodoTask> tasks)
{
    string json = JsonSerializer.Serialize(tasks);
    File.WriteAllText("tasks.json", json);
}

void Menu(List<TodoTask> tasks)
{
    Console.WriteLine("Welcome to the To-Do List Application!");
    Console.WriteLine("What would you like to do today?");

    bool programRunning = true;
    do
    {
        Console.WriteLine($@"
        A. Add a new task
        B. View all tasks
        C. Mark a task as completed
        D. Remove a task
        E. Quit
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
                Console.WriteLine("Goodbye!");
                programRunning = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    } while (programRunning);
}

Menu(tasks);