using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace Bookeeper
{
    public interface IConfiguration
    {
        string dir { get; }

        ISQLitePlatform platform { get; }
    }
}
