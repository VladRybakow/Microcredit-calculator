namespace Microcredit_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Amount = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.Percent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.TotalPayout = new System.Windows.Forms.TextBox();
            this.InterestAmount = new System.Windows.Forms.TextBox();
            this.EffectiveRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(26, 176);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 20);
            this.Amount.TabIndex = 0;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(26, 231);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(100, 20);
            this.Days.TabIndex = 1;
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(26, 34);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(936, 20);
            this.Percent.TabIndex = 2;
            this.Percent.TextChanged += new System.EventHandler(this.Percent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interest";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(26, 288);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 44);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // TotalPayout
            // 
            this.TotalPayout.Location = new System.Drawing.Point(183, 176);
            this.TotalPayout.Name = "TotalPayout";
            this.TotalPayout.Size = new System.Drawing.Size(100, 20);
            this.TotalPayout.TabIndex = 7;
            this.TotalPayout.TextChanged += new System.EventHandler(this.TotalPayout_TextChanged);
            // 
            // InterestAmount
            // 
            this.InterestAmount.Location = new System.Drawing.Point(183, 231);
            this.InterestAmount.Name = "InterestAmount";
            this.InterestAmount.Size = new System.Drawing.Size(100, 20);
            this.InterestAmount.TabIndex = 8;
            this.InterestAmount.TextChanged += new System.EventHandler(this.InterestAmount_TextChanged);
            // 
            // EffectiveRate
            // 
            this.EffectiveRate.Location = new System.Drawing.Point(183, 288);
            this.EffectiveRate.Name = "EffectiveRate";
            this.EffectiveRate.Size = new System.Drawing.Size(100, 20);
            this.EffectiveRate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total payout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Interest amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Effective rate";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(26, 372);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 49);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(183, 372);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(100, 49);
            this.Loading.TabIndex = 14;
            this.Loading.Text = "Loading";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 505);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EffectiveRate);
            this.Controls.Add(this.InterestAmount);
            this.Controls.Add(this.TotalPayout);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox TotalPayout;
        private System.Windows.Forms.TextBox InterestAmount;
        private System.Windows.Forms.TextBox EffectiveRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

