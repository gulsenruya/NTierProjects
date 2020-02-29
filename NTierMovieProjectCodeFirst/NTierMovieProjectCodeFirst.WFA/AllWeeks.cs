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
    public partial class AllWeeks : Form
    {
        public AllWeeks()
        {
            InitializeComponent();
        }
        BaseRepository<Week> weeks = new BaseRepository<Week>();

        private void AllWeeks_Load(object sender, EventArgs e)
        {
            datagriedWeeks.DataSource = weeks.SelectAll();
        }
    }
}
