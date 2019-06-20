using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.DataAccess
{
    public static class GlobalConfig
    {

        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFile)
        {
            if (database)
            {
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFile)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
