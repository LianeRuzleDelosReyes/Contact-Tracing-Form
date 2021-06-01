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
            string nameGiven = first.Trim();
            nameFirstBox.Text = nameGiven;

            string nameSurname = last.Trim();
            nameLastBox.Text = nameSurname;


            string ageUser = age.Trim();
            ageBox.Text= ageUser;
        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void nameFirstBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
