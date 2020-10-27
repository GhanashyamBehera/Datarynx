using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DatarynxApp.Interfaces;
using DatarynxApp.iOS.DependencyServices;
using Foundation;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(SQliteiOS))]
namespace DatarynxApp.iOS.DependencyServices
{
    public class SQliteiOS : Isqlite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "DatarynxDB";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}