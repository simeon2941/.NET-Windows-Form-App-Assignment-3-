
namespace ErindSimeon_Assignment3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputText = new System.Windows.Forms.RichTextBox();
            this.Query = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.serverComboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.serverComboBox2 = new System.Windows.Forms.ComboBox();
            this.showResult2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serverComboBox3 = new System.Windows.Forms.ComboBox();
            this.roleComboBox3 = new System.Windows.Forms.ComboBox();
            this.showResult3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.classComboBox4 = new System.Windows.Forms.ComboBox();
            this.showResult4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tank = new System.Windows.Forms.RadioButton();
            this.Damage = new System.Windows.Forms.RadioButton();
            this.Healer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputText.Location = new System.Drawing.Point(453, 42);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(761, 593);
            this.OutputText.TabIndex = 0;
            this.OutputText.TabStop = false;
            this.OutputText.Text = "";
            // 
            // Query
            // 
            this.Query.AutoSize = true;
            this.Query.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Query.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Query.Location = new System.Drawing.Point(453, 10);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(67, 25);
            this.Query.TabIndex = 1;
            this.Query.Text = "Query";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Class Type from a Single Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Percentage of Each Race From a Single Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Role from a Single Server Within a Level Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "All Guilds of a Single Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "All Players Who Could Fill a Role but Presently Aren\'t";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(12, 64);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 23);
            this.classComboBox.TabIndex = 8;
            this.classComboBox.TabStop = false;
            // 
            // serverComboBox1
            // 
            this.serverComboBox1.FormattingEnabled = true;
            this.serverComboBox1.Location = new System.Drawing.Point(160, 64);
            this.serverComboBox1.Name = "serverComboBox1";
            this.serverComboBox1.Size = new System.Drawing.Size(121, 23);
            this.serverComboBox1.TabIndex = 9;
            this.serverComboBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(160, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowResult1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(160, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Server";
            // 
            // serverComboBox2
            // 
            this.serverComboBox2.FormattingEnabled = true;
            this.serverComboBox2.Location = new System.Drawing.Point(160, 156);
            this.serverComboBox2.Name = "serverComboBox2";
            this.serverComboBox2.Size = new System.Drawing.Size(121, 23);
            this.serverComboBox2.TabIndex = 14;
            this.serverComboBox2.TabStop = false;
            // 
            // showResult2
            // 
            this.showResult2.Location = new System.Drawing.Point(327, 155);
            this.showResult2.Name = "showResult2";
            this.showResult2.Size = new System.Drawing.Size(102, 23);
            this.showResult2.TabIndex = 15;
            this.showResult2.TabStop = false;
            this.showResult2.Text = "Show Results";
            this.showResult2.UseVisualStyleBackColor = true;
            this.showResult2.Click += new System.EventHandler(this.ShowResult2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(12, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Role";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(160, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Server";
            // 
            // serverComboBox3
            // 
            this.serverComboBox3.FormattingEnabled = true;
            this.serverComboBox3.Location = new System.Drawing.Point(160, 250);
            this.serverComboBox3.Name = "serverComboBox3";
            this.serverComboBox3.Size = new System.Drawing.Size(121, 23);
            this.serverComboBox3.TabIndex = 19;
            this.serverComboBox3.TabStop = false;
            // 
            // roleComboBox3
            // 
            this.roleComboBox3.FormattingEnabled = true;
            this.roleComboBox3.Location = new System.Drawing.Point(12, 250);
            this.roleComboBox3.Name = "roleComboBox3";
            this.roleComboBox3.Size = new System.Drawing.Size(121, 23);
            this.roleComboBox3.TabIndex = 18;
            this.roleComboBox3.TabStop = false;
            // 
            // showResult3
            // 
            this.showResult3.Location = new System.Drawing.Point(327, 250);
            this.showResult3.Name = "showResult3";
            this.showResult3.Size = new System.Drawing.Size(102, 23);
            this.showResult3.TabIndex = 20;
            this.showResult3.TabStop = false;
            this.showResult3.Text = "Show Results";
            this.showResult3.UseVisualStyleBackColor = true;
            this.showResult3.Click += new System.EventHandler(this.ShowResult3);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(12, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(97, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Max";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(12, 300);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownMin.TabIndex = 23;
            this.numericUpDownMin.TabStop = false;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Click += new System.EventHandler(this.NumericMinClicked);
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(97, 300);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(36, 23);
            this.numericUpDownMax.TabIndex = 24;
            this.numericUpDownMax.TabStop = false;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Click += new System.EventHandler(this.NumericMaxClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Class";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(12, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Type";
            // 
            // classComboBox4
            // 
            this.classComboBox4.FormattingEnabled = true;
            this.classComboBox4.Location = new System.Drawing.Point(12, 404);
            this.classComboBox4.Name = "classComboBox4";
            this.classComboBox4.Size = new System.Drawing.Size(121, 23);
            this.classComboBox4.TabIndex = 26;
            this.classComboBox4.TabStop = false;
            // 
            // showResult4
            // 
            this.showResult4.Location = new System.Drawing.Point(327, 381);
            this.showResult4.Name = "showResult4";
            this.showResult4.Size = new System.Drawing.Size(102, 23);
            this.showResult4.TabIndex = 27;
            this.showResult4.TabStop = false;
            this.showResult4.Text = "Show Results";
            this.showResult4.UseVisualStyleBackColor = true;
            this.showResult4.Click += new System.EventHandler(this.ShowResult4);
            // 
            // Tank
            // 
            this.Tank.AutoSize = true;
            this.Tank.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Tank.Location = new System.Drawing.Point(3, 16);
            this.Tank.Name = "Tank";
            this.Tank.Size = new System.Drawing.Size(49, 19);
            this.Tank.TabIndex = 28;
            this.Tank.Text = "Tank";
            this.Tank.UseVisualStyleBackColor = true;
            // 
            // Damage
            // 
            this.Damage.AutoSize = true;
            this.Damage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Damage.Location = new System.Drawing.Point(134, 16);
            this.Damage.Name = "Damage";
            this.Damage.Size = new System.Drawing.Size(69, 19);
            this.Damage.TabIndex = 30;
            this.Damage.Text = "Damage";
            this.Damage.UseVisualStyleBackColor = true;
            // 
            // Healer
            // 
            this.Healer.AutoSize = true;
            this.Healer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Healer.Location = new System.Drawing.Point(58, 16);
            this.Healer.Name = "Healer";
            this.Healer.Size = new System.Drawing.Size(59, 19);
            this.Healer.TabIndex = 29;
            this.Healer.Text = "Healer";
            this.Healer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Healer);
            this.groupBox1.Controls.Add(this.Damage);
            this.groupBox1.Controls.Add(this.Tank);
            this.groupBox1.Location = new System.Drawing.Point(12, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 51);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 32;
            this.button2.TabStop = false;
            this.button2.Text = "Show Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowResult5);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 33;
            this.button3.TabStop = false;
            this.button3.Text = "Show Results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowResult6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1234, 654);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showResult4);
            this.Controls.Add(this.classComboBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.showResult3);
            this.Controls.Add(this.serverComboBox3);
            this.Controls.Add(this.roleComboBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showResult2);
            this.Controls.Add(this.serverComboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverComboBox1);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.OutputText);
            this.Name = "Form1";
            this.Text = "All Guilds of a Single Type";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputText;
        private System.Windows.Forms.Label Query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox serverComboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox serverComboBox2;
        private System.Windows.Forms.Button showResult2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox serverComboBox3;
        private System.Windows.Forms.ComboBox classComboBox3;
        private System.Windows.Forms.Button showResult4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Button showResult3;
        private System.Windows.Forms.ComboBox roleComboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox classComboBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton Tank;
        private System.Windows.Forms.RadioButton Damage;
        private System.Windows.Forms.RadioButton Healer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

