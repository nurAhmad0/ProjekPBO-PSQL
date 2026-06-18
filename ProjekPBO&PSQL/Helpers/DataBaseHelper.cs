using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace ProjekPBO_PSQL.Helpers
{
    static class DataBaseHelper
    {
        static string connString =
        "Host=localhost;" +  // server PostgreSQL
        "Port=8989;" +  // port default PostgreSQL
        "Database=databaseprojek;" +  // nama database
        "Username=postgres;" +  // username
        "Password=TeknologInformasi89";  // password


        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
