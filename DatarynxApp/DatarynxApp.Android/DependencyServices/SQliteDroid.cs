
using DatarynxApp.Droid.DependencyServices;
using DatarynxApp.Interfaces;
using DatarynxApp.SqliteDatabase;
using SQLite;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQliteDroid))]
namespace DatarynxApp.Droid.DependencyServices
{
    public class SQliteDroid : Isqlite
    {
        public SQLiteConnection GetConnection()
        {
            var dbase = DatabaseHelper.DbFileName;
            var dbpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbpath, dbase);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}
