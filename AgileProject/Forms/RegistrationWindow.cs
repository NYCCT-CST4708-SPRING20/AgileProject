using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileProject.Forms
{
    public partial class RegistrationWindow : Form


    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A new Account has been created successfully");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
