using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Sep16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxFlavors.Items.Add("vanilla");
            lbxFlavors.Items.Add("chocolate");
            lbxFlavors.Items.Add("strawberry");
            lbxFlavors.Items.Add("rocky road");
            lbxFlavors.Items.Add("fear sundae");
            lbxFlavors.Items.Add("peach");
        }

        private void lblFlavor_Click(object sender, EventArgs e)
        {

        }

        private void lbxFlavors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFlavor.Text = lbxFlavors.SelectedItem.ToString();
        }
    }
}
