
namespace Eclerx.ADO.Rupali
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAccountNumber = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.BtnCredit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.comboTransactionType = new System.Windows.Forms.ComboBox();
            this.LblBalanceAmount = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // TxtAccountNumber
            // 
            this.TxtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountNumber.Location = new System.Drawing.Point(281, 82);
            this.TxtAccountNumber.Name = "TxtAccountNumber";
            this.TxtAccountNumber.Size = new System.Drawing.Size(159, 30);
            this.TxtAccountNumber.TabIndex = 3;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmount.Location = new System.Drawing.Point(281, 194);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(159, 30);
            this.TxtAmount.TabIndex = 5;
            // 
            // BtnCredit
            // 
            this.BtnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCredit.Location = new System.Drawing.Point(108, 248);
            this.BtnCredit.Name = "BtnCredit";
            this.BtnCredit.Size = new System.Drawing.Size(119, 37);
            this.BtnCredit.TabIndex = 6;
            this.BtnCredit.Text = "Credit";
            this.BtnCredit.UseVisualStyleBackColor = true;
            this.BtnCredit.Click += new System.EventHandler(this.BtnCredit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(280, 248);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(134, 37);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // comboTransactionType
            // 
            this.comboTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTransactionType.FormattingEnabled = true;
            this.comboTransactionType.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.comboTransactionType.Location = new System.Drawing.Point(280, 141);
            this.comboTransactionType.Name = "comboTransactionType";
            this.comboTransactionType.Size = new System.Drawing.Size(160, 33);
            this.comboTransactionType.TabIndex = 8;
            // 
            // LblBalanceAmount
            // 
            this.LblBalanceAmount.AutoSize = true;
            this.LblBalanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBalanceAmount.Location = new System.Drawing.Point(107, 349);
            this.LblBalanceAmount.Name = "LblBalanceAmount";
            this.LblBalanceAmount.Size = new System.Drawing.Size(167, 25);
            this.LblBalanceAmount.TabIndex = 9;
            this.LblBalanceAmount.Text = "Balance Amount: ";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(281, 349);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(0, 20);
            this.LblResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblBalanceAmount);
            this.Controls.Add(this.comboTransactionType);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCredit);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtAccountNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAccountNumber;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Button BtnCredit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox comboTransactionType;
        private System.Windows.Forms.Label LblBalanceAmount;
        private System.Windows.Forms.Label LblResult;
    }
}

