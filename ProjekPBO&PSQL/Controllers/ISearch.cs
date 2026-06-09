using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    interface ISearch<T>
    {
        List<T> CariBerdasarkanID(int id);
        List<T> CariBerdasarkanNama(string nama);
    }
}
