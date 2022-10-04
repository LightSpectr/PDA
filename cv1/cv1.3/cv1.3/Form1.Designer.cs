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
            this.userControl_GeneratorCitace1 = new cv1._3.UserControl_GeneratorCitace();
            this.SuspendLayout();
            // 
            // userControl_GeneratorCitace1
            // 
            this.userControl_GeneratorCitace1.Location = new System.Drawing.Point(1, 12);
            this.userControl_GeneratorCitace1.Name = "userControl_GeneratorCitace1";
            this.userControl_GeneratorCitace1.Size = new System.Drawing.Size(787, 257);
            this.userControl_GeneratorCitace1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl_GeneratorCitace1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_GeneratorCitace userControl_GeneratorCitace1;
    }
}

