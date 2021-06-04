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
    public partial class conTracform : Form
    {
        public conTracform()
        {
            InitializeComponent();
        }

       



        private void conTracform_Load(object sender, EventArgs e)
        {

        }


        private void UserName_Click(object sender, EventArgs e)
        {
            
        }

        private void UserCountry_Click(object sender, EventArgs e)
        {

        }

        private void nameFirstBox_TextChanged(object sender, EventArgs e)
        {
            







        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            object chosenCountry = countryChosen.SelectedItem;
            string chosenCountry1 = Convert.ToString(chosenCountry);
            selectedItemBox.Text = chosenCountry1;



            if (checkMale.Checked)
            {
                string checkMale1 = checkMale.Checked.ToString();
                chosenGender.Text = checkMale1;

                if (ageBox.Text.Length <= 3)
                {
                    string ageNum = ageBox.Text;
                    int ageNum1 = int.Parse(ageNum);

                    if ((ageNum1 >= 0) && (ageNum1 <= 100))

                    {

                        MessageBox.Show("Survey submitted. View survey.");

                        printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageBox.Text, selectedItemBox.Text, chosenGender.Text);
                        print.ShowDialog();


                    }


                    else
                        MessageBox.Show("Please input valid data");
                }

                else
                    MessageBox.Show("Please input valid data");

            }

            else if (checkFemale.Checked)
            {
                string checkFemale1 = checkFemale.Checked.ToString();
                chosenGender.Text = checkFemale1;

                if (ageBox.Text.Length <= 3)
                {
                    string ageNum = ageBox.Text;
                    int ageNum1 = int.Parse(ageNum);

                    if ((ageNum1 >= 0) && (ageNum1 <= 100))

                    {

                        MessageBox.Show("Survey submitted. View survey.");

                        printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageBox.Text, selectedItemBox.Text, chosenGender.Text);
                        print.ShowDialog();


                    }


                    else
                        MessageBox.Show("Please input valid data");
                }

                else
                    MessageBox.Show("Please input valid data");


            }


            else if (checkTransMale.Checked)
            {
                string checkTransMale1 = checkTransMale.Checked.ToString();
                chosenGender.Text = checkTransMale1;

                if (ageBox.Text.Length <= 3)
                {
                    string ageNum = ageBox.Text;
                    int ageNum1 = int.Parse(ageNum);

                    if ((ageNum1 >= 0) && (ageNum1 <= 100))

                    {

                        MessageBox.Show("Survey submitted. View survey.");

                        printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageBox.Text, selectedItemBox.Text, chosenGender.Text);
                        print.ShowDialog();


                    }


                    else
                        MessageBox.Show("Please input valid data");
                }

                else
                    MessageBox.Show("Please input valid data");


            }







            //if (checkMale.Checked)
            //{
            //    string male


            //}

            //else if ( )


























        }

        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 127)
            {
                e.Handled = true;

            }
        }

        private void nameFirstBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;

            if(!Char.IsLetter(alpha) && alpha != 8 && alpha != 127 && alpha != 32)
            {
                e.Handled = true;
            }
        }

        private void nameLastBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char beta = e.KeyChar;

            if (!Char.IsLetter(beta) && beta != 8 && beta != 127 && beta != 32)
            {
                e.Handled = true;
            }
        }
    }

        
        

    }



