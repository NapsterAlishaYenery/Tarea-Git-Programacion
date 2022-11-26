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

namespace DesingSellPoint.FormsSellPoint.FormsArchive
{
    public partial class FrmAddEntities : Form
    {
        public EntitiesService _service;

        public FrmAddEntities()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new EntitiesService(connection);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (MainRepository.Instance.EntityIndex != null)
            {
                Edit();
            }
            else
            {
                Add();
            }
        }

        private void FrmAddEntities_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }

        public void Add()
        {

            try
            {
                if (string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
                    || string.IsNullOrWhiteSpace(tbLocation.Text) || string.IsNullOrWhiteSpace(tbURLweb.Text)
                    || string.IsNullOrWhiteSpace(tbURLfacebook.Text) || string.IsNullOrWhiteSpace(tbURLinstagram.Text)
                    || string.IsNullOrWhiteSpace(tbURLtwitter.Text) || string.IsNullOrWhiteSpace(tbURLtiktok.Text)
                    || string.IsNullOrWhiteSpace(tbCredit.Text) || string.IsNullOrWhiteSpace(tbUser.Text)
                    || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbRol.Text)
                    || string.IsNullOrWhiteSpace(mtbDocumentNumber.Text) || string.IsNullOrWhiteSpace(mtbPhone.Text)
                    || string.IsNullOrWhiteSpace(tbCommentary.Text)  || cbEntityGroup.Text == "Select an option"
                    || cbDocument.Text == "Select an option" || cbType.Text == "Select an option" 
                    || cbEntityGroup.Text == "Select an option" || cbStatus.Text == "Select an option")
                {

                    MessageBox.Show("You must complete all the data", "Warning");
                }
                else if (cbYes.Checked == chbNo.Checked)
                {
                    MessageBox.Show("You must have different answers in smoker or select one", "Notification");
                }
                else
                {

                    Entities type = new Entities()
                    {
                        Descripcion = tbDescription.Text,
                        Direccion = tbAddress.Text,
                        Localidad = tbLocation.Text,
                        TipoEntidad = cbEntity.Text,
                        TipoDocumento = cbDocument.Text,
                        NumeroDocumento = mtbDocumentNumber.Text,
                        Telefonos = mtbPhone.Text,
                        URLPaginaWeb = tbURLweb.Text,
                        URLFacebook = tbURLfacebook.Text,
                        URLInstagram = tbURLinstagram.Text,
                        URLTwitter = tbURLtwitter.Text,
                        URLtiktok = tbURLtiktok.Text,
                        IdGrupoEntidad = cbEntityGroup.Text,
                        IdTipoEntidad = cbType.Text,
                        LimiteCredito = tbCredit.Text,
                        UserNameEntidad = tbUser.Text,
                        PasswordEntidad = tbPassword.Text,
                        RolUserEntidad = tbRol.Text,
                        Comentario = tbCommentary.Text,
                        Status1 = cbStatus.Text,
                        NoEliminable = chbNo.Checked ? false : cbYes.Checked,
                        FechaRegistro = dtpRegistration.Value.Date
                    };

                    bool result = _service.Add(type);

                    MessageBox.Show("The Entity was added successfully", "Notification");
                    Back();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must complete all the data", "Error");
            }                    
        }
        public void Back()
        {
            this.Close();
        }

        public void Edit()
        {
            
        }

        public void LoadEdit()
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
