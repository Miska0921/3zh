using _3zh.Models;
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
    public partial class dataview : UserControl
    {
        CarContext carContext = new CarContext();
        public dataview()
        {
            InitializeComponent();
            modelBindingSource.DataSource = carContext.Models.ToList();
            brandBindingSource.DataSource = carContext.Brands.ToList();
        }

        private void dataview_Load(object sender, EventArgs e)
        {
            brandlista();
            bindingSource1.DataSource = carContext.UpForSales.ToList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Brand)listBox1.SelectedItem;
            int id = selected.Id;
            var models = from model in carContext.Models
                         where model.BrandId == id
                         select model;
            listBox2.DataSource = models.ToList();
            listBox2.DisplayMember = "Name";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Model)listBox2.SelectedItem;
            int id = selected.Id;
            var upforsale = from sale in carContext.UpForSales
                            where sale.ModelId == id
                            select sale;
            dataGridView1.DataSource = upforsale.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            var selected = from brand in carContext.Brands
                           where brand.Name.Contains(text)
                           select brand;
            listBox1.DataSource = selected.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            UpForSale torol = (UpForSale)dataGridView1.CurrentRow.DataBoundItem;
            DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd?", "Megerősités", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                carContext.UpForSales.Remove(torol);
                carContext.SaveChanges();
            }
            brandlista();
        }
        private void brandlista()
        {
            listBox1.DataSource = carContext.Brands.ToList();
            listBox1.DisplayMember = "Name";
        }
    }
}
