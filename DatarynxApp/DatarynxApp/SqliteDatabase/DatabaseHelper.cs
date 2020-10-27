using DatarynxApp.Interfaces;
using DatarynxApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DatarynxApp.SqliteDatabase
{
    public class DatabaseHelper
    {
        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "DatarynxDB.db";

        public DatabaseHelper()
        {
            sqliteconnection = DependencyService.Get<Isqlite>().GetConnection();

            sqliteconnection.CreateTable<ToDoItems>();

        }
        // Get All Contact data      
        public List<ToDoItems> GetAllContactsData()
        {
            return (from data in sqliteconnection.Table<ToDoItems>()
                    select data).ToList();
        }

        // Insert new Contact to DB   
        public void InsertContact(ToDoItems contact)
        {
            sqliteconnection.Insert(contact);
        }

        // Delete all Contacts Data  
        public void DeleteAllContacts()
        {
            sqliteconnection.DeleteAll<ToDoItems>();
        }
    }
}
