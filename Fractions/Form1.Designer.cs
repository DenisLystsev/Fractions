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
            this.tbResultDenominator = new System.Windows.Forms.TextBox();
            this.tbResultNumerator = new System.Windows.Forms.TextBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumerator1
            // 
            this.tbNumerator1.Location = new System.Drawing.Point(224, 52);
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
            this.tbNumerator2.Location = new System.Drawing.Point(305, 52);
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
            // tbResultDenominator
            // 
            this.tbResultDenominator.Location = new System.Drawing.Point(423, 91);
            this.tbResultDenominator.Name = "tbResultDenominator";
            this.tbResultDenominator.ReadOnly = true;
            this.tbResultDenominator.Size = new System.Drawing.Size(30, 20);
            this.tbResultDenominator.TabIndex = 4;
            // 
            // tbResultNumerator
            // 
            this.tbResultNumerator.Location = new System.Drawing.Point(423, 52);
            this.tbResultNumerator.Name = "tbResultNumerator";
            this.tbResultNumerator.ReadOnly = true;
            this.tbResultNumerator.Size = new System.Drawing.Size(30, 20);
            this.tbResultNumerator.TabIndex = 5;
            // 
            // cbJob
            // 
            this.cbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbJob.Location = new System.Drawing.Point(260, 67);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(39, 24);
            this.cbJob.TabIndex = 7;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(342, 67);
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
            this.Controls.Add(this.tbResultNumerator);
            this.Controls.Add(this.tbResultDenominator);
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
        private System.Windows.Forms.TextBox tbResultDenominator;
        private System.Windows.Forms.TextBox tbResultNumerator;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Button btnResult;
    }
}

