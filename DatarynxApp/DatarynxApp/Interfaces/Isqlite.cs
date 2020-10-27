using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatarynxApp.Interfaces
{
    public interface Isqlite
    {
        SQLiteConnection GetConnection();
    }
}
