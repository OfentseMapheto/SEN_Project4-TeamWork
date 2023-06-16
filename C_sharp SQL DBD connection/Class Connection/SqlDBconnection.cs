using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace C_sharp_SQL_DBD_connection.Class_Connection
{
    public class SqlDBconnection
    {
        private SqlConnection _con;    
        private SqlCommand _cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;

        public SqlDBconnection()
        {
            _con = new SqlConnection("Data Source=DESKTOP-UHQNRV4;Initial Catalog=PSS;Integrated Security=True");
            _con.Open();
        }
        public void SqlQuery(string queryText)
        {
            _cmd = new SqlCommand(queryText, _con);
        }

        public DataTable QueryEx()
        {
            _da = new SqlDataAdapter(_cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public void NonQueryEx()
        {
            _cmd.ExecuteNonQuery();
        }
    }
}
