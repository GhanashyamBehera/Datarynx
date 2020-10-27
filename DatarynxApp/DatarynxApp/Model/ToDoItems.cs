using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxApp.Model
{
 //   [Table("ToDoItems")]
    public class ToDoItems
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonProperty("week-no")]
        public string WeekNo { get; set; }

        [JsonProperty("week-date")]
        public string WeekDate { get; set; }

        [JsonProperty("store-name")]
        public string StoreName { get; set; }

        [JsonProperty("store-address")]
        public string StoreAddress { get; set; }

        [JsonProperty("coding-type")]
        public string CodingType { get; set; }

        [JsonProperty("Task-State")]
        public string TaskState { get; set; }
    }
}
