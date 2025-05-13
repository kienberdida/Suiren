namespace SuirenMainForm
{
    partial class Day3
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NightFullRoutineBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.MorningFullRoutineBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.NightFullRoutineBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(482, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 339);
            this.panel2.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 250);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // NightFullRoutineBtn
            // 
            this.NightFullRoutineBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NightFullRoutineBtn.FlatAppearance.BorderSize = 0;
            this.NightFullRoutineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NightFullRoutineBtn.Location = new System.Drawing.Point(166, 15);
            this.NightFullRoutineBtn.Name = "NightFullRoutineBtn";
            this.NightFullRoutineBtn.Size = new System.Drawing.Size(103, 23);
            this.NightFullRoutineBtn.TabIndex = 6;
            this.NightFullRoutineBtn.Text = "DONE!";
            this.NightFullRoutineBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Night";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.MorningFullRoutineBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(135, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 339);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(23, 56);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 250);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // MorningFullRoutineBtn
            // 
            this.MorningFullRoutineBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MorningFullRoutineBtn.FlatAppearance.BorderSize = 0;
            this.MorningFullRoutineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MorningFullRoutineBtn.Location = new System.Drawing.Point(171, 18);
            this.MorningFullRoutineBtn.Name = "MorningFullRoutineBtn";
            this.MorningFullRoutineBtn.Size = new System.Drawing.Size(102, 23);
            this.MorningFullRoutineBtn.TabIndex = 5;
            this.MorningFullRoutineBtn.Text = "DONE!";
            this.MorningFullRoutineBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morning";
            // 
            // Day3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Day3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button NightFullRoutineBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button MorningFullRoutineBtn;
        private System.Windows.Forms.Label label2;
    }
}