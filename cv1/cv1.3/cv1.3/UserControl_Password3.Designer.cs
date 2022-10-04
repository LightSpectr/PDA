namespace cv1._3
{
    partial class UserControl_Password3
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.textBox_Password2 = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.checkBox_Show_Password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Location = new System.Drawing.Point(3, 3);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.PasswordChar = '*';
            this.textBox_Password1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password1.TabIndex = 0;
            // 
            // textBox_Password2
            // 
            this.textBox_Password2.Location = new System.Drawing.Point(3, 29);
            this.textBox_Password2.Name = "textBox_Password2";
            this.textBox_Password2.PasswordChar = '*';
            this.textBox_Password2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password2.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(3, 55);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 2;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // checkBox_Show_Password
            // 
            this.checkBox_Show_Password.AutoSize = true;
            this.checkBox_Show_Password.Location = new System.Drawing.Point(109, 18);
            this.checkBox_Show_Password.Name = "checkBox_Show_Password";
            this.checkBox_Show_Password.Size = new System.Drawing.Size(102, 17);
            this.checkBox_Show_Password.TabIndex = 3;
            this.checkBox_Show_Password.Text = "Show Password";
            this.checkBox_Show_Password.UseVisualStyleBackColor = true;
            this.checkBox_Show_Password.CheckedChanged += new System.EventHandler(this.checkBox_Show_Password_CheckedChanged);
            // 
            // UserControl_Password3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_Show_Password);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password2);
            this.Controls.Add(this.textBox_Password1);
            this.Name = "UserControl_Password3";
            this.Size = new System.Drawing.Size(231, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password1;
        private System.Windows.Forms.TextBox textBox_Password2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.CheckBox checkBox_Show_Password;
    }
}
