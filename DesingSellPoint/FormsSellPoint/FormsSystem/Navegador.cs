using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;


namespace DesingSellPoint.FormsSellPoint.FormsSystem
{
    public partial class Navegador : Form
    {
        private Object oDocument;
        public Navegador()
        {
            InitializeComponent();
        }

        private void OpenNavegador()
        {
            string URL = toolStripTextBox1.Text;
            System.Diagnostics.Process.Start("chrome.exe", "www.google.com.do");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            OpenNavegador();
        }
    }
}
