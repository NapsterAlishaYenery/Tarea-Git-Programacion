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
using BusinessLayer.Service;

namespace DesingSellPoint.FormsSellPoint.FormsArchive
{
    public partial class FrmGroupEntities : Form
    {
        public GroupService _service;
        public FrmGroupEntities()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _service = new GroupService(connection);
        }

        public void FrmGroupEntities_Load(object sender, EventArgs e)
        {
            CargarTabla();
            Boleans();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            Delete();
        }

        public void CargarTabla()
        {
            dgvGroupEntities.DataSource = _service.GetAll();
            dgvGroupEntities.ClearSelection();

        }

        public void Boleans()
        {
            btnDeselect.Visible = false;
            MainRepository.Instance.GroupIndex = null;
        }
        private void Deselect()
        {
            dgvGroupEntities.ClearSelection();

            btnDeselect.Visible = false;

            MainRepository.Instance.GroupIndex = null;
        }

        public void Add()
        {
            if (MainRepository.Instance.GroupIndex != null)
            {
                MessageBox.Show("You must deselect the Entity Group", "Warning");
            }
            else
            {
                FrmAddGroupEntities frmAdd = new FrmAddGroupEntities();
                frmAdd.Show();
            }
        }

        public void Edit()
        {
            if (MainRepository.Instance.GroupIndex == null)
            {
                MessageBox.Show("You must select the Entity Group", "Warning");
            }
            else
            {
                FrmAddGroupEntities frmAdd = new FrmAddGroupEntities();
                frmAdd.Show();
            }
        }

        private void Delete()
        {
            if (MainRepository.Instance.GroupIndex == null)
            {
                MessageBox.Show("You must choose a Entity Group", "Warning");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the Entity Group?",
                    "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _service.Delete(MainRepository.Instance.GroupIndex.Value);
                    CargarTabla();
                    Deselect();
                    MessageBox.Show("Entity Group has been deleted", "Notification");
                }
                else
                {
                    CargarTabla();
                    Deselect();
                    MessageBox.Show("Entity Group has not been deleted", "Notification");
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDeselect_Click_1(object sender, EventArgs e)
        {
            Boleans();
            Deselect();
        }

        private void dgvGroupEntities_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MainRepository.Instance.GroupIndex = Convert.ToInt32(dgvGroupEntities.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeselect.Visible = true;
            }
        }
    }
}
