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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        BaseRepository<Movie> movies = new BaseRepository<Movie>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Text == "" || tbxDescripton.Text == "")
                {
                    MessageBox.Show("Please do not leave any fields blank!");
                }
                else
                {
                    Movie movie = new Movie()
                    {
                        MovieName = tbxName.Text,
                        Description = tbxDescripton.Text,
                        Duration = Convert.ToInt16(nudMovieDuration.Value)
                    };
                    movies.Add(movie);
                    
                    MessageBox.Show("Movie successfully added");
                    
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
