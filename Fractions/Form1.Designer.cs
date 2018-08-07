namespace Fractions
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
            this.tbNumerator1 = new System.Windows.Forms.TextBox();
            this.tbDenominator1 = new System.Windows.Forms.TextBox();
            this.tbNumerator2 = new System.Windows.Forms.TextBox();
            this.tbDenominator2 = new System.Windows.Forms.TextBox();
            this.tbDenominatorResult = new System.Windows.Forms.TextBox();
            this.tbNumeratorResult = new System.Windows.Forms.TextBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumerator1
            // 
            this.tbNumerator1.Location = new System.Drawing.Point(224, 71);
            this.tbNumerator1.Name = "tbNumerator1";
            this.tbNumerator1.Size = new System.Drawing.Size(30, 20);
            this.tbNumerator1.TabIndex = 0;
            // 
            // tbDenominator1
            // 
            this.tbDenominator1.Location = new System.Drawing.Point(224, 91);
            this.tbDenominator1.Name = "tbDenominator1";
            this.tbDenominator1.Size = new System.Drawing.Size(30, 20);
            this.tbDenominator1.TabIndex = 1;
            // 
            // tbNumerator2
            // 
            this.tbNumerator2.Location = new System.Drawing.Point(305, 71);
            this.tbNumerator2.Name = "tbNumerator2";
            this.tbNumerator2.Size = new System.Drawing.Size(30, 20);
            this.tbNumerator2.TabIndex = 2;
            // 
            // tbDenominator2
            // 
            this.tbDenominator2.Location = new System.Drawing.Point(305, 91);
            this.tbDenominator2.Name = "tbDenominator2";
            this.tbDenominator2.Size = new System.Drawing.Size(30, 20);
            this.tbDenominator2.TabIndex = 3;
            // 
            // tbDenominatorResult
            // 
            this.tbDenominatorResult.Location = new System.Drawing.Point(423, 91);
            this.tbDenominatorResult.Name = "tbDenominatorResult";
            this.tbDenominatorResult.ReadOnly = true;
            this.tbDenominatorResult.Size = new System.Drawing.Size(30, 20);
            this.tbDenominatorResult.TabIndex = 4;
            // 
            // tbNumeratorResult
            // 
            this.tbNumeratorResult.Location = new System.Drawing.Point(423, 71);
            this.tbNumeratorResult.Name = "tbNumeratorResult";
            this.tbNumeratorResult.ReadOnly = true;
            this.tbNumeratorResult.Size = new System.Drawing.Size(30, 20);
            this.tbNumeratorResult.TabIndex = 5;
            // 
            // cbJob
            // 
            this.cbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Items.AddRange(new object[] {
            "*",
            "/"});
            this.cbJob.Location = new System.Drawing.Point(260, 71);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(39, 24);
            this.cbJob.TabIndex = 7;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(342, 72);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Результат";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.tbNumeratorResult);
            this.Controls.Add(this.tbDenominatorResult);
            this.Controls.Add(this.tbDenominator2);
            this.Controls.Add(this.tbNumerator2);
            this.Controls.Add(this.tbDenominator1);
            this.Controls.Add(this.tbNumerator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumerator1;
        private System.Windows.Forms.TextBox tbDenominator1;
        private System.Windows.Forms.TextBox tbNumerator2;
        private System.Windows.Forms.TextBox tbDenominator2;
        private System.Windows.Forms.TextBox tbDenominatorResult;
        private System.Windows.Forms.TextBox tbNumeratorResult;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Button btnResult;
    }
}

