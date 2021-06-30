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

            optionText.Enabled = false;

            if (checkAffirmative.Checked)
            {
                checkNegative.Checked = false;

                surveyYN.Text = "Yes";

                if (checkMale.Checked)
                {
                    chosenGender.Text = "Male";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }
                        
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkFemale.Checked)
                {
                    chosenGender.Text = "Female";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        } 
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkTransMale.Checked)
                {
                    chosenGender.Text = "Transgender Male";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                       
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkTransFemale.Checked)
                {
                    chosenGender.Text = "Transgender Female";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                       
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkNope.Checked)
                {
                    chosenGender.Text = "I don't prefer to say";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                     
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkOption.Checked)
                {
                    optionText.Enabled = true;
                    optionText.Text = "";
                    chosenGender.Text = optionText.Text;

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();

                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }
                       
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }
            }

            else
                checkNegative.Checked = true;

            if (checkNegative.Checked)
            {
                surveyYN.Text = "No";

                if (checkMale.Checked)
                {
                    chosenGender.Text = "Male";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                       
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkFemale.Checked)
                {
                    chosenGender.Text = "Female";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkTransMale.Checked)
                {
                    chosenGender.Text = "Transgender Male";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                        
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkTransFemale.Checked)
                {
                    chosenGender.Text = "Transgender Female";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();


                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkNope.Checked)
                {
                    chosenGender.Text = "I don't prefer to say";

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }

                else if (checkOption.Checked)
                {
                    optionText.Enabled = true;
                    optionText.Text = "";
                    chosenGender.Text = optionText.Text;

                    if (ageBox.Text.Length <= 3)
                    {
                        try
                        {
                            string ageNum = ageBox.Text;
                            int ageNum1 = int.Parse(ageNum);

                            if ((ageNum1 >= 0) && (ageNum1 <= 100))
                            {
                                MessageBox.Show("Survey submitted. View survey.");

                                ageOut.Text = ageNum1.ToString();

                                printForm print = new printForm(nameFirstBox.Text, nameLastBox.Text, ageOut.Text, selectedItemBox.Text, chosenGender.Text, surveyYN.Text, contNumtxt.Text, addressTxt.Text);
                                print.ShowDialog();
                            }

                            else
                                MessageBox.Show("Please input valid data");
                        }

                        catch
                        {

                        }                        
                    }

                    else
                        MessageBox.Show("Please input valid data");
                }
            }
            
        }

        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 127)
            {
                e.Handled = true;
            }
        }

        private void nameFirstBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char alpha = e.KeyChar;

            if (!Char.IsLetter(alpha) && alpha != 8 && alpha != 127 && alpha != 32)
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

        private void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contNumtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 127)
            {
                e.Handled = true;
            }
        }
    }
}



