using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public class Commands
    {
        public Boolean Command_Insert(object name, object phone)
        {
            DataBase db = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            db.ConnectionOpen();
            
            string querystring = $"select * from contacts where phone = '{phone}' or name = '{name}'";                 // Проверка на совпадение с уже имеющимися данными
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой номер уже добавлен в контакты или уже имеется контакт с таким названием", "Оповещение");
                return false;
            }
            else
            {
                db.ExecuteSqlNonQuery($"insert into contacts values('{name}', '{phone}');");
                MessageBox.Show("Вы добавили новый контакт!", "Оповещение");
                return true;
            }
        }
        public Boolean Command_ExecuteSqlNonQuery(object querystring)
        {
           
           DataBase db = new DataBase();
           
           return db.ExecuteSqlNonQuery(querystring.ToString());
        }
    }
}
