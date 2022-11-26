using BusinessLayer.Models;
using BusinessLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingSellPoint.FormsSellPoint.FormsSystem
{
    public partial class FrmLogin : Form
    {
        public EntitiesService _service;

        public FrmLogin()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new EntitiesService(connection);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNick.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else
                {

                    if (tbNick.Text == tbNick.Text && tbPassword.Text == tbPassword.Text)
                    {
                        Program.boolLogin = true;
                        Program.NickUser = tbNick.Text;
                        ClearTxb();

                        MessageBox.Show("Welcome to SellPoint", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password", "Warning");
                        ClearTxb();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred", "Error");
                ClearTxb();
            }
        }

        public void ClearTxb()
        {
            tbNick.Clear();
            tbPassword.Clear();
            tbPassword.Focus();
        }
    }
}
