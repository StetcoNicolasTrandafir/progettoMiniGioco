using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoLibri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogo f = new frmCatalogo();
            f.ShowDialog();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutori f = new frmAutori();
            f.ShowDialog();
        }

        private void repartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReparti f = new frmReparti();
            f.ShowDialog();
        }

        private void editoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditori f = new frmEditori();
            f.ShowDialog();
        }

        private void offerteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfferte f = new frmOfferte();
            f.ShowDialog();
        }

        private void libriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibri f = new frmLibri();
            f.ShowDialog();
        }
    }
}
