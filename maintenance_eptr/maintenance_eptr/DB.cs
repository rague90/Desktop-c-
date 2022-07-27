using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maintenance_eptr
{
    class DB
    {
        public static String sql = "Data Source=data.db ; Version= 3 ;";
        public static SQLiteConnection con = new SQLiteConnection(sql);
    }
}
