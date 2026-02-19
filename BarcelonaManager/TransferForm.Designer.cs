namespace BarcelonaManager
{
    partial class TransferForm
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
            this.dgvMarket = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSelectedInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarket)).BeginInit();
            this.SuspendLayout();

            // --- lblTitle ---
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "⚽ Trg prestopov";

            // --- lblBudget ---
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblBudget.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBudget.Location = new System.Drawing.Point(20, 55);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Text = "Budget: ...";

            // --- dgvMarket: Tabela z vsemi tržnimi igralci ---
            this.dgvMarket.Location = new System.Drawing.Point(20, 85);
            this.dgvMarket.Name = "dgvMarket";
            this.dgvMarket.Size = new System.Drawing.Size(640, 300);
            this.dgvMarket.TabIndex = 0;
            this.dgvMarket.SelectionChanged += new System.EventHandler(this.dgvMarket_SelectionChanged);

            // --- lblSelectedInfo ---
            this.lblSelectedInfo.AutoSize = false;
            this.lblSelectedInfo.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSelectedInfo.Location = new System.Drawing.Point(20, 400);
            this.lblSelectedInfo.Name = "lblSelectedInfo";
            this.lblSelectedInfo.Size = new System.Drawing.Size(640, 20);
            this.lblSelectedInfo.Text = "Izberi igralca v tabeli...";

            // --- btnBuy ---
            this.btnBuy.Enabled = false;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnBuy.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuy.Location = new System.Drawing.Point(20, 435);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(300, 45);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "✅ KUPI izbranega igralca";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);

            // --- btnSell ---
            this.btnSell.Enabled = false;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnSell.BackColor = System.Drawing.Color.LightCoral;
            this.btnSell.Location = new System.Drawing.Point(360, 435);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(300, 45);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "💰 PRODAJ izbranega igralca";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);

            // --- TransferForm nastavitve ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 510);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TransferForm";
            this.Text = "Trg prestopov – Barcelona Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TransferForm_Load);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.dgvMarket);
            this.Controls.Add(this.lblSelectedInfo);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSell);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarket;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSelectedInfo;
        private System.Windows.Forms.Label lblTitle;
    }
}