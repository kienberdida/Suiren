namespace SuirenMainForm
{
    partial class TimelineProgress
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Day7Btn = new System.Windows.Forms.Button();
            this.Day6Btn = new System.Windows.Forms.Button();
            this.Day5Btn = new System.Windows.Forms.Button();
            this.Day4Btn = new System.Windows.Forms.Button();
            this.Day3Btn = new System.Windows.Forms.Button();
            this.Day2Btn = new System.Windows.Forms.Button();
            this.Day1Btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Day7Btn);
            this.panel1.Controls.Add(this.Day6Btn);
            this.panel1.Controls.Add(this.Day5Btn);
            this.panel1.Controls.Add(this.Day4Btn);
            this.panel1.Controls.Add(this.Day3Btn);
            this.panel1.Controls.Add(this.Day2Btn);
            this.panel1.Controls.Add(this.Day1Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 522);
            this.panel1.TabIndex = 0;
            // 
            // Day7Btn
            // 
            this.Day7Btn.Location = new System.Drawing.Point(0, 456);
            this.Day7Btn.Name = "Day7Btn";
            this.Day7Btn.Size = new System.Drawing.Size(194, 52);
            this.Day7Btn.TabIndex = 6;
            this.Day7Btn.Text = "DAY 7";
            this.Day7Btn.UseVisualStyleBackColor = true;
            // 
            // Day6Btn
            // 
            this.Day6Btn.Location = new System.Drawing.Point(0, 398);
            this.Day6Btn.Name = "Day6Btn";
            this.Day6Btn.Size = new System.Drawing.Size(194, 52);
            this.Day6Btn.TabIndex = 5;
            this.Day6Btn.Text = "DAY 6";
            this.Day6Btn.UseVisualStyleBackColor = true;
            // 
            // Day5Btn
            // 
            this.Day5Btn.Location = new System.Drawing.Point(0, 340);
            this.Day5Btn.Name = "Day5Btn";
            this.Day5Btn.Size = new System.Drawing.Size(194, 52);
            this.Day5Btn.TabIndex = 4;
            this.Day5Btn.Text = "DAY 5";
            this.Day5Btn.UseVisualStyleBackColor = true;
            // 
            // Day4Btn
            // 
            this.Day4Btn.Location = new System.Drawing.Point(0, 282);
            this.Day4Btn.Name = "Day4Btn";
            this.Day4Btn.Size = new System.Drawing.Size(194, 52);
            this.Day4Btn.TabIndex = 3;
            this.Day4Btn.Text = "DAY 4";
            this.Day4Btn.UseVisualStyleBackColor = true;
            // 
            // Day3Btn
            // 
            this.Day3Btn.Location = new System.Drawing.Point(0, 224);
            this.Day3Btn.Name = "Day3Btn";
            this.Day3Btn.Size = new System.Drawing.Size(194, 52);
            this.Day3Btn.TabIndex = 2;
            this.Day3Btn.Text = "DAY 3";
            this.Day3Btn.UseVisualStyleBackColor = true;
            // 
            // Day2Btn
            // 
            this.Day2Btn.Location = new System.Drawing.Point(0, 166);
            this.Day2Btn.Name = "Day2Btn";
            this.Day2Btn.Size = new System.Drawing.Size(194, 52);
            this.Day2Btn.TabIndex = 1;
            this.Day2Btn.Text = "DAY 2";
            this.Day2Btn.UseVisualStyleBackColor = true;
            // 
            // Day1Btn
            // 
            this.Day1Btn.Location = new System.Drawing.Point(0, 108);
            this.Day1Btn.Name = "Day1Btn";
            this.Day1Btn.Size = new System.Drawing.Size(194, 52);
            this.Day1Btn.TabIndex = 0;
            this.Day1Btn.Text = "DAY 1";
            this.Day1Btn.UseVisualStyleBackColor = true;
            this.Day1Btn.Click += new System.EventHandler(this.Day1Btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(923, 102);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(194, 102);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(923, 420);
            this.centerPanel.TabIndex = 2;
            // 
            // TimelineProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 522);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimelineProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimelineProgress";
            this.Load += new System.EventHandler(this.TimelineProgress_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Day7Btn;
        private System.Windows.Forms.Button Day6Btn;
        private System.Windows.Forms.Button Day5Btn;
        private System.Windows.Forms.Button Day4Btn;
        private System.Windows.Forms.Button Day3Btn;
        private System.Windows.Forms.Button Day2Btn;
        private System.Windows.Forms.Button Day1Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel centerPanel;
    }
}