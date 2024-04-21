using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public string connString = "datasource=localhost; username=root; password=;database=company";

        void isLogin(String username, String password)
        {
            string query = "SELECT COUNT(*) FROM account WHERE USERNAME = '"+username+"' AND PASSWORD = '"+password+"'";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                
                if (count > 0)
                {
                    Form form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD!");
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isLogin(txtUsername.Text, txtPassword.Text);
        }
    }
}
