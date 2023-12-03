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
        public newdataform()
        {
            InitializeComponent();
        }

        private void newdataform_Load(object sender, EventArgs e)
        {
            newdata data = new newdata();
            data.Dock = DockStyle.Fill;
            panel1.Controls.Add(data);
        }
    }
}
