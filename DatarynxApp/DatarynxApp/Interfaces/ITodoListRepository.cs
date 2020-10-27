using DatarynxApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxApp.Interfaces
{
    public interface ITodoListRepository
    {
        List<ToDoItems> GetAllToDoItemssData();

        // Delete all ToDoItems Data  
        void DeleteAlToDoItems();

        // Insert new ToDoItems to DB   
        void InsertToDoItems(ToDoItems toDoItems);

    }
}
