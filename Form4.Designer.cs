namespace SuirenMainForm
{
    partial class Form4
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
            this.txtboxNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backtoLogIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(239, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set new password";
            // 
            // txtboxNewPassword
            // 
            this.txtboxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.txtboxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxNewPassword.Location = new System.Drawing.Point(196, 223);
            this.txtboxNewPassword.Multiline = true;
            this.txtboxNewPassword.Name = "txtboxNewPassword";
            this.txtboxNewPassword.Size = new System.Drawing.Size(301, 27);
            this.txtboxNewPassword.TabIndex = 3;
            this.txtboxNewPassword.TextChanged += new System.EventHandler(this.txtboxNewPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(193, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(193, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // txtboxConfirmNewPassword
            // 
            this.txtboxConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.txtboxConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtboxConfirmNewPassword.Location = new System.Drawing.Point(196, 306);
            this.txtboxConfirmNewPassword.Multiline = true;
            this.txtboxConfirmNewPassword.Name = "txtboxConfirmNewPassword";
            this.txtboxConfirmNewPassword.Size = new System.Drawing.Size(301, 27);
            this.txtboxConfirmNewPassword.TabIndex = 5;
            this.txtboxConfirmNewPassword.TextChanged += new System.EventHandler(this.txtboxConfirmNewPassword_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(94)))), ((int)(((byte)(52)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(268, 355);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(156, 48);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Reset Password";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backtoLogIn
            // 
            this.backtoLogIn.AutoSize = true;
            this.backtoLogIn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtoLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.backtoLogIn.Location = new System.Drawing.Point(300, 424);
            this.backtoLogIn.Name = "backtoLogIn";
            this.backtoLogIn.Size = new System.Drawing.Size(93, 18);
            this.backtoLogIn.TabIndex = 8;
            this.backtoLogIn.Text = "Back to log in";
            this.backtoLogIn.Click += new System.EventHandler(this.backtoLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuirenMainForm.Properties.Resources._495072494_2160193777737879_2814346733827445333_n;
            this.pictureBox1.Location = new System.Drawing.Point(301, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(49)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(261, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Must be at least 8 characters";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(732, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backtoLogIn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxConfirmNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxNewPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxConfirmNewPassword;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label backtoLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}