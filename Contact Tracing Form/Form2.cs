using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form
{
    public partial class printForm : Form
    {
        public printForm(string first,string last, string age)
        {
            InitializeComponent();
            nameFirstBox.Text = first;
            nameLastBox.Text = last;
            ageBox.Text= age;
            byte.Parse(ageBox.Text);
        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void nameFirstBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
