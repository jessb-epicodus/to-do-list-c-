using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList {
  class Program {    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();
      host.Run();
    }
  }
}

    // Console.WriteLine("Welcome to the To Do List");
    // List<Item> ToDoListItems = new List<Item> {};
    // bool done = false;
    // while (done == false)
    // {
    //   Console.WriteLine("What would you like to do? (Add/View/Exit)");
    //   string userInput = Console.ReadLine().ToUpper();
      
    //   if (userInput == "ADD")
    //   {
    //     Console.WriteLine("Please enter a item on your to do list: ");
    //     string userItem = Console.ReadLine();
    //     Item newItem1 = new Item(userItem);
    //     ToDoListItems.Add(newItem1);
    //   }
    //   else if (userInput == "VIEW")
    //   {
    //     Console.WriteLine("To Do List:");
    //     foreach(Item element in ToDoListItems)
    //     {
    //       Console.WriteLine(element.Description);
    //     }
    //   }
    //   else if (userInput == "EXIT")
    //   {
    //     done = true;
    //     Console.WriteLine("goodbye:)");
    //   }
    // }