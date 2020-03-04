using NTierPersonelEkleme.BLL.Repositories;
using NTierPersonelEkleme.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierPersonelEkleme.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BaseRepository<Personel>  personel = new BaseRepository<Personel>();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                PersonelAdi = txtboxAd.Text,
                PersonelSoyadi=txtboxSoyAd.Text,
                TCKN=Convert.ToInt32(txtboxTC.Text),
                Email=tbxEmail.Text,
                TelefonNo=tbxTel.Text
            };
        }
        public void ComboboxDoldur()
        {

        }
    }
}
