using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace ProjekPBO_PSQL
{
    class DataBaseHelper
    {
        string connString =
        "Host=localhost;" +  // server PostgreSQL
        "Port=5432;" +  // port default PostgreSQL
        "Database=Projek_S2;" +  // nama database
        "Username=postgres;" +  // username
        "Password=SUNGKEM0711";  // password
    }

    public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
