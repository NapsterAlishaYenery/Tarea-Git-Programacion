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
    public partial class FrmEntityTypes : Form
    {
        public EntitiesTypesService _service;

        public FrmEntityTypes()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new EntitiesTypesService(connection);
        }

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

        #region "Events"

        private void dgvEntityTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.EntityTypesIndex = Convert.ToInt32(dgvEntityTypes.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeselect.Visible = true;
            }
        }

        private void FrmEntityTypes_Load(object sender, EventArgs e)
        {
            Boleans();
            LoadData();
        }

        #endregion

        #region "Methods"

        public void Add()
        {
            if (MainRepository.Instance.EntityTypesIndex != null)
            {
                MessageBox.Show("You must deselect the Entity types", "Warning");
            }
            else
            {
                FrmHome frmHome = new FrmHome();
                frmHome.Hide();
                FrmAddEntityTypes frmAdd = new FrmAddEntityTypes();
                frmAdd.Show();
            }
        }

        public void Edit()
        {
            if (MainRepository.Instance.EntityTypesIndex == null)
            {
                MessageBox.Show("You must select the Entity Types", "Warning");
            }
            else
            {
                FrmAddEntityTypes frmAdd = new FrmAddEntityTypes();
                frmAdd.Show();
            }
        }

        private void Delete()
        {
            if (MainRepository.Instance.EntityTypesIndex == null)
            {
                MessageBox.Show("You must choose a Entity Types", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Entity Types?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(MainRepository.Instance.EntityTypesIndex.Value);
                    LoadData();
                    Deselect();
                    MessageBox.Show("Entity Type has been deleted", "Notification");
                }
                else
                {
                    LoadData();
                    Deselect();
                    MessageBox.Show("Entity Type has not been deleted", "Notification");
                }
            }
        }

        private void LoadData()
        {
            dgvEntityTypes.DataSource = _service.GetAll();

            dgvEntityTypes.ClearSelection();
        }


        public void Boleans()
        {
            btnDeselect.Visible = false;
            MainRepository.Instance.EntityTypesIndex = null;
        }

        private void Deselect()
        {
            dgvEntityTypes.ClearSelection();

            btnDeselect.Visible = false;

            MainRepository.Instance.EntityTypesIndex = null;
        }

        #endregion
    }
}
