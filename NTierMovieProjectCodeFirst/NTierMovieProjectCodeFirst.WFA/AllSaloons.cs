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
    public partial class AllSaloons : Form
    {
        public AllSaloons()
        {
            InitializeComponent();
        }
        BaseRepository<Saloon> saloons = new BaseRepository<Saloon>();
        private void AllSaloons_Load(object sender, EventArgs e)
        {
            datagriedSaloons.DataSource = saloons.SelectAll();
        }
    }
}
