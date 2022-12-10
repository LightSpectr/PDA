namespace FileExplorer
{
    partial class mainForm
    {
        
        private System.ComponentModel.IContainer components = null;

         
         
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.enterButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.viewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(12, 63);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(634, 161);
            this.directoryTreeView.TabIndex = 0;
            this.directoryTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.directoryTreeView_NodeMouseClick);
            this.directoryTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.directoryTreeView_NodeMouseDoubleClick);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(380, 37);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 37);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(362, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "C:\\Users\\Ceceilia\\Documents";
            // 
            // viewRichTextBox
            // 
            this.viewRichTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewRichTextBox.Location = new System.Drawing.Point(12, 251);
            this.viewRichTextBox.Name = "viewRichTextBox";
            this.viewRichTextBox.ReadOnly = true;
            this.viewRichTextBox.Size = new System.Drawing.Size(634, 217);
            this.viewRichTextBox.TabIndex = 3;
            this.viewRichTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 499);
            this.Controls.Add(this.viewRichTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.directoryTreeView);
            this.Name = "mainForm";
            this.Text = "Sample Text Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RichTextBox viewRichTextBox;
    }
}

