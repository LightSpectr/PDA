namespace cv3._4
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
            this.radioButton_A = new System.Windows.Forms.RadioButton();
            this.radioButton_B = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.groupBox_a = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox_a.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_A
            // 
            this.radioButton_A.AutoSize = true;
            this.radioButton_A.Location = new System.Drawing.Point(6, 22);
            this.radioButton_A.Name = "radioButton_A";
            this.radioButton_A.Size = new System.Drawing.Size(48, 19);
            this.radioButton_A.TabIndex = 0;
            this.radioButton_A.Text = "PDA";
            this.radioButton_A.UseVisualStyleBackColor = true;
            this.radioButton_A.CheckedChanged += new System.EventHandler(this.radioButton_A_CheckedChanged);
            // 
            // radioButton_B
            // 
            this.radioButton_B.AutoSize = true;
            this.radioButton_B.Location = new System.Drawing.Point(6, 47);
            this.radioButton_B.Name = "radioButton_B";
            this.radioButton_B.Size = new System.Drawing.Size(47, 19);
            this.radioButton_B.TabIndex = 1;
            this.radioButton_B.Text = "ZSO";
            this.radioButton_B.UseVisualStyleBackColor = true;
            this.radioButton_B.CheckedChanged += new System.EventHandler(this.radioButton_B_CheckedChanged);
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(6, 72);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(47, 19);
            this.radioButton_C.TabIndex = 2;
            this.radioButton_C.Text = "DSA";
            this.radioButton_C.UseVisualStyleBackColor = true;
            this.radioButton_C.CheckedChanged += new System.EventHandler(this.radioButton_C_CheckedChanged);
            // 
            // groupBox_a
            // 
            this.groupBox_a.Controls.Add(this.radioButton_A);
            this.groupBox_a.Controls.Add(this.radioButton_C);
            this.groupBox_a.Controls.Add(this.radioButton_B);
            this.groupBox_a.Location = new System.Drawing.Point(23, 29);
            this.groupBox_a.Name = "groupBox_a";
            this.groupBox_a.Size = new System.Drawing.Size(107, 100);
            this.groupBox_a.TabIndex = 3;
            this.groupBox_a.TabStop = false;
            this.groupBox_a.Text = "choose one";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PDA",
            "ZSO",
            "DSA"});
            this.comboBox1.Location = new System.Drawing.Point(309, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 140);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_a.ResumeLayout(false);
            this.groupBox_a.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButton_A;
        private RadioButton radioButton_B;
        private RadioButton radioButton_C;
        private GroupBox groupBox_a;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
    }
}