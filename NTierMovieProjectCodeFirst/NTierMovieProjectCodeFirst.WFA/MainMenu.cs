using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierMovieProjectCodeFirst.WFA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public void ChildForm(Form _childForm)
        {
            bool status = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    status = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (status == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void allMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllMovies());
        }

        

        private void addMovieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildForm(new AddMovie());
        }

        private void addSaloonsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChildForm(new AddSaloon());
        }

        private void allSalloonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllSaloons());
        }

        private void allMoviesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChildForm(new AllMovies());
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AddCategory());
        }

        private void allCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllCategories());
        }

        private void addSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AddSession());
        }

        private void sessionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllSessions());
        }

        private void weekListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new AllWeeks());
        }
    }
}
