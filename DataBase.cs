using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class DataBase : IDisposable
    {
        bool isConnected;
        SqlConnection _connection;
        string connectionstring = @"Data Source = DESKTOP-BBAJL13\SQLEXPRESS; Initial Catalog = DZ_demka; Integrated Security = True;";

        public DataBase()
        {
            ConnectionOpen();
        }

        public void ConnectionOpen()
        {
            _connection = new SqlConnection(connectionstring);
            _connection.Open();
            isConnected = true;
        }

        public void ConnectionClose()
        {
            _connection.Close();
            isConnected = false;
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            dataTable.Load(reader);

            return dataTable;
        }

        public bool ExecuteSqlNonQuery(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, _connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            ConnectionClose();
        }
    }
}
