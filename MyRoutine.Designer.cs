namespace SuirenMainForm
{
    partial class MyRoutine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.MorningFullRoutineBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NightFullRoutineBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Day1 = new System.Windows.Forms.CheckBox();
            this.Day2 = new System.Windows.Forms.CheckBox();
            this.Day4 = new System.Windows.Forms.CheckBox();
            this.Day3 = new System.Windows.Forms.CheckBox();
            this.Day6 = new System.Windows.Forms.CheckBox();
            this.Day5 = new System.Windows.Forms.CheckBox();
            this.Day7 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Routine";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.MorningFullRoutineBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 416);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(23, 56);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(363, 344);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // MorningFullRoutineBtn
            // 
            this.MorningFullRoutineBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MorningFullRoutineBtn.FlatAppearance.BorderSize = 0;
            this.MorningFullRoutineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MorningFullRoutineBtn.Location = new System.Drawing.Point(247, 15);
            this.MorningFullRoutineBtn.Name = "MorningFullRoutineBtn";
            this.MorningFullRoutineBtn.Size = new System.Drawing.Size(139, 23);
            this.MorningFullRoutineBtn.TabIndex = 5;
            this.MorningFullRoutineBtn.Text = "Edit Routine";
            this.MorningFullRoutineBtn.UseVisualStyleBackColor = false;
            this.MorningFullRoutineBtn.Click += new System.EventHandler(this.MorningFullRoutineBtn_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.NightFullRoutineBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(457, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 416);
            this.panel2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 344);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // NightFullRoutineBtn
            // 
            this.NightFullRoutineBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NightFullRoutineBtn.FlatAppearance.BorderSize = 0;
            this.NightFullRoutineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NightFullRoutineBtn.Location = new System.Drawing.Point(242, 18);
            this.NightFullRoutineBtn.Name = "NightFullRoutineBtn";
            this.NightFullRoutineBtn.Size = new System.Drawing.Size(140, 23);
            this.NightFullRoutineBtn.TabIndex = 6;
            this.NightFullRoutineBtn.Text = "Edit Routine";
            this.NightFullRoutineBtn.UseVisualStyleBackColor = false;
            this.NightFullRoutineBtn.Click += new System.EventHandler(this.NightFullRoutineBtn_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Progress";
            // 
            // Day1
            // 
            this.Day1.AutoSize = true;
            this.Day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day1.Location = new System.Drawing.Point(36, 600);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(93, 29);
            this.Day1.TabIndex = 4;
            this.Day1.Text = "DAY 1";
            this.Day1.UseVisualStyleBackColor = true;
            this.Day1.CheckedChanged += new System.EventHandler(this.Day1_CheckedChanged);
            // 
            // Day2
            // 
            this.Day2.AutoSize = true;
            this.Day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day2.Location = new System.Drawing.Point(175, 600);
            this.Day2.Name = "Day2";
            this.Day2.Size = new System.Drawing.Size(93, 29);
            this.Day2.TabIndex = 5;
            this.Day2.Text = "DAY 2";
            this.Day2.UseVisualStyleBackColor = true;
            this.Day2.CheckedChanged += new System.EventHandler(this.Day2_CheckedChanged);
            // 
            // Day4
            // 
            this.Day4.AutoSize = true;
            this.Day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day4.Location = new System.Drawing.Point(468, 600);
            this.Day4.Name = "Day4";
            this.Day4.Size = new System.Drawing.Size(93, 29);
            this.Day4.TabIndex = 7;
            this.Day4.Text = "DAY 4";
            this.Day4.UseVisualStyleBackColor = true;
            this.Day4.CheckedChanged += new System.EventHandler(this.Day4_CheckedChanged);
            // 
            // Day3
            // 
            this.Day3.AutoSize = true;
            this.Day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day3.Location = new System.Drawing.Point(329, 600);
            this.Day3.Name = "Day3";
            this.Day3.Size = new System.Drawing.Size(93, 29);
            this.Day3.TabIndex = 6;
            this.Day3.Text = "DAY 3";
            this.Day3.UseVisualStyleBackColor = true;
            this.Day3.CheckedChanged += new System.EventHandler(this.Day3_CheckedChanged);
            // 
            // Day6
            // 
            this.Day6.AutoSize = true;
            this.Day6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day6.Location = new System.Drawing.Point(762, 600);
            this.Day6.Name = "Day6";
            this.Day6.Size = new System.Drawing.Size(93, 29);
            this.Day6.TabIndex = 9;
            this.Day6.Text = "DAY 6";
            this.Day6.UseVisualStyleBackColor = true;
            this.Day6.CheckedChanged += new System.EventHandler(this.Day6_CheckedChanged);
            // 
            // Day5
            // 
            this.Day5.AutoSize = true;
            this.Day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day5.Location = new System.Drawing.Point(623, 600);
            this.Day5.Name = "Day5";
            this.Day5.Size = new System.Drawing.Size(93, 29);
            this.Day5.TabIndex = 8;
            this.Day5.Text = "DAY 5";
            this.Day5.UseVisualStyleBackColor = true;
            this.Day5.CheckedChanged += new System.EventHandler(this.Day5_CheckedChanged);
            // 
            // Day7
            // 
            this.Day7.AutoSize = true;
            this.Day7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day7.Location = new System.Drawing.Point(919, 600);
            this.Day7.Name = "Day7";
            this.Day7.Size = new System.Drawing.Size(93, 29);
            this.Day7.TabIndex = 10;
            this.Day7.Text = "DAY 7";
            this.Day7.UseVisualStyleBackColor = true;
            this.Day7.CheckedChanged += new System.EventHandler(this.Day7_CheckedChanged);
            // 
            // MyRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1117, 562);
            this.Controls.Add(this.Day7);
            this.Controls.Add(this.Day6);
            this.Controls.Add(this.Day5);
            this.Controls.Add(this.Day4);
            this.Controls.Add(this.Day3);
            this.Controls.Add(this.Day2);
            this.Controls.Add(this.Day1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyRoutine";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1000);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRoutine";
            this.Load += new System.EventHandler(this.MyRoutine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MorningFullRoutineBtn;
        private System.Windows.Forms.Button NightFullRoutineBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Day1;
        private System.Windows.Forms.CheckBox Day2;
        private System.Windows.Forms.CheckBox Day4;
        private System.Windows.Forms.CheckBox Day3;
        private System.Windows.Forms.CheckBox Day6;
        private System.Windows.Forms.CheckBox Day5;
        private System.Windows.Forms.CheckBox Day7;
    }
}