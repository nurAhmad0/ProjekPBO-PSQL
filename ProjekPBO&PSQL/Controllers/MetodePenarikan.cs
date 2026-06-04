using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL
{
    abstract class MetodePenarikan
    {

        public abstract bool MenarikUang(decimal jumlah, Orang orang);
    }
}
