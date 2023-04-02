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
    public partial class Cont_add : Form
    {
        NumCheck NumCheck = new NumCheck();
        Commands cmd = new Commands();
        public Cont_add()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            cmd.Command_Insert(textBox_name.Text, textBox_phone.Text);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Cont_add_Load(object sender, EventArgs e)
        {

        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (NumCheck.checknum(c))
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
