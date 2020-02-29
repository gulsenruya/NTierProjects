using NTierMovieProjectCodeFirst.BLL.Repositories.Service;
using NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity;
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
    public partial class AllCategories : Form
    {
        public AllCategories()
        {
            InitializeComponent();
        }
        BaseRepository<Category> categories = new BaseRepository<Category>();
        private void AllCategories_Load(object sender, EventArgs e)
        {
            dataGriedCategories.DataSource = categories.SelectAll();
        }

        
    }
}
