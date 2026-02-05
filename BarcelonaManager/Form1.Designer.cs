using BarcelonaManager.Models;
using BarcelonaManager.Services;

    namespace BarcelonaManager
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
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 16;
            this.lstPlayers.Location = new System.Drawing.Point(50, 97);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(307, 132);
            this.lstPlayers.TabIndex = 0;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(50, 252);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(137, 39);
            this.btnAddPlayer.TabIndex = 1;
            this.btnAddPlayer.Text = "Dodaj igralca";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(220, 252);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(137, 39);
            this.btnRemovePlayer.TabIndex = 2;
            this.btnRemovePlayer.Text = "Odstrani igralca";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(47, 57);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 16);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Ekipa:";
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(50, 339);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(109, 48);
            this.btnMarket.TabIndex = 5;
            this.btnMarket.Text = "Trg prestopov";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(248, 339);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(109, 48);
            this.btnStats.TabIndex = 6;
            this.btnStats.Text = "Statistika";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 442);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.lstPlayers);
            this.MaximumSize = new System.Drawing.Size(568, 489);
            this.MinimumSize = new System.Drawing.Size(568, 489);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
    }

