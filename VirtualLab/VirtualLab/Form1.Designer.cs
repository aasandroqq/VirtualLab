namespace VirtualLab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTests = new System.Windows.Forms.ComboBox();
            this.labelTests = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.labelTests);
            this.tabPage1.Controls.Add(this.comboBoxTests);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxMessage);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxTheme);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1362, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help Panel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тема 1",
            "Тема 2"});
            this.comboBox1.Location = new System.Drawing.Point(12, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Твій рівень :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Доступні теми :";
            // 
            // comboBoxTests
            // 
            this.comboBoxTests.FormattingEnabled = true;
            this.comboBoxTests.Location = new System.Drawing.Point(12, 211);
            this.comboBoxTests.Name = "comboBoxTests";
            this.comboBoxTests.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTests.TabIndex = 4;
            this.comboBoxTests.Visible = false;
            // 
            // labelTests
            // 
            this.labelTests.AutoSize = true;
            this.labelTests.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTests.Location = new System.Drawing.Point(8, 173);
            this.labelTests.Name = "labelTests";
            this.labelTests.Size = new System.Drawing.Size(140, 21);
            this.labelTests.TabIndex = 5;
            this.labelTests.Text = "Доступні тести :";
            this.labelTests.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(165, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 697);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(571, 680);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(612, 11);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(571, 680);
            this.listBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(657, 73);
            this.label4.TabIndex = 0;
            this.label4.Text = "Надсилання листа  :";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(32, 137);
            this.textBoxTheme.Multiline = true;
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(769, 50);
            this.textBoxTheme.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тема :";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(32, 250);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1285, 288);
            this.textBoxMessage.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Повідомлення :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Надіслати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirtualLab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTests;
        private System.Windows.Forms.ComboBox comboBoxTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button button1;
    }
}

