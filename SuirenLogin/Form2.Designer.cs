namespace WindowsFormsApp3
{
    partial class Form2
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
            this.createAccount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.checkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Location = new System.Drawing.Point(68, 407);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(80, 13);
            this.createAccount.TabIndex = 23;
            this.createAccount.Text = "Create account";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Don\'t have an account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(69, 290);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(69, 261);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(71, 185);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtboxPassword.TabIndex = 18;
            this.txtboxPassword.TextChanged += new System.EventHandler(this.txtboxPassword_TextChanged);
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(71, 130);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtboxUsername.TabIndex = 17;
            this.txtboxUsername.TextChanged += new System.EventHandler(this.txtboxUsername_TextChanged);
            // 
            // checkboxShowPassword
            // 
            this.checkboxShowPassword.AutoSize = true;
            this.checkboxShowPassword.Location = new System.Drawing.Point(69, 223);
            this.checkboxShowPassword.Name = "checkboxShowPassword";
            this.checkboxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.checkboxShowPassword.TabIndex = 16;
            this.checkboxShowPassword.Text = "Show Password";
            this.checkboxShowPassword.UseVisualStyleBackColor = true;
            this.checkboxShowPassword.CheckedChanged += new System.EventHandler(this.checkboxShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 505);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.checkboxShowPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.CheckBox checkboxShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}