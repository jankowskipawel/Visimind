
namespace face_recognition
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
            this.randomImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // randomImageButton
            // 
            this.randomImageButton.Location = new System.Drawing.Point(13, 13);
            this.randomImageButton.Name = "randomImageButton";
            this.randomImageButton.Size = new System.Drawing.Size(97, 23);
            this.randomImageButton.TabIndex = 0;
            this.randomImageButton.Text = "Random Image";
            this.randomImageButton.UseVisualStyleBackColor = true;
            this.randomImageButton.Click += new System.EventHandler(this.randomImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 461);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // customImageButton
            // 
            this.customImageButton.Location = new System.Drawing.Point(117, 13);
            this.customImageButton.Name = "customImageButton";
            this.customImageButton.Size = new System.Drawing.Size(101, 23);
            this.customImageButton.TabIndex = 2;
            this.customImageButton.Text = "Custom Image...";
            this.customImageButton.UseVisualStyleBackColor = true;
            this.customImageButton.Click += new System.EventHandler(this.customImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 515);
            this.Controls.Add(this.customImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.randomImageButton);
            this.Name = "Form1";
            this.Text = "Face Recognition";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

