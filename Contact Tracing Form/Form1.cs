﻿using System;
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
            printForm print = new printForm(nameFirstBox.Text,nameLastBox.Text,ageBox.Text);
            print.ShowDialog();

        }

        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }

        
        

    }


