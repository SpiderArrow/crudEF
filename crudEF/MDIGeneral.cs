using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using crudEF.Forms;

namespace crudEF
{
    public partial class MDIGeneral : Form
    {

        public MDIGeneral()
        {
            InitializeComponent();
        }



        private void MDIGeneral_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.MdiParent = this;
            p.Show();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.MdiParent = this;
            p.Show();
        }
    }
}
