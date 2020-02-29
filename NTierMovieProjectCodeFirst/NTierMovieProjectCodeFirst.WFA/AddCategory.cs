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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }
        BaseRepository<Category> categories  = new BaseRepository<Category>();
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxCategoryName.Text == "")
                {
                    MessageBox.Show("Please do not leave any fields blank!");
                }
                else
                {
                    Category category = new Category()
                    {
                        CategoryName = tbxCategoryName.Text,
                        
                    };
                    categories.Add(category);

                    MessageBox.Show("Category successfully added");

                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
