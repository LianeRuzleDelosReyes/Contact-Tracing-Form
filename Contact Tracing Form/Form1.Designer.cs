
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
            this.countryChosen = new System.Windows.Forms.ComboBox();
            this.UserCountry = new System.Windows.Forms.Label();
            this.survey = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.selectedItemBox = new System.Windows.Forms.TextBox();
            this.checkMale = new System.Windows.Forms.RadioButton();
            this.checkFemale = new System.Windows.Forms.RadioButton();
            this.checkNope = new System.Windows.Forms.RadioButton();
            this.checkOption = new System.Windows.Forms.RadioButton();
            this.checkTransFemale = new System.Windows.Forms.RadioButton();
            this.checkTransMale = new System.Windows.Forms.RadioButton();
            this.chosenGender = new System.Windows.Forms.TextBox();
            this.ageOut = new System.Windows.Forms.TextBox();
            this.optionText = new System.Windows.Forms.TextBox();
            this.surveyYN = new System.Windows.Forms.TextBox();
            this.checkAffirmative = new System.Windows.Forms.RadioButton();
            this.checkNegative = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contNum = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.contNumtxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBox
            // 
            this.headerBox.Image = ((System.Drawing.Image)(resources.GetObject("headerBox.Image")));
            this.headerBox.Location = new System.Drawing.Point(2, 12);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(780, 91);
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
            this.UserAge.Location = new System.Drawing.Point(585, 117);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(42, 22);
            this.UserAge.TabIndex = 5;
            this.UserAge.Text = "Age";
            // 
            // UserGender
            // 
            this.UserGender.AutoSize = true;
            this.UserGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGender.Location = new System.Drawing.Point(8, 180);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(68, 22);
            this.UserGender.TabIndex = 7;
            this.UserGender.Text = "Gender";
            // 
            // countryChosen
            // 
            this.countryChosen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.countryChosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countryChosen.FormattingEnabled = true;
            this.countryChosen.Items.AddRange(new object[] {
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
            this.countryChosen.Location = new System.Drawing.Point(305, 343);
            this.countryChosen.Name = "countryChosen";
            this.countryChosen.Size = new System.Drawing.Size(121, 28);
            this.countryChosen.TabIndex = 15;
            // 
            // UserCountry
            // 
            this.UserCountry.AutoSize = true;
            this.UserCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCountry.Location = new System.Drawing.Point(301, 316);
            this.UserCountry.Name = "UserCountry";
            this.UserCountry.Size = new System.Drawing.Size(75, 22);
            this.UserCountry.TabIndex = 16;
            this.UserCountry.Text = "Country";
            this.UserCountry.Click += new System.EventHandler(this.UserCountry_Click);
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(556, 180);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(226, 22);
            this.survey.TabIndex = 17;
            this.survey.Text = "Did you leave the country?";
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.subBtn.Location = new System.Drawing.Point(614, 338);
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
            this.ageBox.Location = new System.Drawing.Point(589, 142);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(70, 26);
            this.ageBox.TabIndex = 21;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            this.ageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageBox_KeyPress);
            // 
            // selectedItemBox
            // 
            this.selectedItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectedItemBox.Location = new System.Drawing.Point(439, 341);
            this.selectedItemBox.Name = "selectedItemBox";
            this.selectedItemBox.Size = new System.Drawing.Size(41, 26);
            this.selectedItemBox.TabIndex = 22;
            this.selectedItemBox.Visible = false;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(12, 205);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(48, 17);
            this.checkMale.TabIndex = 23;
            this.checkMale.TabStop = true;
            this.checkMale.Text = "Male";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(12, 228);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(59, 17);
            this.checkFemale.TabIndex = 24;
            this.checkFemale.TabStop = true;
            this.checkFemale.Text = "Female";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // checkNope
            // 
            this.checkNope.AutoSize = true;
            this.checkNope.Location = new System.Drawing.Point(12, 297);
            this.checkNope.Name = "checkNope";
            this.checkNope.Size = new System.Drawing.Size(122, 17);
            this.checkNope.TabIndex = 26;
            this.checkNope.TabStop = true;
            this.checkNope.Text = "I do not prefer to say";
            this.checkNope.UseVisualStyleBackColor = true;
            // 
            // checkOption
            // 
            this.checkOption.AutoSize = true;
            this.checkOption.Location = new System.Drawing.Point(12, 320);
            this.checkOption.Name = "checkOption";
            this.checkOption.Size = new System.Drawing.Size(51, 17);
            this.checkOption.TabIndex = 25;
            this.checkOption.TabStop = true;
            this.checkOption.Text = "Other";
            this.checkOption.UseVisualStyleBackColor = true;
            // 
            // checkTransFemale
            // 
            this.checkTransFemale.AutoSize = true;
            this.checkTransFemale.Location = new System.Drawing.Point(12, 274);
            this.checkTransFemale.Name = "checkTransFemale";
            this.checkTransFemale.Size = new System.Drawing.Size(122, 17);
            this.checkTransFemale.TabIndex = 28;
            this.checkTransFemale.TabStop = true;
            this.checkTransFemale.Text = "Transgender Female";
            this.checkTransFemale.UseVisualStyleBackColor = true;
            // 
            // checkTransMale
            // 
            this.checkTransMale.AutoSize = true;
            this.checkTransMale.Location = new System.Drawing.Point(12, 251);
            this.checkTransMale.Name = "checkTransMale";
            this.checkTransMale.Size = new System.Drawing.Size(111, 17);
            this.checkTransMale.TabIndex = 27;
            this.checkTransMale.TabStop = true;
            this.checkTransMale.Text = "Transgender Male";
            this.checkTransMale.UseVisualStyleBackColor = true;
            // 
            // chosenGender
            // 
            this.chosenGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chosenGender.Location = new System.Drawing.Point(147, 314);
            this.chosenGender.Name = "chosenGender";
            this.chosenGender.Size = new System.Drawing.Size(100, 26);
            this.chosenGender.TabIndex = 31;
            this.chosenGender.Visible = false;
            // 
            // ageOut
            // 
            this.ageOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageOut.Location = new System.Drawing.Point(665, 142);
            this.ageOut.Name = "ageOut";
            this.ageOut.Size = new System.Drawing.Size(38, 26);
            this.ageOut.TabIndex = 32;
            this.ageOut.Visible = false;
            // 
            // optionText
            // 
            this.optionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.optionText.Location = new System.Drawing.Point(27, 343);
            this.optionText.Name = "optionText";
            this.optionText.Size = new System.Drawing.Size(202, 26);
            this.optionText.TabIndex = 33;
            // 
            // surveyYN
            // 
            this.surveyYN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.surveyYN.Location = new System.Drawing.Point(6, 56);
            this.surveyYN.Name = "surveyYN";
            this.surveyYN.Size = new System.Drawing.Size(84, 26);
            this.surveyYN.TabIndex = 34;
            this.surveyYN.Visible = false;
            // 
            // checkAffirmative
            // 
            this.checkAffirmative.AutoSize = true;
            this.checkAffirmative.Location = new System.Drawing.Point(6, 10);
            this.checkAffirmative.Name = "checkAffirmative";
            this.checkAffirmative.Size = new System.Drawing.Size(43, 17);
            this.checkAffirmative.TabIndex = 37;
            this.checkAffirmative.TabStop = true;
            this.checkAffirmative.Text = "Yes";
            this.checkAffirmative.UseVisualStyleBackColor = true;
            // 
            // checkNegative
            // 
            this.checkNegative.AutoSize = true;
            this.checkNegative.Location = new System.Drawing.Point(6, 33);
            this.checkNegative.Name = "checkNegative";
            this.checkNegative.Size = new System.Drawing.Size(39, 17);
            this.checkNegative.TabIndex = 38;
            this.checkNegative.TabStop = true;
            this.checkNegative.Text = "No";
            this.checkNegative.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAffirmative);
            this.groupBox1.Controls.Add(this.surveyYN);
            this.groupBox1.Controls.Add(this.checkNegative);
            this.groupBox1.Location = new System.Drawing.Point(560, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 86);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // contNum
            // 
            this.contNum.AutoSize = true;
            this.contNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contNum.Location = new System.Drawing.Point(301, 180);
            this.contNum.Name = "contNum";
            this.contNum.Size = new System.Drawing.Size(145, 22);
            this.contNum.TabIndex = 40;
            this.contNum.Text = "Contact Number";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(301, 246);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(149, 22);
            this.Address.TabIndex = 41;
            this.Address.Text = "Address(Present)";
            // 
            // contNumtxt
            // 
            this.contNumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contNumtxt.Location = new System.Drawing.Point(305, 207);
            this.contNumtxt.Name = "contNumtxt";
            this.contNumtxt.Size = new System.Drawing.Size(205, 26);
            this.contNumtxt.TabIndex = 42;
            this.contNumtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contNumtxt_KeyPress);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(305, 274);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(249, 31);
            this.addressTxt.TabIndex = 43;
            // 
            // conTracform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 384);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.contNumtxt);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.contNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.optionText);
            this.Controls.Add(this.ageOut);
            this.Controls.Add(this.chosenGender);
            this.Controls.Add(this.checkTransFemale);
            this.Controls.Add(this.checkTransMale);
            this.Controls.Add(this.checkNope);
            this.Controls.Add(this.checkOption);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.selectedItemBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.UserCountry);
            this.Controls.Add(this.countryChosen);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.nameLastBox);
            this.Controls.Add(this.UserName2);
            this.Controls.Add(this.nameFirstBox);
            this.Controls.Add(this.UserName1);
            this.Controls.Add(this.headerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "conTracform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.conTracform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox countryChosen;
        private System.Windows.Forms.Label UserCountry;
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox selectedItemBox;
        private System.Windows.Forms.RadioButton checkMale;
        private System.Windows.Forms.RadioButton checkFemale;
        private System.Windows.Forms.RadioButton checkNope;
        private System.Windows.Forms.RadioButton checkOption;
        private System.Windows.Forms.RadioButton checkTransFemale;
        private System.Windows.Forms.RadioButton checkTransMale;
        private System.Windows.Forms.TextBox chosenGender;
        private System.Windows.Forms.TextBox ageOut;
        private System.Windows.Forms.TextBox optionText;
        private System.Windows.Forms.TextBox surveyYN;
        private System.Windows.Forms.RadioButton checkAffirmative;
        private System.Windows.Forms.RadioButton checkNegative;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label contNum;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox contNumtxt;
        private System.Windows.Forms.TextBox addressTxt;
    }
}

