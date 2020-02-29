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
    public partial class AllSessions : Form
    {
        public AllSessions()
        {
            InitializeComponent();
        }
        BaseRepository<Session> sessions = new BaseRepository<Session>();
        private void AllSessions_Load(object sender, EventArgs e)
        {
            dataGriedSessions.DataSource = sessions.SelectAll();
        }
    }
}
