using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Task_add : Form
    {
        DataBase db = new DataBase();
        public Task_add()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            db.ConnectionOpen();
            string name = textBox_name.Text;
            string descr = textBox_description.Text;
            string name_proj = comboBox1.SelectedItem.ToString();

            db.ExecuteSqlNonQuery($"insert into tasks values((select id from projects where name = '{name_proj}'),'{name}', '{descr}', 0);");
            MessageBox.Show("Вы добавили новую задачу в проект!", "Оповещение");
            UpdateData();
        }

        private void Task_add_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            comboBox1.Items.Clear();
            string querystring = "select name from projects;";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
