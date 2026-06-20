using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginnMobileShop1
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mobile mobile = new Mobile();
            mobile.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accessories accessories = new Accessories();
            accessories.Show();
            this.Hide();
        }
    }
}
