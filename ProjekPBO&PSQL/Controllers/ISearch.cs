using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    interface ISearch<T>
    {
        T? Cari(int id);
        List<T> Cari(string nama);
    }
}
