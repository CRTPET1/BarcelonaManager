namespace BarcelonaManager
{
    partial class StatsForm
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
            this.lstStats = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.ItemHeight = 16;
            this.lstStats.Location = new System.Drawing.Point(76, 58);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(282, 148);
            this.lstStats.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(76, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(282, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zapri";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 301);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstStats);
            this.MaximumSize = new System.Drawing.Size(468, 348);
            this.MinimumSize = new System.Drawing.Size(468, 348);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.Button btnClose;
    }
}