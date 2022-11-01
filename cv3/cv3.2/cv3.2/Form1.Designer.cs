namespace cv3._2
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
            this.listBox_Colors = new System.Windows.Forms.ListBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_AddName = new System.Windows.Forms.TextBox();
            this.textBox_AddBlue = new System.Windows.Forms.TextBox();
            this.textBox_AddGreen = new System.Windows.Forms.TextBox();
            this.textBox_AddRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.textBox_ShowName = new System.Windows.Forms.TextBox();
            this.textBox_ShowHex = new System.Windows.Forms.TextBox();
            this.textBox_ShowInt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_Des = new System.Windows.Forms.RadioButton();
            this.radioButton_Asc = new System.Windows.Forms.RadioButton();
            this.button_Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Colors
            // 
            this.listBox_Colors.FormattingEnabled = true;
            this.listBox_Colors.ItemHeight = 15;
            this.listBox_Colors.Location = new System.Drawing.Point(12, 12);
            this.listBox_Colors.Name = "listBox_Colors";
            this.listBox_Colors.Size = new System.Drawing.Size(120, 184);
            this.listBox_Colors.TabIndex = 0;
            this.listBox_Colors.SelectedIndexChanged += new System.EventHandler(this.listBox_Colors_SelectedIndexChanged);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(138, 72);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(63, 137);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 23);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Up
            // 
            this.button_Up.Location = new System.Drawing.Point(138, 12);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Up.TabIndex = 1;
            this.button_Up.Text = "▲";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Up_Click);
            // 
            // button_Down
            // 
            this.button_Down.Location = new System.Drawing.Point(138, 41);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Down.TabIndex = 2;
            this.button_Down.Text = "▼";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.Control;
            this.colorBox.Location = new System.Drawing.Point(6, 22);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(241, 69);
            this.colorBox.TabIndex = 5;
            this.colorBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorBox);
            this.groupBox1.Location = new System.Drawing.Point(253, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // textBox_AddName
            // 
            this.textBox_AddName.Location = new System.Drawing.Point(63, 21);
            this.textBox_AddName.Name = "textBox_AddName";
            this.textBox_AddName.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddName.TabIndex = 10;
            // 
            // textBox_AddBlue
            // 
            this.textBox_AddBlue.Location = new System.Drawing.Point(63, 108);
            this.textBox_AddBlue.Name = "textBox_AddBlue";
            this.textBox_AddBlue.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddBlue.TabIndex = 13;
            // 
            // textBox_AddGreen
            // 
            this.textBox_AddGreen.Location = new System.Drawing.Point(63, 79);
            this.textBox_AddGreen.Name = "textBox_AddGreen";
            this.textBox_AddGreen.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddGreen.TabIndex = 12;
            // 
            // textBox_AddRed
            // 
            this.textBox_AddRed.Location = new System.Drawing.Point(63, 50);
            this.textBox_AddRed.Name = "textBox_AddRed";
            this.textBox_AddRed.Size = new System.Drawing.Size(100, 23);
            this.textBox_AddRed.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Blue";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.textBox_AddRed);
            this.groupBox_Add.Controls.Add(this.label4);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Controls.Add(this.label3);
            this.groupBox_Add.Controls.Add(this.textBox_AddName);
            this.groupBox_Add.Controls.Add(this.label2);
            this.groupBox_Add.Controls.Add(this.textBox_AddBlue);
            this.groupBox_Add.Controls.Add(this.label1);
            this.groupBox_Add.Controls.Add(this.textBox_AddGreen);
            this.groupBox_Add.Location = new System.Drawing.Point(512, 12);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(184, 171);
            this.groupBox_Add.TabIndex = 9;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "Add color";
            // 
            // textBox_ShowName
            // 
            this.textBox_ShowName.Location = new System.Drawing.Point(311, 12);
            this.textBox_ShowName.Name = "textBox_ShowName";
            this.textBox_ShowName.ReadOnly = true;
            this.textBox_ShowName.Size = new System.Drawing.Size(100, 23);
            this.textBox_ShowName.TabIndex = 5;
            // 
            // textBox_ShowHex
            // 
            this.textBox_ShowHex.Location = new System.Drawing.Point(311, 41);
            this.textBox_ShowHex.Name = "textBox_ShowHex";
            this.textBox_ShowHex.ReadOnly = true;
            this.textBox_ShowHex.Size = new System.Drawing.Size(100, 23);
            this.textBox_ShowHex.TabIndex = 6;
            // 
            // textBox_ShowInt
            // 
            this.textBox_ShowInt.Location = new System.Drawing.Point(311, 72);
            this.textBox_ShowInt.Name = "textBox_ShowInt";
            this.textBox_ShowInt.ReadOnly = true;
            this.textBox_ShowInt.Size = new System.Drawing.Size(100, 23);
            this.textBox_ShowInt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Intensity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_Des);
            this.groupBox3.Controls.Add(this.radioButton_Asc);
            this.groupBox3.Controls.Add(this.button_Sort);
            this.groupBox3.Location = new System.Drawing.Point(138, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort colors";
            // 
            // radioButton_Des
            // 
            this.radioButton_Des.AutoSize = true;
            this.radioButton_Des.Location = new System.Drawing.Point(6, 40);
            this.radioButton_Des.Name = "radioButton_Des";
            this.radioButton_Des.Size = new System.Drawing.Size(87, 19);
            this.radioButton_Des.TabIndex = 1;
            this.radioButton_Des.Text = "Descending";
            this.radioButton_Des.UseVisualStyleBackColor = true;
            // 
            // radioButton_Asc
            // 
            this.radioButton_Asc.AutoSize = true;
            this.radioButton_Asc.Checked = true;
            this.radioButton_Asc.Location = new System.Drawing.Point(6, 15);
            this.radioButton_Asc.Name = "radioButton_Asc";
            this.radioButton_Asc.Size = new System.Drawing.Size(81, 19);
            this.radioButton_Asc.TabIndex = 0;
            this.radioButton_Asc.TabStop = true;
            this.radioButton_Asc.Text = "Ascending";
            this.radioButton_Asc.UseVisualStyleBackColor = true;
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(6, 65);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(75, 23);
            this.button_Sort.TabIndex = 2;
            this.button_Sort.Text = "Sort";
            this.button_Sort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ShowInt);
            this.Controls.Add(this.textBox_ShowHex);
            this.Controls.Add(this.textBox_ShowName);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.listBox_Colors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox_Colors;
        private Button button_Remove;
        private Button button_Add;
        private Button button_Up;
        private Button button_Down;
        private PictureBox colorBox;
        private GroupBox groupBox1;
        private TextBox textBox_AddName;
        private TextBox textBox_AddBlue;
        private TextBox textBox_AddGreen;
        private TextBox textBox_AddRed;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox_Add;
        private TextBox textBox_ShowName;
        private TextBox textBox_ShowHex;
        private TextBox textBox_ShowInt;
        private Label label5;
        private Label label6;
        private Label label9;
        private GroupBox groupBox3;
        private RadioButton radioButton_Des;
        private RadioButton radioButton_Asc;
        private Button button_Sort;
    }
}