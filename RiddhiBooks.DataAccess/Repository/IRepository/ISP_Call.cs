using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiddhiBooks.DataAccess.Repository
{
    interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters)
    }
}
