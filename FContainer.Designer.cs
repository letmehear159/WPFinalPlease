namespace WPFinalPlease
{
    partial class FContainer
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
            this.ucLogin2 = new WPFinalPlease.ucLogin();
            this.SuspendLayout();
            // 
            // ucLogin2
            // 
            this.ucLogin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ucLogin2.Location = new System.Drawing.Point(0, 0);
            this.ucLogin2.Margin = new System.Windows.Forms.Padding(2);
            this.ucLogin2.Name = "ucLogin2";
            this.ucLogin2.Size = new System.Drawing.Size(825, 472);
            this.ucLogin2.TabIndex = 0;
            // 
            // FContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.ucLogin2);
            this.Name = "FContainer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucLogin ucLogin2;
    }
}