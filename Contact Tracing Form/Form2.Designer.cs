
namespace Contact_Tracing_Form
{
    partial class printForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printForm));
            this.survey = new System.Windows.Forms.Label();
            this.UserCountry = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.Label();
            this.UserAge = new System.Windows.Forms.Label();
            this.UserName2 = new System.Windows.Forms.Label();
            this.UserName1 = new System.Windows.Forms.Label();
            this.headerBox = new System.Windows.Forms.PictureBox();
            this.nameFirstBox = new System.Windows.Forms.TextBox();
            this.nameLastBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.surveyBox = new System.Windows.Forms.TextBox();
            this.contNum2 = new System.Windows.Forms.Label();
            this.Address2 = new System.Windows.Forms.Label();
            this.contNumtxt2 = new System.Windows.Forms.TextBox();
            this.addressTxt2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(301, 252);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(226, 22);
            this.survey.TabIndex = 38;
            this.survey.Text = "Did you leave the country?";
            // 
            // UserCountry
            // 
            this.UserCountry.AutoSize = true;
            this.UserCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCountry.Location = new System.Drawing.Point(301, 184);
            this.UserCountry.Name = "UserCountry";
            this.UserCountry.Size = new System.Drawing.Size(75, 22);
            this.UserCountry.TabIndex = 37;
            this.UserCountry.Text = "Country";
            // 
            // UserGender
            // 
            this.UserGender.AutoSize = true;
            this.UserGender.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGender.Location = new System.Drawing.Point(12, 184);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(68, 22);
            this.UserGender.TabIndex = 28;
            this.UserGender.Text = "Gender";
            // 
            // UserAge
            // 
            this.UserAge.AutoSize = true;
            this.UserAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAge.Location = new System.Drawing.Point(603, 117);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(42, 22);
            this.UserAge.TabIndex = 26;
            this.UserAge.Text = "Age";
            // 
            // UserName2
            // 
            this.UserName2.AutoSize = true;
            this.UserName2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName2.Location = new System.Drawing.Point(301, 117);
            this.UserName2.Name = "UserName2";
            this.UserName2.Size = new System.Drawing.Size(97, 22);
            this.UserName2.TabIndex = 24;
            this.UserName2.Text = " Last name";
            // 
            // UserName1
            // 
            this.UserName1.AutoSize = true;
            this.UserName1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName1.Location = new System.Drawing.Point(8, 117);
            this.UserName1.Name = "UserName1";
            this.UserName1.Size = new System.Drawing.Size(100, 22);
            this.UserName1.TabIndex = 22;
            this.UserName1.Text = " First name";
            // 
            // headerBox
            // 
            this.headerBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("headerBox.ErrorImage")));
            this.headerBox.Image = ((System.Drawing.Image)(resources.GetObject("headerBox.Image")));
            this.headerBox.InitialImage = null;
            this.headerBox.Location = new System.Drawing.Point(3, 3);
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(780, 91);
            this.headerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerBox.TabIndex = 21;
            this.headerBox.TabStop = false;
            // 
            // nameFirstBox
            // 
            this.nameFirstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFirstBox.Location = new System.Drawing.Point(12, 142);
            this.nameFirstBox.Name = "nameFirstBox";
            this.nameFirstBox.Size = new System.Drawing.Size(263, 26);
            this.nameFirstBox.TabIndex = 39;
            this.nameFirstBox.TextChanged += new System.EventHandler(this.nameFirstBox_TextChanged);
            // 
            // nameLastBox
            // 
            this.nameLastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLastBox.Location = new System.Drawing.Point(305, 142);
            this.nameLastBox.Name = "nameLastBox";
            this.nameLastBox.Size = new System.Drawing.Size(263, 26);
            this.nameLastBox.TabIndex = 40;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(607, 142);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(70, 26);
            this.ageBox.TabIndex = 41;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.Location = new System.Drawing.Point(305, 209);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(259, 26);
            this.countryBox.TabIndex = 42;
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.Location = new System.Drawing.Point(16, 209);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(259, 26);
            this.genderBox.TabIndex = 43;
            // 
            // surveyBox
            // 
            this.surveyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surveyBox.Location = new System.Drawing.Point(309, 277);
            this.surveyBox.Name = "surveyBox";
            this.surveyBox.Size = new System.Drawing.Size(67, 26);
            this.surveyBox.TabIndex = 44;
            // 
            // contNum2
            // 
            this.contNum2.AutoSize = true;
            this.contNum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contNum2.Location = new System.Drawing.Point(12, 257);
            this.contNum2.Name = "contNum2";
            this.contNum2.Size = new System.Drawing.Size(145, 22);
            this.contNum2.TabIndex = 45;
            this.contNum2.Text = "Contact Number";
            // 
            // Address2
            // 
            this.Address2.AutoSize = true;
            this.Address2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address2.Location = new System.Drawing.Point(12, 325);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(149, 22);
            this.Address2.TabIndex = 46;
            this.Address2.Text = "Address(Present)";
            // 
            // contNumtxt2
            // 
            this.contNumtxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contNumtxt2.Location = new System.Drawing.Point(16, 282);
            this.contNumtxt2.Name = "contNumtxt2";
            this.contNumtxt2.Size = new System.Drawing.Size(259, 26);
            this.contNumtxt2.TabIndex = 47;
            // 
            // addressTxt2
            // 
            this.addressTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt2.Location = new System.Drawing.Point(16, 350);
            this.addressTxt2.Multiline = true;
            this.addressTxt2.Name = "addressTxt2";
            this.addressTxt2.Size = new System.Drawing.Size(259, 26);
            this.addressTxt2.TabIndex = 48;
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 384);
            this.Controls.Add(this.addressTxt2);
            this.Controls.Add(this.contNumtxt2);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.contNum2);
            this.Controls.Add(this.surveyBox);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameLastBox);
            this.Controls.Add(this.nameFirstBox);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.UserCountry);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.UserName2);
            this.Controls.Add(this.UserName1);
            this.Controls.Add(this.headerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "printForm";
            this.Text = "Respondent\'s record:";
            this.Load += new System.EventHandler(this.printForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Label UserCountry;
        private System.Windows.Forms.Label UserGender;
        private System.Windows.Forms.Label UserAge;
        private System.Windows.Forms.Label UserName2;
        private System.Windows.Forms.Label UserName1;
        private System.Windows.Forms.PictureBox headerBox;
        private System.Windows.Forms.TextBox nameFirstBox;
        private System.Windows.Forms.TextBox nameLastBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.TextBox surveyBox;
        private System.Windows.Forms.Label contNum2;
        private System.Windows.Forms.Label Address2;
        private System.Windows.Forms.TextBox contNumtxt2;
        private System.Windows.Forms.TextBox addressTxt2;
    }
}