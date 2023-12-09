using _3zh.Models;

namespace _3zh
{
    public partial class Form1 : Form
    {
        CarContext carContext = new CarContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Be akarod zárni az ablakot?", "Megerõsités", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dataview data = new dataview();
            data.Dock = DockStyle.Fill;
            panel1.Controls.Add(data);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            newdata data = new newdata();
            data.Dock = DockStyle.Fill;
            panel1.Controls.Add(data);
        }

        private void buttonmodel_Click(object sender, EventArgs e)
        {
            newdataform form = new newdataform();
            form.ShowDialog();
        }
    }
}