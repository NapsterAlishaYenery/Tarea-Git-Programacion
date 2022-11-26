using BusinessLayer;
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

namespace DesingSellPoint.FormsSellPoint.FormsArchive
{
    public partial class FrmAddEntityTypes : Form
    {
        public EntitiesTypesService _service;

        public FrmAddEntityTypes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new EntitiesTypesService(connection);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(MainRepository.Instance.EntityTypesIndex != null)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        private void FrmAddEntityTypes_Load(object sender, EventArgs e)
        {
            if(MainRepository.Instance.EntityTypesIndex != null)
            {
                LoadEdit();
            }
        }

        public void LoadEdit()
        {
            if (MainRepository.Instance.EntityTypesIndex != null)
            {
                TypesIdentities Type = _service.GetById(MainRepository.Instance.EntityTypesIndex.Value);
                tbDescription.Text = Type.Description;
                cbGroup.Text = Type.IdGrupoEntidad;
                tbCommentary.Text = Type.Comentary;
                cbStatus.Text = Type.Status;
                chbYes.Checked = Type.NoEliminable;
                chbNo.Checked = Type.NoEliminable == false ? true : false;
                Type.Id = MainRepository.Instance.EntityTypesIndex.Value;                
            }
        }

        public void Add()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbDescription.Text)
                    || cbStatus.Text == "Select an option" || cbGroup.Text == "Select an option")
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (chbYes.Checked == chbNo.Checked)
                {
                    MessageBox.Show("You must have different answers in smoker or select one", "Notification");
                }
                else
                {

                    TypesIdentities type = new TypesIdentities()
                    {
                        Description = tbDescription.Text,
                        IdGrupoEntidad = cbGroup.Text,
                        Comentary = tbCommentary.Text,
                        Status = cbStatus.Text,
                        Date = dtpRegistration.Value.Date,
                        NoEliminable = chbNo.Checked ? false : chbYes.Checked
                    };

                    bool result = _service.Add(type);

                    MessageBox.Show("The patient was added successfully", "Notification");
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

        public void Edit()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbDescription.Text)
                    || cbStatus.Text == "Select an option" || cbGroup.Text == "Select an option")
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (chbYes.Checked == chbNo.Checked)
                {
                    MessageBox.Show("You must have different answers in smoker or select one", "Notification");
                }
                else
                {
                    TypesIdentities type = new TypesIdentities()
                    {
                        Description = tbDescription.Text,
                        IdGrupoEntidad = cbGroup.Text,
                        Comentary = tbCommentary.Text,
                        Status = cbStatus.Text,
                        Date = dtpRegistration.Value.Date,
                        NoEliminable = chbNo.Checked ? false : chbYes.Checked,
                        Id = (int)MainRepository.Instance.EntityTypesIndex.Value
                    };

                    _service.Edit(type);
                    MessageBox.Show("Entity Type edited successfully", "Notification");
                    Back();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }
        }
    }
}
