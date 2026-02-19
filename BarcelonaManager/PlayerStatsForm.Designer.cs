namespace BarcelonaManager
{
    partial class PlayerStatsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPlayerStats = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lstPlayerStats
            this.lstPlayerStats.Font = new System.Drawing.Font("Courier New", 10F);
            this.lstPlayerStats.FormattingEnabled = true;
            this.lstPlayerStats.ItemHeight = 18;
            this.lstPlayerStats.Location = new System.Drawing.Point(20, 20);
            this.lstPlayerStats.Name = "lstPlayerStats";
            this.lstPlayerStats.Size = new System.Drawing.Size(420, 260);
            this.lstPlayerStats.TabIndex = 0;

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(20, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(420, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zapri";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // PlayerStatsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 345);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstPlayerStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PlayerStatsForm";
            this.Text = "Kariera igralca";
            this.Load += new System.EventHandler(this.PlayerStatsForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayerStats;
        private System.Windows.Forms.Button btnClose;
    }
}