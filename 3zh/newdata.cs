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
    public partial class newdata : UserControl
    {
        BindingSource binding = new BindingSource();

        CarContext carContext = new CarContext();
        public newdata()
        {
            InitializeComponent();
        }

        private void newdata_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = carContext.Brands.ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = carContext.Models.ToList();
            listBox2.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Brand)listBox1.SelectedItem;
            var models = from model in carContext.Models
                         where model.BrandId == selected.Id
                         select model;
            listBox2.DataSource = models.ToList();
            listBox2.DisplayMember = "Name";
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan menteni szeretnéd?","Megerősités",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
            UpForSale newSale = new UpForSale();
            newSale.Id = idfinder();
            newSale.BrandId = ((Brand)listBox1.SelectedItem).Id;
            newSale.ModelId = ((Model)listBox2.SelectedItem).Id;
            newSale.Seller = textseller.Text;
            newSale.Fuel = textfuel.Text;
            newSale.Horsepower = int.Parse(texthp.Text);
            newSale.Mileage = int.Parse(textkm.Text);
            newSale.Price = int.Parse(textprice.Text);
            carContext.UpForSales.Add(newSale);
            try
            {
                carContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            }
            txtclear();
        }
        private void txtclear()
        {
            textseller.Clear();
            texthp.Clear();
            textfuel.Clear();
            textkm.Clear();
            textprice.Clear();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            txtclear();
        }
        private int idfinder()
        {
            int max = 0;
            foreach (UpForSale sale in carContext.UpForSales.ToList())
            {
                if (sale.Id > max)
                {
                    max = sale.Id;
                }
            }
            return max + 1;
        }
    }
}
