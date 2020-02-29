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
    public partial class AddSession : Form
    {
        public AddSession()
        {
            InitializeComponent();
        }
        BaseRepository<Session> sessions = new BaseRepository<Session>();

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            string hour = tbxHour.Text;
            string minute = tbxMinute.Text;
            string sessionTime = Session(hour, minute);

            Session session = new Session()
            {
                Sessions = sessionTime
            };
            sessions.Add(session);
            MessageBox.Show("Session successfully added");
        }
        public string Session(string hour, string minute)
        {
            return hour + ":" + minute;
            
        }
    }
}
