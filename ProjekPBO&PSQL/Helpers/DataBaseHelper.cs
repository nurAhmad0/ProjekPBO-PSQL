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
        "Port=5432;" +  // port default PostgreSQL
        "Database=PreenntasiPBO;" +  // nama database
        "Username=postgres;" +  // username
        "Password=SUNGKEM0711";  // password


        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
