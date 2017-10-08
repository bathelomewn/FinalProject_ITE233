namespace ICAMP_Project
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.sessionName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerActivity = new System.Windows.Forms.Button();
            this.chooseActivity = new System.Windows.Forms.Button();
            this.RegisterStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Details = new System.Windows.Forms.Button();
            this.signupSheets = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // sessionName
            // 
            this.sessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionName.FormattingEnabled = true;
            this.sessionName.Location = new System.Drawing.Point(275, 57);
            this.sessionName.Margin = new System.Windows.Forms.Padding(4);
            this.sessionName.Name = "sessionName";
            this.sessionName.Size = new System.Drawing.Size(172, 33);
            this.sessionName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Camp Session :";
            // 
            // sessionAdd
            // 
            this.sessionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionAdd.Location = new System.Drawing.Point(456, 57);
            this.sessionAdd.Margin = new System.Windows.Forms.Padding(4);
            this.sessionAdd.Name = "sessionAdd";
            this.sessionAdd.Size = new System.Drawing.Size(73, 28);
            this.sessionAdd.TabIndex = 3;
            this.sessionAdd.Text = "New";
            this.sessionAdd.UseVisualStyleBackColor = true;
            this.sessionAdd.Click += new System.EventHandler(this.sessionAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerActivity);
            this.groupBox1.Controls.Add(this.chooseActivity);
            this.groupBox1.Controls.Add(this.RegisterStudent);
            this.groupBox1.Location = new System.Drawing.Point(20, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(253, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // registerActivity
            // 
            this.registerActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerActivity.Location = new System.Drawing.Point(8, 154);
            this.registerActivity.Margin = new System.Windows.Forms.Padding(4);
            this.registerActivity.Name = "registerActivity";
            this.registerActivity.Size = new System.Drawing.Size(237, 53);
            this.registerActivity.TabIndex = 2;
            this.registerActivity.Text = "RegisterActivities";
            this.registerActivity.UseVisualStyleBackColor = true;
            this.registerActivity.Click += new System.EventHandler(this.registerActivity_Click);
            // 
            // chooseActivity
            // 
            this.chooseActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseActivity.Location = new System.Drawing.Point(8, 89);
            this.chooseActivity.Margin = new System.Windows.Forms.Padding(4);
            this.chooseActivity.Name = "chooseActivity";
            this.chooseActivity.Size = new System.Drawing.Size(237, 53);
            this.chooseActivity.TabIndex = 1;
            this.chooseActivity.Text = "Choose Activities";
            this.chooseActivity.UseVisualStyleBackColor = true;
            this.chooseActivity.Click += new System.EventHandler(this.chooseActivity_Click);
            // 
            // RegisterStudent
            // 
            this.RegisterStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterStudent.Location = new System.Drawing.Point(8, 23);
            this.RegisterStudent.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterStudent.Name = "RegisterStudent";
            this.RegisterStudent.Size = new System.Drawing.Size(237, 53);
            this.RegisterStudent.TabIndex = 0;
            this.RegisterStudent.Text = "Register/Edit";
            this.RegisterStudent.UseVisualStyleBackColor = true;
            this.RegisterStudent.Click += new System.EventHandler(this.RegisterStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.Details);
            this.groupBox2.Controls.Add(this.signupSheets);
            this.groupBox2.Location = new System.Drawing.Point(281, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(281, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Details
            // 
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.Location = new System.Drawing.Point(8, 155);
            this.Details.Margin = new System.Windows.Forms.Padding(4);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(261, 53);
            this.Details.TabIndex = 2;
            this.Details.Text = "Detail";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // signupSheets
            // 
            this.signupSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupSheets.Location = new System.Drawing.Point(8, 89);
            this.signupSheets.Margin = new System.Windows.Forms.Padding(4);
            this.signupSheets.Name = "signupSheets";
            this.signupSheets.Size = new System.Drawing.Size(261, 53);
            this.signupSheets.TabIndex = 1;
            this.signupSheets.Text = "Signup Sheet";
            this.signupSheets.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sessionAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessionName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sessionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sessionAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button registerActivity;
        private System.Windows.Forms.Button chooseActivity;
        private System.Windows.Forms.Button RegisterStudent;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button signupSheets;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

