
namespace DirectoryRead
{
    partial class MainForm
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
            this.btnDirectoryRead = new System.Windows.Forms.Button();
            this.btnFileSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDirectoryRead
            // 
            this.btnDirectoryRead.Location = new System.Drawing.Point(47, 30);
            this.btnDirectoryRead.Name = "btnDirectoryRead";
            this.btnDirectoryRead.Size = new System.Drawing.Size(173, 68);
            this.btnDirectoryRead.TabIndex = 0;
            this.btnDirectoryRead.Text = "Read Directory Images";
            this.btnDirectoryRead.UseVisualStyleBackColor = true;
            this.btnDirectoryRead.Click += new System.EventHandler(this.btnDirectoryRead_Click);
            // 
            // btnFileSplit
            // 
            this.btnFileSplit.Location = new System.Drawing.Point(253, 30);
            this.btnFileSplit.Name = "btnFileSplit";
            this.btnFileSplit.Size = new System.Drawing.Size(173, 68);
            this.btnFileSplit.TabIndex = 1;
            this.btnFileSplit.Text = "File Split";
            this.btnFileSplit.UseVisualStyleBackColor = true;
            this.btnFileSplit.Click += new System.EventHandler(this.btnFileSplit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFileSplit);
            this.Controls.Add(this.btnDirectoryRead);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDirectoryRead;
        private System.Windows.Forms.Button btnFileSplit;
    }
}