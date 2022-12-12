namespace cv2
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
            this.textBox_create = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_create
            // 
            this.textBox_create.Location = new System.Drawing.Point(108, 6);
            this.textBox_create.Name = "textBox_create";
            this.textBox_create.Size = new System.Drawing.Size(100, 23);
            this.textBox_create.TabIndex = 0;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(214, 5);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Vytvořit";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kapacita nádrže";
            // 
            // textBox_number
            // 
            this.textBox_number.Enabled = false;
            this.textBox_number.Location = new System.Drawing.Point(12, 53);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 23);
            this.textBox_number.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Location = new System.Drawing.Point(118, 53);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Přidat";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_sub
            // 
            this.button_sub.Enabled = false;
            this.button_sub.Location = new System.Drawing.Point(199, 53);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(75, 23);
            this.button_sub.TabIndex = 6;
            this.button_sub.Text = "Odebrat";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stav:";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(47, 105);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 15);
            this.label_state.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_create;
        private Button button_create;
        private Label label1;
        private TextBox textBox_number;
        private Button button_add;
        private Button button_sub;
        private Label label2;
        private Label label_state;
    }
}