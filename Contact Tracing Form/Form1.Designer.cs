
namespace Contact_Tracing_Form
{
    partial class conTracform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conTracform));
            this.headerBox = new System.Windows.Forms.PictureBox();
            this.UserName1 = new System.Windows.Forms.Label();
            this.nameFirstBox = new System.Windows.Forms.TextBox();
            this.nameLastBox = new System.Windows.Forms.TextBox();
            this.UserName2 = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.Label();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.checkTransMale = new System.Windows.Forms.CheckBox();
            this.checkTransFemale = new System.Windows.Forms.CheckBox();
            this.checkClassified = new System.Windows.Forms.CheckBox();
            this.checkOthers = new System.Windows.Forms.CheckBox();
            this.otherBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UserCountry = new System.Windows.Forms.Label();
            this.checkNo = new System.Windows.Forms.CheckBox();
            this.checkYes = new System.Windows.Forms.CheckBox();
            this.survey = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.Image = ((System.Drawing.Image)(resources.GetObject("headerBox.Image")));
            this.headerBox.Location = new System.Drawing.Point(12, 12);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(641, 91);
            this.headerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerBox.TabIndex = 0;
            this.headerBox.TabStop = false;
            // 
            // UserName1
            // 
            this.UserName1.AutoSize = true;
            this.UserName1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName1.Location = new System.Drawing.Point(8, 117);
            this.UserName1.Name = "UserName1";
            this.UserName1.Size = new System.Drawing.Size(100, 22);
            this.UserName1.TabIndex = 1;
            this.UserName1.Text = " First name";
            this.UserName1.Click += new System.EventHandler(this.UserName_Click);
            // 
            // nameFirstBox
            // 
            this.nameFirstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFirstBox.Location = new System.Drawing.Point(12, 142);
            this.nameFirstBox.Name = "nameFirstBox";
            this.nameFirstBox.Size = new System.Drawing.Size(263, 26);
            this.nameFirstBox.TabIndex = 2;
            this.nameFirstBox.TextChanged += new System.EventHandler(this.nameFirstBox_TextChanged);
            this.nameFirstBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameFirstBox_KeyPress);
            // 
            // nameLastBox
            // 
            this.nameLastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLastBox.Location = new System.Drawing.Point(305, 142);
            this.nameLastBox.Name = "nameLastBox";
            this.nameLastBox.Size = new System.Drawing.Size(263, 26);
            this.nameLastBox.TabIndex = 4;
            this.nameLastBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameLastBox_KeyPress);
            // 
            // UserName2
            // 
            this.UserName2.AutoSize = true;
            this.UserName2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName2.Location = new System.Drawing.Point(301, 117);
            this.UserName2.Name = "UserName2";
            this.UserName2.Size = new System.Drawing.Size(97, 22);
            this.UserName2.TabIndex = 3;
            this.UserName2.Text = " Last name";
            // 
            // UserAge
            // 
            this.UserAge.AutoSize = true;
            this.UserAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAge.Location = new System.Drawing.Point(12, 180);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(42, 22);
            this.UserAge.TabIndex = 5;
            this.UserAge.Text = "Age";
            // 
            // UserGender
            // 
            this.UserGender.AutoSize = true;
            this.UserGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGender.Location = new System.Drawing.Point(12, 243);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(68, 22);
            this.UserGender.TabIndex = 7;
            this.UserGender.Text = "Gender";
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(16, 268);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(49, 17);
            this.checkMale.TabIndex = 8;
            this.checkMale.Text = "Male";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(16, 287);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(60, 17);
            this.checkFemale.TabIndex = 9;
            this.checkFemale.Text = "Female";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // checkTransMale
            // 
            this.checkTransMale.AutoSize = true;
            this.checkTransMale.Location = new System.Drawing.Point(16, 310);
            this.checkTransMale.Name = "checkTransMale";
            this.checkTransMale.Size = new System.Drawing.Size(112, 17);
            this.checkTransMale.TabIndex = 10;
            this.checkTransMale.Text = "Transgender Male";
            this.checkTransMale.UseVisualStyleBackColor = true;
            // 
            // checkTransFemale
            // 
            this.checkTransFemale.AutoSize = true;
            this.checkTransFemale.Location = new System.Drawing.Point(16, 333);
            this.checkTransFemale.Name = "checkTransFemale";
            this.checkTransFemale.Size = new System.Drawing.Size(123, 17);
            this.checkTransFemale.TabIndex = 11;
            this.checkTransFemale.Text = "Transgender Female";
            this.checkTransFemale.UseVisualStyleBackColor = true;
            // 
            // checkClassified
            // 
            this.checkClassified.AutoSize = true;
            this.checkClassified.Location = new System.Drawing.Point(16, 356);
            this.checkClassified.Name = "checkClassified";
            this.checkClassified.Size = new System.Drawing.Size(108, 17);
            this.checkClassified.TabIndex = 12;
            this.checkClassified.Text = "I prefer not to say";
            this.checkClassified.UseVisualStyleBackColor = true;
            // 
            // checkOthers
            // 
            this.checkOthers.AutoSize = true;
            this.checkOthers.Location = new System.Drawing.Point(16, 379);
            this.checkOthers.Name = "checkOthers";
            this.checkOthers.Size = new System.Drawing.Size(129, 17);
            this.checkOthers.TabIndex = 13;
            this.checkOthers.Text = "Other (Please specify)";
            this.checkOthers.UseVisualStyleBackColor = true;
            // 
            // otherBox
            // 
            this.otherBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBox.Location = new System.Drawing.Point(32, 402);
            this.otherBox.Name = "otherBox";
            this.otherBox.Size = new System.Drawing.Size(215, 26);
            this.otherBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Artigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbajian",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Côte d\'Ivoire",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada ",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Cambodia",
            "Comoros",
            "Congo (Congo-Brazzaville)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia (Czech Republic)",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini (fmr. \"Swaziland\")",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (fmr. Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine State",
            "Panama ",
            "Papua New Guinea",
            "Paraguay ",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis ",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela ",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(305, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // UserCountry
            // 
            this.UserCountry.AutoSize = true;
            this.UserCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCountry.Location = new System.Drawing.Point(310, 185);
            this.UserCountry.Name = "UserCountry";
            this.UserCountry.Size = new System.Drawing.Size(75, 22);
            this.UserCountry.TabIndex = 16;
            this.UserCountry.Text = "Country";
            this.UserCountry.Click += new System.EventHandler(this.UserCountry_Click);
            // 
            // checkNo
            // 
            this.checkNo.AutoSize = true;
            this.checkNo.Location = new System.Drawing.Point(314, 287);
            this.checkNo.Name = "checkNo";
            this.checkNo.Size = new System.Drawing.Size(40, 17);
            this.checkNo.TabIndex = 19;
            this.checkNo.Text = "No";
            this.checkNo.UseVisualStyleBackColor = true;
            // 
            // checkYes
            // 
            this.checkYes.AutoSize = true;
            this.checkYes.Location = new System.Drawing.Point(314, 268);
            this.checkYes.Name = "checkYes";
            this.checkYes.Size = new System.Drawing.Size(44, 17);
            this.checkYes.TabIndex = 18;
            this.checkYes.Text = "Yes";
            this.checkYes.UseVisualStyleBackColor = true;
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(310, 243);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(226, 22);
            this.survey.TabIndex = 17;
            this.survey.Text = "Did you leave the country?";
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.subBtn.Location = new System.Drawing.Point(483, 399);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(160, 33);
            this.subBtn.TabIndex = 20;
            this.subBtn.Text = "Submit Response";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageBox.Location = new System.Drawing.Point(16, 210);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 26);
            this.ageBox.TabIndex = 21;
            this.ageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageBox_KeyPress);
            // 
            // conTracform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.checkNo);
            this.Controls.Add(this.checkYes);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.UserCountry);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.otherBox);
            this.Controls.Add(this.checkOthers);
            this.Controls.Add(this.checkClassified);
            this.Controls.Add(this.checkTransFemale);
            this.Controls.Add(this.checkTransMale);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.nameLastBox);
            this.Controls.Add(this.UserName2);
            this.Controls.Add(this.nameFirstBox);
            this.Controls.Add(this.UserName1);
            this.Controls.Add(this.headerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "conTracform";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.conTracform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerBox;
        private System.Windows.Forms.Label UserName1;
        private System.Windows.Forms.TextBox nameFirstBox;
        private System.Windows.Forms.TextBox nameLastBox;
        private System.Windows.Forms.Label UserName2;
        private System.Windows.Forms.Label UserAge;
        private System.Windows.Forms.Label UserGender;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.CheckBox checkTransMale;
        private System.Windows.Forms.CheckBox checkTransFemale;
        private System.Windows.Forms.CheckBox checkClassified;
        private System.Windows.Forms.CheckBox checkOthers;
        private System.Windows.Forms.TextBox otherBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label UserCountry;
        private System.Windows.Forms.CheckBox checkNo;
        private System.Windows.Forms.CheckBox checkYes;
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.TextBox ageBox;
    }
}

