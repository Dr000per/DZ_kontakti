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
    public partial class Cont_update : Form
    {
        DataBase db = new DataBase();
        NumCheck numCheck = new NumCheck();
        public Cont_update()
        {
            InitializeComponent();
        }


        private void UpdateData()
        {
            comboBox_old_name.Items.Clear();
            string querystring = "select name from contacts;";
            SqlCommand command = new SqlCommand(querystring, db.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_old_name.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            try
            {
                var name_now = comboBox_old_name.SelectedItem.ToString();

                object querystr = $"select * from contacts where name = '{name_now}';";
                SqlCommand comm = new SqlCommand((string)querystr, db.GetConnection());
                SqlDataReader read = comm.ExecuteReader();
                read.Read();
                object name = read.GetValue(1);
                object phone = read.GetValue(2);
                read.Close();

                object NewName = name;
                object NewPhone = phone;


                if (checkBox_new_name.Checked)
                {
                    NewName = textBox_newname.Text;
                }
                if (checkBox_phone.Checked)
                {
                    NewPhone = textBox_descr.Text;                                                                                                                             // Проверка чекбокса с Email
                }

                db.ExecuteSqlNonQuery($"update Contacts set name = '{NewName}', phone = '{NewPhone}' where name = '{name_now}';");

                MessageBox.Show("Вы изменили данные!", "Оповещение");
                UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cont_update_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void textBox_descr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (numCheck.checknum(c))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
