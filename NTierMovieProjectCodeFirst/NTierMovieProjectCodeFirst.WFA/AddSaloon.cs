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
    public partial class AddSaloon : Form
    {
        public AddSaloon()
        {
            InitializeComponent();
        }
        BaseRepository<Saloon> saloons = new BaseRepository<Saloon>();

        private void btnSaloonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxSaloonName.Text == "")
                {
                    MessageBox.Show("Please do not leave blank !");
                }
                else
                {
                    Saloon saloon = new Saloon()
                    {
                        Saloons = tbxSaloonName.Text,
                        Capacity = Convert.ToInt32(nudSaloonCapacity.Value)
                    };
                    saloons.Add(saloon);

                    MessageBox.Show("Saloon successfully added :)");

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
