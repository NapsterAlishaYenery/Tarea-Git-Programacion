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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        #region "Progress Splash"

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void tmSplash_Tick_1(object sender, EventArgs e)
        {
            tmSplash.Enabled = true;
            pBSplash.Increment(2);
            if (pBSplash.Value == 100)
            {
                Program.boolSplashConfirm = true;

                this.Close();
            }
        }
    }
}
