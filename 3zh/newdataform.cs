using _3zh.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3zh
{
    public partial class newdataform : Form
    {
        CarContext context = new CarContext();
        public newdataform()
        {
            InitializeComponent();
        }

        private void newdataform_Load(object sender, EventArgs e)
        {
            markaLista();
        }
        private void markaLista()
        {
            listBox1.DataSource = context.Brands.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Id = idfinder();
            model.BrandId = ((Brand)listBox1.SelectedItem).Id;
            model.Name = textname.Text;
            context.Models.Add(model);
            try 
            { 
                context.SaveChanges(); 
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
        private int idfinder()
        {
            int max = 0;
            foreach (Model model in context.Models.ToList())
            {
                if (model.Id > max)
                {
                    max = model.Id;
                }
            }
            return max + 1;
        }
    }
}
