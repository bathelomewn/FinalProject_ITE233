using System;

namespace ICAMP_Project
{
    partial class CamperRegister
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.selectCamper = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.bunk = new System.Windows.Forms.ComboBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.transpotation = new System.Windows.Forms.TextBox();
            this.medication = new System.Windows.Forms.TextBox();
            this.restriction = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.emailparent2 = new System.Windows.Forms.TextBox();
            this.phoneparent2 = new System.Windows.Forms.TextBox();
            this.nameparent2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.emailparent1 = new System.Windows.Forms.TextBox();
            this.phoneparent1 = new System.Windows.Forms.TextBox();
            this.nameparent1 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMainTitle.Location = new System.Drawing.Point(237, 18);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(407, 45);
            this.lblMainTitle.TabIndex = 12;
            this.lblMainTitle.Text = "Register/Update Campers";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(245, 579);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(89, 38);
            this.registerBtn.TabIndex = 18;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // selectCamper
            // 
            this.selectCamper.FormattingEnabled = true;
            this.selectCamper.Location = new System.Drawing.Point(297, 92);
            this.selectCamper.Margin = new System.Windows.Forms.Padding(4);
            this.selectCamper.Name = "selectCamper";
            this.selectCamper.Size = new System.Drawing.Size(262, 24);
            this.selectCamper.TabIndex = 14;
            this.selectCamper.Text = "Select Camper Info";
            this.selectCamper.SelectedIndexChanged += new System.EventHandler(this.selectCamper_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(366, 579);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(81, 38);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // bunk
            // 
            this.bunk.FormattingEnabled = true;
            this.bunk.Location = new System.Drawing.Point(138, 63);
            this.bunk.Margin = new System.Windows.Forms.Padding(4);
            this.bunk.Name = "bunk";
            this.bunk.Size = new System.Drawing.Size(221, 24);
            this.bunk.TabIndex = 22;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(138, 184);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(221, 22);
            this.StartDate.TabIndex = 21;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(139, 224);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(221, 22);
            this.EndDate.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 374);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Transportation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunk);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Controls.Add(this.EndDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.transpotation);
            this.groupBox1.Controls.Add(this.medication);
            this.groupBox1.Controls.Add(this.restriction);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nickname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nationality);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(380, 411);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CamperInfo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Medications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Restriction";
            // 
            // transpotation
            // 
            this.transpotation.ForeColor = System.Drawing.SystemColors.MenuText;
            this.transpotation.Location = new System.Drawing.Point(137, 371);
            this.transpotation.Margin = new System.Windows.Forms.Padding(4);
            this.transpotation.Name = "transpotation";
            this.transpotation.Size = new System.Drawing.Size(221, 22);
            this.transpotation.TabIndex = 16;
            // 
            // medication
            // 
            this.medication.ForeColor = System.Drawing.SystemColors.MenuText;
            this.medication.Location = new System.Drawing.Point(137, 136);
            this.medication.Margin = new System.Windows.Forms.Padding(4);
            this.medication.Name = "medication";
            this.medication.Size = new System.Drawing.Size(223, 22);
            this.medication.TabIndex = 15;
            // 
            // restriction
            // 
            this.restriction.ForeColor = System.Drawing.SystemColors.MenuText;
            this.restriction.Location = new System.Drawing.Point(137, 335);
            this.restriction.Margin = new System.Windows.Forms.Padding(4);
            this.restriction.Name = "restriction";
            this.restriction.Size = new System.Drawing.Size(221, 22);
            this.restriction.TabIndex = 14;
            // 
            // age
            // 
            this.age.ForeColor = System.Drawing.SystemColors.MenuText;
            this.age.Location = new System.Drawing.Point(137, 299);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(221, 22);
            this.age.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Age";
            // 
            // nickname
            // 
            this.nickname.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nickname.Location = new System.Drawing.Point(137, 262);
            this.nickname.Margin = new System.Windows.Forms.Padding(4);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(221, 22);
            this.nickname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prefered Name";
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(138, 100);
            this.nationality.Margin = new System.Windows.Forms.Padding(4);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(221, 22);
            this.nationality.TabIndex = 7;
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.SystemColors.MenuText;
            this.name.Location = new System.Drawing.Point(138, 27);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(221, 22);
            this.name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Strat Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nationality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bunk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.emailparent2);
            this.groupBox3.Controls.Add(this.phoneparent2);
            this.groupBox3.Controls.Add(this.nameparent2);
            this.groupBox3.Location = new System.Drawing.Point(448, 367);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(354, 123);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parent2 Info";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Phone Number";
            // 
            // emailparent2
            // 
            this.emailparent2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailparent2.Location = new System.Drawing.Point(128, 87);
            this.emailparent2.Margin = new System.Windows.Forms.Padding(4);
            this.emailparent2.Name = "emailparent2";
            this.emailparent2.Size = new System.Drawing.Size(216, 22);
            this.emailparent2.TabIndex = 27;
            // 
            // phoneparent2
            // 
            this.phoneparent2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.phoneparent2.Location = new System.Drawing.Point(128, 55);
            this.phoneparent2.Margin = new System.Windows.Forms.Padding(4);
            this.phoneparent2.Name = "phoneparent2";
            this.phoneparent2.Size = new System.Drawing.Size(216, 22);
            this.phoneparent2.TabIndex = 26;
            // 
            // nameparent2
            // 
            this.nameparent2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nameparent2.Location = new System.Drawing.Point(128, 23);
            this.nameparent2.Margin = new System.Windows.Forms.Padding(4);
            this.nameparent2.Name = "nameparent2";
            this.nameparent2.Size = new System.Drawing.Size(216, 22);
            this.nameparent2.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.emailparent1);
            this.groupBox2.Controls.Add(this.phoneparent1);
            this.groupBox2.Controls.Add(this.nameparent1);
            this.groupBox2.Location = new System.Drawing.Point(448, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(354, 123);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parent1 Info";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name";
            // 
            // emailparent1
            // 
            this.emailparent1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailparent1.Location = new System.Drawing.Point(120, 87);
            this.emailparent1.Margin = new System.Windows.Forms.Padding(4);
            this.emailparent1.Name = "emailparent1";
            this.emailparent1.Size = new System.Drawing.Size(209, 22);
            this.emailparent1.TabIndex = 24;
            // 
            // phoneparent1
            // 
            this.phoneparent1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.phoneparent1.Location = new System.Drawing.Point(120, 55);
            this.phoneparent1.Margin = new System.Windows.Forms.Padding(4);
            this.phoneparent1.Name = "phoneparent1";
            this.phoneparent1.Size = new System.Drawing.Size(209, 22);
            this.phoneparent1.TabIndex = 23;
            // 
            // nameparent1
            // 
            this.nameparent1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nameparent1.Location = new System.Drawing.Point(120, 23);
            this.nameparent1.Margin = new System.Windows.Forms.Padding(4);
            this.nameparent1.Name = "nameparent1";
            this.nameparent1.Size = new System.Drawing.Size(209, 22);
            this.nameparent1.TabIndex = 22;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(482, 579);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 38);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CamperRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.selectCamper);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMainTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CamperRegister";
            this.Text = "CamperRegister";
            this.Load += new System.EventHandler(this.CamperRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ComboBox selectCamper;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox bunk;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox transpotation;
        private System.Windows.Forms.TextBox medication;
        private System.Windows.Forms.TextBox restriction;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox emailparent2;
        private System.Windows.Forms.TextBox phoneparent2;
        private System.Windows.Forms.TextBox nameparent2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailparent1;
        private System.Windows.Forms.TextBox phoneparent1;
        private System.Windows.Forms.TextBox nameparent1;
        private System.Windows.Forms.Button deleteBtn;
    }
}