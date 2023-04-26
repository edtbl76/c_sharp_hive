using System;

namespace SavingInterface;

internal static class Program {
    public static void Main(string[] args)
    {
        var todoList = new TodoList();
        todoList.Add("Try to do consulting");
        todoList.Add("Clean Basement");
        todoList.Add("forget C#");

        var passwordManager = new PasswordManager("gravyboat", true);
        
        todoList.Display();
        passwordManager.Display();
        
        todoList.Reset();
        passwordManager.Reset();
        
        todoList.Display();
        passwordManager.Display();
    }
}