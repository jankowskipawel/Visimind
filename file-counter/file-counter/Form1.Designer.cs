
namespace file_counter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkDirectoryButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.pickDirectoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.pickLogDirectoryButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.directoryFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkDirectoryButton
            // 
            this.checkDirectoryButton.Location = new System.Drawing.Point(15, 100);
            this.checkDirectoryButton.Name = "checkDirectoryButton";
            this.checkDirectoryButton.Size = new System.Drawing.Size(102, 23);
            this.checkDirectoryButton.TabIndex = 0;
            this.checkDirectoryButton.Text = "Check directory";
            this.checkDirectoryButton.UseVisualStyleBackColor = true;
            this.checkDirectoryButton.Click += new System.EventHandler(this.checkDirectoryButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(12, 30);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(453, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // pickDirectoryButton
            // 
            this.pickDirectoryButton.Location = new System.Drawing.Point(471, 30);
            this.pickDirectoryButton.Name = "pickDirectoryButton";
            this.pickDirectoryButton.Size = new System.Drawing.Size(27, 23);
            this.pickDirectoryButton.TabIndex = 2;
            this.pickDirectoryButton.Text = "...";
            this.pickDirectoryButton.UseVisualStyleBackColor = true;
            this.pickDirectoryButton.Click += new System.EventHandler(this.pickDirectoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log file path:";
            // 
            // logDirectoryTextBox
            // 
            this.logDirectoryTextBox.Location = new System.Drawing.Point(12, 74);
            this.logDirectoryTextBox.Name = "logDirectoryTextBox";
            this.logDirectoryTextBox.Size = new System.Drawing.Size(377, 20);
            this.logDirectoryTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parameter:";
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Location = new System.Drawing.Point(426, 74);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(70, 20);
            this.parameterTextBox.TabIndex = 7;
            this.parameterTextBox.Text = "5";
            // 
            // pickLogDirectoryButton
            // 
            this.pickLogDirectoryButton.Location = new System.Drawing.Point(395, 72);
            this.pickLogDirectoryButton.Name = "pickLogDirectoryButton";
            this.pickLogDirectoryButton.Size = new System.Drawing.Size(25, 23);
            this.pickLogDirectoryButton.TabIndex = 8;
            this.pickLogDirectoryButton.Text = "...";
            this.pickLogDirectoryButton.UseVisualStyleBackColor = true;
            this.pickLogDirectoryButton.Click += new System.EventHandler(this.pickLogDirectoryButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(15, 129);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(481, 424);
            this.logTextBox.TabIndex = 9;
            this.logTextBox.Text = "";
            // 
            // saveLogButton
            // 
            this.saveLogButton.Location = new System.Drawing.Point(123, 100);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(102, 23);
            this.saveLogButton.TabIndex = 10;
            this.saveLogButton.Text = "Save Log To File";
            this.saveLogButton.UseVisualStyleBackColor = true;
            this.saveLogButton.Click += new System.EventHandler(this.saveLogButton_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.ForeColor = System.Drawing.Color.Red;
            this.clearLogButton.Location = new System.Drawing.Point(421, 101);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 11;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 565);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.pickLogDirectoryButton);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logDirectoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickDirectoryButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.checkDirectoryButton);
            this.Name = "Form1";
            this.Text = "File counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkDirectoryButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button pickDirectoryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logDirectoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button pickLogDirectoryButton;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.FolderBrowserDialog directoryFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog logFolderBrowserDialog;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.Button clearLogButton;
    }
}

