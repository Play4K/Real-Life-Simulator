using MySql.Data.MySqlClient;
using System.Data;

namespace Real_Life_Simulator
{
    public class SQLConnection
    {
        public MySqlConnection con = new MySqlConnection(@"server=localhost; userid=root; pwd=EBAD4D64E_c; persistsecurityInfo=true; database=reallifesimulator");
        public MySqlCommand cmd;
        public MySqlDataReader sqlDataReader;
        public MySqlDataAdapter sqlDataAdapter;
        public DataTable dataTable;
    }
}
