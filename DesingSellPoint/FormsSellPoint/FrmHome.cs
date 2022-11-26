using DesingSellPoint.FormsSellPoint.FormsArchive;
using DesingSellPoint.FormsSellPoint.FormsSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingSellPoint.FormsSellPoint
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
            CostumizeDesing();
        }


        private void btnArchive_Click_1(object sender, EventArgs e)
        {
            if(Program.boolLogin == false)
            {
                MessageBox.Show("start section first", "Caution");
            }
            else
            {
                showSubsMenu(PnlArchive);
            }
        }

        private void btnSystem_Click_1(object sender, EventArgs e)
        {
            showSubsMenu(PnlSystem);
        }

        private void btnGroupEntities_Click(object sender, EventArgs e)
        {
            hideSubsMenus();

            openChildForms(new FrmGroupEntities());
        }

        private void btnEntityTypes_Click(object sender, EventArgs e)
        {
            hideSubsMenus();

            openChildForms(new FrmEntityTypes());
        }

        private void btnEntities_Click(object sender, EventArgs e)
        {
            hideSubsMenus();

            openChildForms(new FrmEntities());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            openChildForms(new FrmAbout());

            hideSubsMenus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildForms(new FrmLogin());

            hideSubsMenus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            hideSubsMenus();

            Application.Exit();
        }

        #region "DesingCostum"

        private void CostumizeDesing()
        {
            //Este metodo oculto los paneles de los botones

            PnlArchive.Visible = false;
            PnlSystem.Visible = false;
        }

        private void hideSubsMenus()
        {
            //Este metodo permite ocultar los sub Paneles

            if (PnlArchive.Visible == true)
            {
                PnlArchive.Visible = false;
            }

            if (PnlSystem.Visible == true)
            {
                PnlSystem.Visible = false;
            }
        }

        private void showSubsMenu(Panel subMenu)
        {

            //Este metodo hace que aparezcan los subsMenu

            if (subMenu.Visible == false)
            {
                hideSubsMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #endregion

        #region "Forms Child"

        public Form activeForm;

        public void openChildForms(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlChildren.Controls.Add(childForm);
                pnlChildren.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlChildren.Controls.Add(childForm);
                pnlChildren.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        public void Home()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        #endregion

        private void FrmHome_Load(object sender, EventArgs e)
        {
            stsLabelDate.Text = DateTime.Now.ToLongDateString();
            stsLabelTime.Text = DateTime.Now.ToLongTimeString();
            stsLabelUser.Text = Program.NickUser.ToString();
        }
    }
}
