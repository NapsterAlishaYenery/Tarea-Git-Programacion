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
    public partial class FrmEntities : Form
    {
        public EntitiesService _service;

        public FrmEntities()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new EntitiesService(connection);
        }

        #region "Events"

        private void dgvEntities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.EntityIndex = Convert.ToInt32(dgvEntities.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeselect.Visible = true;
            }
        }

        private void FrmEntities_Load(object sender, EventArgs e)
        {
            Boleans();
            LoadData();
        }

        #endregion

        #region "Buttons"

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            Delete();
        }

        #endregion


        #region "Methods"

        public void Add()
        {
            if (MainRepository.Instance.EntityIndex != null)
            {
                MessageBox.Show("You must deselect the Entity", "Warning");
            }
            else
            {
                FrmAddEntities frmAdd = new FrmAddEntities();
                frmAdd.Show();
            }
        }

        public void Edit()
        {
            if (MainRepository.Instance.EntityIndex == null)
            {
                MessageBox.Show("You must select the Entity", "Warning");
            }
            else
            {
                FrmAddEntities frmAdd = new FrmAddEntities();
                frmAdd.Show();
            }
        }

        private void Delete()
        {
            if (MainRepository.Instance.EntityIndex == null)
            {
                MessageBox.Show("You must choose a Entity", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Entity?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(MainRepository.Instance.EntityIndex.Value);
                    LoadData();
                    Deselect();
                    MessageBox.Show("Entity has been deleted", "Notification");
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Entity has not been deleted", "Notification");
                }
            }
        }

        private void LoadData()
        {
            dgvEntities.DataSource = _service.GetAll();

            dgvEntities.ClearSelection();
        }

        public void Boleans()
        {
            btnDeselect.Visible = false;
            MainRepository.Instance.EntityIndex = null;
        }

        private void Deselect()
        {
            dgvEntities.ClearSelection();

            btnDeselect.Visible = false;

            MainRepository.Instance.EntityIndex = null;
        }

        #endregion  
    }
}
