
using cv5;
namespace cv7
{
    partial class FileIO2 : FileIO
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
            this.checkBox_copy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_copy
            // 
            this.checkBox_copy.AutoSize = true;
            this.checkBox_copy.Location = new System.Drawing.Point(3, 132);
            this.checkBox_copy.Name = "checkBox_copy";
            this.checkBox_copy.Size = new System.Drawing.Size(84, 19);
            this.checkBox_copy.TabIndex = 12;
            this.checkBox_copy.Text = "make copy";
            this.checkBox_copy.UseVisualStyleBackColor = true;
            this.checkBox_copy.CheckedChanged += new System.EventHandler(this.checkBox_copy_CheckedChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_copy);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(337, 164);
            this.Controls.SetChildIndex(this.checkBox_copy, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox_copy;
    }
}
