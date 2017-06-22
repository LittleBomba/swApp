using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;

namespace Solid_builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SldWorks swApp;

        private void var_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validateForm(e);
        }

        private void var_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validateForm(e);
        }

        private void var_z_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = validateForm(e);
        }

        private static bool validateForm(KeyPressEventArgs e) {
            return ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8) ? true : false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            swApp = await SolidWorksClass.getApplicationAsync();
        }
    }
}
