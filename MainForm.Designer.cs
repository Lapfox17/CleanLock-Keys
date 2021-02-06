
namespace CleanLock_Keys
{
    partial class MainForm
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
            this.keyLockerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyLockerButton
            // 
            this.keyLockerButton.Location = new System.Drawing.Point(12, 7);
            this.keyLockerButton.Name = "keyLockerButton";
            this.keyLockerButton.Size = new System.Drawing.Size(237, 36);
            this.keyLockerButton.TabIndex = 0;
            this.keyLockerButton.Text = "Lock";
            this.keyLockerButton.UseVisualStyleBackColor = true;
            this.keyLockerButton.Click += new System.EventHandler(this.keyLockerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(261, 50);
            this.Controls.Add(this.keyLockerButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 89);
            this.MinimumSize = new System.Drawing.Size(277, 89);
            this.Name = "MainForm";
            this.Text = "CleanLock Keys";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button keyLockerButton;
    }
}

