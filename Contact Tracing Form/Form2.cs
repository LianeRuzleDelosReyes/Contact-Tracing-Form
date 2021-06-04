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
        public printForm(string first,string last, string age, object country, string gender)
        {
            InitializeComponent();
            string nameGiven = first.Trim();
            nameFirstBox.Text = nameGiven;

            string nameSurname = last.Trim();
            nameLastBox.Text = nameSurname;


            string ageUser = age.Trim();
            ageBox.Text= ageUser;

            string countryUser = Convert.ToString(country);
            countryBox.Text = countryUser;

            string usersGender = gender.Trim();
            genderBox.Text = usersGender;

        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void nameFirstBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
