namespace SuirenMainForm
{
    partial class UserProfile
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLevel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxGender = new System.Windows.Forms.TextBox();
            this.textboxAge = new System.Windows.Forms.TextBox();
            this.textboxBirthdate = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.UploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.nameLabel.Location = new System.Drawing.Point(53, 177);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // genderLevel
            // 
            this.genderLevel.AutoSize = true;
            this.genderLevel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.genderLevel.Location = new System.Drawing.Point(53, 240);
            this.genderLevel.Name = "genderLevel";
            this.genderLevel.Size = new System.Drawing.Size(59, 20);
            this.genderLevel.TabIndex = 1;
            this.genderLevel.Text = "Gender";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.ageLabel.Location = new System.Drawing.Point(53, 301);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(36, 20);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Age";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.birthdateLabel.Location = new System.Drawing.Point(53, 362);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(75, 20);
            this.birthdateLabel.TabIndex = 3;
            this.birthdateLabel.Text = "Birthdate";
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.textboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.textboxName.Location = new System.Drawing.Point(55, 198);
            this.textboxName.Multiline = true;
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(207, 29);
            this.textboxName.TabIndex = 4;
            this.textboxName.TextChanged += new System.EventHandler(this.textboxName_TextChanged);
            // 
            // textboxGender
            // 
            this.textboxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.textboxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxGender.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.textboxGender.Location = new System.Drawing.Point(56, 261);
            this.textboxGender.Multiline = true;
            this.textboxGender.Name = "textboxGender";
            this.textboxGender.Size = new System.Drawing.Size(207, 29);
            this.textboxGender.TabIndex = 5;
            this.textboxGender.TextChanged += new System.EventHandler(this.textboxGender_TextChanged);
            // 
            // textboxAge
            // 
            this.textboxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.textboxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxAge.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.textboxAge.Location = new System.Drawing.Point(55, 322);
            this.textboxAge.Multiline = true;
            this.textboxAge.Name = "textboxAge";
            this.textboxAge.Size = new System.Drawing.Size(208, 29);
            this.textboxAge.TabIndex = 6;
            this.textboxAge.TextChanged += new System.EventHandler(this.textboxAge_TextChanged);
            // 
            // textboxBirthdate
            // 
            this.textboxBirthdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.textboxBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxBirthdate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.textboxBirthdate.Location = new System.Drawing.Point(55, 382);
            this.textboxBirthdate.Multiline = true;
            this.textboxBirthdate.Name = "textboxBirthdate";
            this.textboxBirthdate.Size = new System.Drawing.Size(208, 29);
            this.textboxBirthdate.TabIndex = 7;
            this.textboxBirthdate.TextChanged += new System.EventHandler(this.textboxBirthdate_TextChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.nextBtn.Location = new System.Drawing.Point(207, 440);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(87, 32);
            this.nextBtn.TabIndex = 32;
            this.nextBtn.Text = "NEXT";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.button1.Location = new System.Drawing.Point(27, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(107, 29);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(95, 90);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 33;
            this.image.TabStop = false;
            // 
            // UploadImage
            // 
            this.UploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.UploadImage.FlatAppearance.BorderSize = 0;
            this.UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadImage.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.UploadImage.Location = new System.Drawing.Point(100, 128);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(109, 27);
            this.UploadImage.TabIndex = 34;
            this.UploadImage.Text = "Upload Image";
            this.UploadImage.UseVisualStyleBackColor = false;
            this.UploadImage.Click += new System.EventHandler(this.UploadImage_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(322, 494);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.image);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxBirthdate);
            this.Controls.Add(this.textboxAge);
            this.Controls.Add(this.textboxGender);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.genderLevel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLevel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxGender;
        private System.Windows.Forms.TextBox textboxAge;
        private System.Windows.Forms.TextBox textboxBirthdate;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button UploadImage;
    }
}