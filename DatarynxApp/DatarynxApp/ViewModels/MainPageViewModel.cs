using DatarynxApp.Interfaces;
using DatarynxApp.Model;
using DatarynxApp.SqliteDatabase;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatarynxApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "To-Do List";
        }

        internal void GetSqliteDB()
        {
            _TODORepositor = new TODORepositor();
            _ = GetToDOListAsync();
        }

        private async Task GetToDOListAsync()
        {
            // Checking if data is available in sqlite database. -
            // if is avaiable then get the data from sqlite db
            if (_TODORepositor.GetAllToDoItemssData().Count !=0)
            {
                ToDoListItemSources = _TODORepositor.GetAllToDoItemssData();
            }
            else
            {
                // Here get the data from local JSON file from Utils folder.
                ToDoListItemSources = await GetJsonData();
                foreach (ToDoItems item in ToDoListItemSources)
                {
                    _TODORepositor.InsertToDoItems(item);
                }
            }
        }

        private List<ToDoItems> _ToDoListItemSources;
        public List<ToDoItems> ToDoListItemSources
        {
            get { return _ToDoListItemSources; }
            set
            {
                _ToDoListItemSources = value;
                NotifyPropertyChanged("ToDoListItemSources");
            }
        }


        private async Task<List<ToDoItems>> GetJsonData()
        {
            string jsonFileName = $"Utils.todolist.json";
            List<ToDoItems> ObjContactList = new List<ToDoItems>();
            var assembly = typeof(MainPageViewModel).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                //Converting JSON Array Objects into generic list    
                ObjContactList = JsonConvert.DeserializeObject<List<ToDoItems>>(jsonString);
            }
            return ObjContactList.ToList();
        }
    }
}
