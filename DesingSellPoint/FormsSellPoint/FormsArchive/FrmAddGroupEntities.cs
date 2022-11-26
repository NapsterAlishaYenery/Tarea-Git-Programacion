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
using BusinessLayer.Models;
using BusinessLayer.Service;


namespace DesingSellPoint.FormsSellPoint.FormsArchive
{
    public partial class FrmAddGroupEntities : Form
    {
        public GroupService _service;
        public FrmAddGroupEntities()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new GroupService(connection);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.GroupIndex != null)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        public void Add()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbCommentary.Text)
                    || cbStatus.Text == "Select an option")
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (chbYes.Checked == chbNo.Checked)
                {
                    MessageBox.Show("You must have different answers in removable or select one", "Notification");
                }
                else
                {

                    GroupEntities type = new GroupEntities()
                    {
                        Description = tbDescription.Text,
                        Comentary = tbCommentary.Text,
                        Status = cbStatus.Text,
                        noEliminable = chbNo.Checked ? false : chbYes.Checked,
                        Date = dtpRegistration.Value.Date
                    };

                    bool result = _service.Add(type);

                    MessageBox.Show("The Group was added successfully", "Notification");
                    ClearAll();
                    Back();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }
        public void ClearAll()
        {
            tbDescription.Clear();
            tbCommentary.Clear();
        }
        public void Back()
        {
            this.Close();
        }
        public void LoadEdit()
        {
            if (MainRepository.Instance.GroupIndex != null)
            {
                GroupEntities Type = _service.GetById(MainRepository.Instance.GroupIndex.Value);
                tbDescription.Text = Type.Description;
                tbCommentary.Text = Type.Comentary;
                cbStatus.Text = Type.Status;
                chbYes.Checked = Type.noEliminable;
                chbNo.Checked = Type.noEliminable == false ? true : false;
                Type.Id = MainRepository.Instance.GroupIndex.Value;
            }
        }

        public void Edit()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbCommentary.Text)
                    || cbStatus.Text == "Select an option")
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (chbYes.Checked == chbNo.Checked)
                {
                    MessageBox.Show("You must have different answers in removable or select one", "Notification");
                }
                else
                {
                    GroupEntities type = new GroupEntities()
                    {
                        Description = tbDescription.Text,
                        Comentary = tbCommentary.Text,
                        Status = cbStatus.Text,
                        Date = dtpRegistration.Value.Date,
                        noEliminable = chbNo.Checked ? false : chbYes.Checked,
                        Id = MainRepository.Instance.GroupIndex.Value
                    };

                    _service.Edit(type);
                    MessageBox.Show("Entity Group  edited successfully", "Notification");
                    Back();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }

        private void FrmAddGroupEntities_Load_1(object sender, EventArgs e)
        {
            if (MainRepository.Instance.GroupIndex != null)
            {
                LoadEdit();
            }
        }
    }
}
