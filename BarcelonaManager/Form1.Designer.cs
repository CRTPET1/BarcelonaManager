namespace BarcelonaManager
{
    partial class Form1
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnNextSeason = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 18;
            this.lstPlayers.Location = new System.Drawing.Point(30, 90);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(520, 184);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            this.lstPlayers.DoubleClick += new System.EventHandler(this.lstPlayers_DoubleClick);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPlayer.Location = new System.Drawing.Point(30, 305);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(150, 40);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "➕ Dodaj igralca";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemovePlayer.Location = new System.Drawing.Point(200, 305);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(150, 40);
            this.btnRemovePlayer.TabIndex = 2;
            this.btnRemovePlayer.Text = "➖ Odstrani igralca";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.Location = new System.Drawing.Point(30, 60);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(500, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Ekipa:";
            // 
            // btnMarket
            // 
            this.btnMarket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarket.Location = new System.Drawing.Point(30, 365);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(150, 40);
            this.btnMarket.TabIndex = 3;
            this.btnMarket.Text = "🛒 Trg prestopov";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStats.Location = new System.Drawing.Point(200, 365);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(150, 40);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "📊 Statistika";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnNextSeason
            // 
            this.btnNextSeason.BackColor = System.Drawing.Color.Gold;
            this.btnNextSeason.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNextSeason.Location = new System.Drawing.Point(370, 305);
            this.btnNextSeason.Name = "btnNextSeason";
            this.btnNextSeason.Size = new System.Drawing.Size(180, 100);
            this.btnNextSeason.TabIndex = 5;
            this.btnNextSeason.Text = "⏭️ NEXT SEASON\n(Generiraj gole)";
            this.btnNextSeason.UseVisualStyleBackColor = false;
            this.btnNextSeason.Click += new System.EventHandler(this.btnNextSeason_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(311, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚽ Barcelona Manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 430);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnNextSeason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcelona Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnNextSeason;   // <-- NOVO
        private System.Windows.Forms.Label lblTitle;
    }
}