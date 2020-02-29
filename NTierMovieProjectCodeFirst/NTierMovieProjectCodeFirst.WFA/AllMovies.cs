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
    public partial class AllMovies : Form
    {
        public AllMovies()
        {
            InitializeComponent();
        }
        BaseRepository<Movie> movies = new BaseRepository<Movie>();

        private void AllMovies_Load(object sender, EventArgs e)
        {
            datagriedMovies.DataSource = movies.SelectAll();
        }
    }
}
