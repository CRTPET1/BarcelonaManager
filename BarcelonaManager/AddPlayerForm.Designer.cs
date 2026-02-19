namespace BarcelonaManager
{
    partial class AddPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();

            // --- label1: Ime ---
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Text = "Ime in priimek:";

            // --- txtName ---
            this.txtName.Location = new System.Drawing.Point(160, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 0;

            // --- label2: Pozicija ---
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Text = "Pozicija:";

            // --- cmbPosition: DROPDOWN za pozicijo (namesto txtPos) ---
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(160, 77);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(170, 24);
            this.cmbPosition.TabIndex = 1;

            // --- label3: Starost ---
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 128);
            this.label3.Name = "label3";
            this.label3.Text = "Starost:";

            // --- numAge ---
            this.numAge.Location = new System.Drawing.Point(160, 125);
            this.numAge.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numAge.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            this.numAge.Value = new decimal(new int[] { 22, 0, 0, 0 });
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(170, 22);
            this.numAge.TabIndex = 2;

            // --- label4: Vrednost ---
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 175);
            this.label4.Name = "label4";
            this.label4.Text = "Vrednost (M €):";

            // --- numValue ---
            this.numValue.Location = new System.Drawing.Point(160, 172);
            this.numValue.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numValue.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(170, 22);
            this.numValue.TabIndex = 3;

            // --- btnOK ---
            this.btnOK.Location = new System.Drawing.Point(90, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(180, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "✅ Dodaj igralca";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // --- AddPlayerForm nastavitve ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPlayerForm";
            this.Text = "Dodaj novega igralca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddPlayerForm_Load);

            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);

            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbPosition;   // <-- NOVO: dropdown
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Button btnOK;
    }
}