using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxApp.Model
{
    [Table("ToDoItemsSqite")]
    public class ToDoItemsSqite
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string WeekNo { get; set; }

        public string WeekDate { get; set; }

        public string StoreName { get; set; }

        public string StoreAddress { get; set; }

        public string CodingType { get; set; }

        public string TaskState { get; set; }
    }
}
