namespace cv3._1
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
            this.button_calc = new System.Windows.Forms.Button();
            this.textBox_tax = new System.Windows.Forms.TextBox();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(12, 76);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(184, 23);
            this.button_calc.TabIndex = 0;
            this.button_calc.Text = "Výpočet";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // textBox_tax
            // 
            this.textBox_tax.Location = new System.Drawing.Point(96, 6);
            this.textBox_tax.Name = "textBox_tax";
            this.textBox_tax.Size = new System.Drawing.Size(100, 23);
            this.textBox_tax.TabIndex = 1;
            // 
            // textBox_income
            // 
            this.textBox_income.Location = new System.Drawing.Point(96, 38);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.Size = new System.Drawing.Size(100, 23);
            this.textBox_income.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sazba daně";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "mzda (hrubá)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 109);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.textBox_tax);
            this.Controls.Add(this.button_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_calc;
        private TextBox textBox_tax;
        private TextBox textBox_income;
        private Label label1;
        private Label label2;
    }
}