using NTierPersonelEkleme.BLL.CreationalFactory;
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
        //BaseRepository<Personel>  personels = new BaseRepository<Personel>();
        BaseRepository<Personel> personels = BaseRepository<Personel>.Nesne;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();

            personel.PersonelAdi = txtboxAd.Text;
            personel.PersonelSoyadi = txtboxSoyAd.Text;
                personel.TCKN =txtboxTC.Text;
                personel.Email =tbxEmail.Text;
                personel.TelefonNo =tbxTel.Text;
                personel.Adres =rchTextboxAdres.Text;
                personel.IseGirisTarihi =dateTimePickerİseGiris.Value;
                personel.DepartmanId =(int)comboBoxDepartman.SelectedIndex;
                personel.UnvanId =(int)comboBoxUnvan.SelectedIndex;
                personel.DogumTarihi =dateTimePickerDogumTarihi.Value;
                
             
            if (pictureBox1.Tag != null)
            {
                personel.FotografUrl = Guid.NewGuid() + pictureBox1.Tag.ToString();

                //pictureBox1.Image.Save(Application.StartupPath + @"C:\Users\gulsen.ruya\Desktop\04.03.2020\NTierPersonelEkleme\NTierPersonelEkleme.WFA\Images" + personel.FotografUrl);
            }
            personels.Add(personel);
            MessageBox.Show("Personel added :) ");
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            Creator creator = new Creator();
            DepartmanCreator ıkDepartman = creator.FactoryMethod(AllDepartmants.IK);
            DepartmanCreator ıtDepartman = creator.FactoryMethod(AllDepartmants.IT);
            DepartmanCreator muhasebeDepartman = creator.FactoryMethod(AllDepartmants.Muhasebe);
            DepartmanCreator yonetimDepartman = creator.FactoryMethod(AllDepartmants.Yönetim);
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Picture(png,jpg,gif)|*.png;*.jpg;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("Görsel Seçildi");
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = System.IO.Path.GetExtension(ofd.FileName);
            }
        }
        public void ComboboxDoldur()
        {
            //BaseRepository<Departman> departman = new BaseRepository<Departman>();
            //BaseRepository<Unvan> unvan = new BaseRepository<Unvan>();
            BaseRepository<Unvan> unvan = BaseRepository<Unvan>.Nesne; 
            foreach (var item in Enum.GetValues(typeof(AllDepartmants)))
            {
                comboBoxDepartman.Items.Add(item);
            }
            //comboBoxDepartman.DataSource = departman.SelectAll();
            comboBoxUnvan.DataSource = unvan.SelectAll();
        }
    }
}
