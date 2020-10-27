using DatarynxApp.Interfaces;
using DatarynxApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxApp.SqliteDatabase
{
    public class TODORepositor : ITodoListRepository
    {
        DatabaseHelper _databaseHelper;
        public TODORepositor()
        {
            _databaseHelper = new DatabaseHelper();
        }
     

        public List<ToDoItems> GetAllToDoItemssData()
        {
            return _databaseHelper.GetAllContactsData();
        }

        public void DeleteAlToDoItems()
        {
            _databaseHelper.DeleteAllContacts();
        }

        public void InsertToDoItems(ToDoItems toDoItems)
        {
            _databaseHelper.InsertContact(toDoItems);
        }
    }
}
