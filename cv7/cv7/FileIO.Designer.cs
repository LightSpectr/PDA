namespace cv5
{
    public partial class FileIO
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
            this.button_FileTarget = new System.Windows.Forms.Button();
            this.button_FileSource = new System.Windows.Forms.Button();
            this.textBox_FileTarget = new System.Windows.Forms.TextBox();
            this.textBox_FileSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_FileTarget
            // 
            this.button_FileTarget.Location = new System.Drawing.Point(225, 90);
            this.button_FileTarget.Name = "button_FileTarget";
            this.button_FileTarget.Size = new System.Drawing.Size(109, 23);
            this.button_FileTarget.TabIndex = 11;
            this.button_FileTarget.Text = "vybrat soubor";
            this.button_FileTarget.UseVisualStyleBackColor = true;
            this.button_FileTarget.Click += new System.EventHandler(this.button_FileTarget_Click);
            // 
            // button_FileSource
            // 
            this.button_FileSource.Location = new System.Drawing.Point(225, 27);
            this.button_FileSource.Name = "button_FileSource";
            this.button_FileSource.Size = new System.Drawing.Size(109, 23);
            this.button_FileSource.TabIndex = 10;
            this.button_FileSource.Text = "vybrat soubor";
            this.button_FileSource.UseVisualStyleBackColor = true;
            this.button_FileSource.Click += new System.EventHandler(this.button_FileSource_Click);
            // 
            // textBox_FileTarget
            // 
            this.textBox_FileTarget.Location = new System.Drawing.Point(3, 90);
            this.textBox_FileTarget.Name = "textBox_FileTarget";
            this.textBox_FileTarget.ReadOnly = true;
            this.textBox_FileTarget.Size = new System.Drawing.Size(216, 23);
            this.textBox_FileTarget.TabIndex = 9;
            // 
            // textBox_FileSource
            // 
            this.textBox_FileSource.Location = new System.Drawing.Point(3, 27);
            this.textBox_FileSource.Name = "textBox_FileSource";
            this.textBox_FileSource.ReadOnly = true;
            this.textBox_FileSource.Size = new System.Drawing.Size(216, 23);
            this.textBox_FileSource.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cilovy soubor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zdrojovy soubor";
            // 
            // FileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_FileTarget);
            this.Controls.Add(this.button_FileSource);
            this.Controls.Add(this.textBox_FileTarget);
            this.Controls.Add(this.textBox_FileSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileIO";
            this.Size = new System.Drawing.Size(337, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Button button_FileTarget;
        protected Button button_FileSource;
        protected TextBox textBox_FileTarget;
        protected TextBox textBox_FileSource;
        protected Label label2;
        protected Label label1;
    }
}
