using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.ConnectionOpen();
            UpdateData();
        }


        private void UpdateData()
        {
            DataTable contacts = db.ExecuteSql($"select Name as Название_Контакта, Phone as Телефон from contacts;");
            dataGridView1.DataSource = contacts;
        }

        private void button_upd_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button_add_tasks_Click(object sender, EventArgs e)
        {
            Task_add task_Add = new Task_add();
            task_Add.Show();
        }

        private void button_show_all_cont_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button_del_cont_Click(object sender, EventArgs e)
        {
            Cont_del cont_Del = new Cont_del();
            cont_Del.Show();
        }

        private void button_add_cont_Click(object sender, EventArgs e)
        {
            Cont_add cont_Add = new Cont_add();
            cont_Add.Show();
        }

        private void button_update_cont_Click(object sender, EventArgs e)
        {
            Cont_update cont_Update = new Cont_update();
            cont_Update.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var search = textBox1.Text;
            DataTable contacts = db.ExecuteSql($"select Name as Название_Контакта, Phone as Телефон from contacts where name like '%' + '{search}' + '%';");
            dataGridView1.DataSource = contacts;
        }
    }
}
