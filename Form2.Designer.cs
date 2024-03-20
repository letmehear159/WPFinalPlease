namespace WPFinalPlease
{
    partial class Form2
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
            this.ucWorkerList1 = new WPFinalPlease.ucWorkerList();
            this.SuspendLayout();
            // 
            // ucWorkerList1
            // 
            this.ucWorkerList1.Location = new System.Drawing.Point(0, 0);
            this.ucWorkerList1.Name = "ucWorkerList1";
            this.ucWorkerList1.Size = new System.Drawing.Size(980, 800);
            this.ucWorkerList1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 761);
            this.Controls.Add(this.ucWorkerList1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ucWorkerList ucWorkerList1;
    }
}