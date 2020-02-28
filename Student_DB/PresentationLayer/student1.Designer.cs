namespace PresentationLayer
{
    partial class student1
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
            this.FormHeading = new System.Windows.Forms.Label();
            this.getbtn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhoneno = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStudentid = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormHeading
            // 
            this.FormHeading.AutoSize = true;
            this.FormHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormHeading.Location = new System.Drawing.Point(528, 145);
            this.FormHeading.Name = "FormHeading";
            this.FormHeading.Size = new System.Drawing.Size(144, 26);
            this.FormHeading.TabIndex = 41;
            this.FormHeading.Text = "Student Form";
            // 
            // getbtn
            // 
            this.getbtn.Location = new System.Drawing.Point(821, 557);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(75, 23);
            this.getbtn.TabIndex = 40;
            this.getbtn.Text = "GET";
            this.getbtn.UseVisualStyleBackColor = true;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(699, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(571, 557);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 207);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(454, 557);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(389, 252);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 35;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(389, 304);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 34;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(389, 361);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 33;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(389, 411);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 32;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(389, 454);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 31;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(389, 505);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 30;
            // 
            // txtStudentid
            // 
            this.txtStudentid.Location = new System.Drawing.Point(389, 196);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(100, 20);
            this.txtStudentid.TabIndex = 29;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLastName.Location = new System.Drawing.Point(268, 303);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last_Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGender.Location = new System.Drawing.Point(271, 349);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 18);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "Gender";
            // 
            // lblPhoneno
            // 
            this.lblPhoneno.AutoSize = true;
            this.lblPhoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPhoneno.Location = new System.Drawing.Point(268, 401);
            this.lblPhoneno.Name = "lblPhoneno";
            this.lblPhoneno.Size = new System.Drawing.Size(76, 18);
            this.lblPhoneno.TabIndex = 26;
            this.lblPhoneno.Text = "Phone_no";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblState.Location = new System.Drawing.Point(267, 453);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 18);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCountry.Location = new System.Drawing.Point(268, 504);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 18);
            this.lblCountry.TabIndex = 24;
            this.lblCountry.Text = "Country";
            // 
            // lblStudentid
            // 
            this.lblStudentid.AutoSize = true;
            this.lblStudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblStudentid.Location = new System.Drawing.Point(268, 198);
            this.lblStudentid.Name = "lblStudentid";
            this.lblStudentid.Size = new System.Drawing.Size(77, 18);
            this.lblStudentid.TabIndex = 23;
            this.lblStudentid.Text = "Student_id";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFirstName.Location = new System.Drawing.Point(268, 251);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 18);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First_Name";
            // 
            // student1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 725);
            this.Controls.Add(this.FormHeading);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtStudentid);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhoneno);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblStudentid);
            this.Controls.Add(this.lblFirstName);
            this.Name = "student1";
            this.Text = "student1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormHeading;
        private System.Windows.Forms.Button getbtn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneno;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStudentid;
        private System.Windows.Forms.Label lblFirstName;
    }
}