﻿namespace cv7
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
            this.fileiO21 = new cv7.FileIO2();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileiO21
            // 
            this.fileiO21.Location = new System.Drawing.Point(27, 48);
            this.fileiO21.Name = "fileiO21";
            this.fileiO21.Size = new System.Drawing.Size(337, 164);
            this.fileiO21.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 103);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileiO21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FileIO2 fileiO21;
        private Button button1;
    }
}