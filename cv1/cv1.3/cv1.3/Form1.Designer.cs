namespace cv1._3
{
    partial class Form1
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

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl_Password21 = new cv1._3.UserControl_Password2();
            this.userControl_Password11 = new cv1._3.UserControl_Password1();
            this.userControl_Password31 = new cv1._3.UserControl_Password3();
            this.SuspendLayout();
            // 
            // userControl_Password21
            // 
            this.userControl_Password21.Location = new System.Drawing.Point(36, 120);
            this.userControl_Password21.Name = "userControl_Password21";
            this.userControl_Password21.Size = new System.Drawing.Size(139, 119);
            this.userControl_Password21.TabIndex = 1;
            // 
            // userControl_Password11
            // 
            this.userControl_Password11.Location = new System.Drawing.Point(45, 47);
            this.userControl_Password11.Name = "userControl_Password11";
            this.userControl_Password11.Size = new System.Drawing.Size(264, 67);
            this.userControl_Password11.TabIndex = 2;
            // 
            // userControl_Password31
            // 
            this.userControl_Password31.Location = new System.Drawing.Point(383, 47);
            this.userControl_Password31.Name = "userControl_Password31";
            this.userControl_Password31.Size = new System.Drawing.Size(231, 100);
            this.userControl_Password31.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl_Password31);
            this.Controls.Add(this.userControl_Password11);
            this.Controls.Add(this.userControl_Password21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl_Password2 userControl_Password21;
        private UserControl_Password1 userControl_Password11;
        private UserControl_Password3 userControl_Password31;
    }
}

