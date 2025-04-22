namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backtoLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkboxShowPassword
            // 
            this.checkboxShowPassword.AutoSize = true;
            this.checkboxShowPassword.Location = new System.Drawing.Point(54, 284);
            this.checkboxShowPassword.Name = "checkboxShowPassword";
            this.checkboxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkboxShowPassword.TabIndex = 4;
            this.checkboxShowPassword.Text = "Show Password";
            this.checkboxShowPassword.UseVisualStyleBackColor = true;
            this.checkboxShowPassword.CheckedChanged += new System.EventHandler(this.checkboxShowPassword_CheckedChanged);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(54, 138);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsername.TabIndex = 5;
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(54, 193);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtboxPassword.TabIndex = 6;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // txtboxConfirmPassword
            // 
            this.txtboxConfirmPassword.Location = new System.Drawing.Point(54, 246);
            this.txtboxConfirmPassword.Name = "txtboxConfirmPassword";
            this.txtboxConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtboxConfirmPassword.TabIndex = 7;
            this.txtboxConfirmPassword.TextChanged += new System.EventHandler(this.txtboxConfirmPassword_TextChanged);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(54, 318);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(54, 347);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // backtoLogin
            // 
            this.backtoLogin.AutoSize = true;
            this.backtoLogin.Location = new System.Drawing.Point(51, 415);
            this.backtoLogin.Name = "backtoLogin";
            this.backtoLogin.Size = new System.Drawing.Size(77, 13);
            this.backtoLogin.TabIndex = 11;
            this.backtoLogin.Text = "Back to Log In";
            this.backtoLogin.Click += new System.EventHandler(this.backtoLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 505);
            this.Controls.Add(this.backtoLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.txtboxConfirmPassword);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.checkboxShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxShowPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxConfirmPassword;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label backtoLogin;
    }
}

