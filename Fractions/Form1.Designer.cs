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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFullTile1 = new System.Windows.Forms.TextBox();
            this.tbFullTile2 = new System.Windows.Forms.TextBox();
            this.tbResultFullTile = new System.Windows.Forms.TextBox();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumerator1
            // 
            this.tbNumerator1.BackColor = System.Drawing.SystemColors.Window;
            this.tbNumerator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumerator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumerator1.Location = new System.Drawing.Point(76, 55);
            this.tbNumerator1.Name = "tbNumerator1";
            this.tbNumerator1.Size = new System.Drawing.Size(30, 26);
            this.tbNumerator1.TabIndex = 0;
            this.tbNumerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDenominator1
            // 
            this.tbDenominator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDenominator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDenominator1.Location = new System.Drawing.Point(76, 86);
            this.tbDenominator1.Name = "tbDenominator1";
            this.tbDenominator1.Size = new System.Drawing.Size(30, 26);
            this.tbDenominator1.TabIndex = 1;
            this.tbDenominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumerator2
            // 
            this.tbNumerator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumerator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumerator2.Location = new System.Drawing.Point(262, 54);
            this.tbNumerator2.Name = "tbNumerator2";
            this.tbNumerator2.Size = new System.Drawing.Size(30, 26);
            this.tbNumerator2.TabIndex = 2;
            this.tbNumerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDenominator2
            // 
            this.tbDenominator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDenominator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDenominator2.Location = new System.Drawing.Point(262, 86);
            this.tbDenominator2.Name = "tbDenominator2";
            this.tbDenominator2.Size = new System.Drawing.Size(30, 26);
            this.tbDenominator2.TabIndex = 3;
            this.tbDenominator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultDenominator
            // 
            this.tbResultDenominator.BackColor = System.Drawing.SystemColors.Window;
            this.tbResultDenominator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultDenominator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultDenominator.Location = new System.Drawing.Point(434, 86);
            this.tbResultDenominator.Name = "tbResultDenominator";
            this.tbResultDenominator.ReadOnly = true;
            this.tbResultDenominator.Size = new System.Drawing.Size(30, 26);
            this.tbResultDenominator.TabIndex = 4;
            this.tbResultDenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultNumerator
            // 
            this.tbResultNumerator.BackColor = System.Drawing.SystemColors.Window;
            this.tbResultNumerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultNumerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultNumerator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbResultNumerator.Location = new System.Drawing.Point(434, 54);
            this.tbResultNumerator.Name = "tbResultNumerator";
            this.tbResultNumerator.ReadOnly = true;
            this.tbResultNumerator.Size = new System.Drawing.Size(30, 26);
            this.tbResultNumerator.TabIndex = 5;
            this.tbResultNumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbJob
            // 
            this.cbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJob.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Items.AddRange(new object[] {
            "Сложить",
            "Вычесть",
            "Умножить",
            "Разделить",
            "Меньше",
            "Больше"});
            this.cbJob.Location = new System.Drawing.Point(120, 69);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(91, 24);
            this.cbJob.TabIndex = 7;
            this.cbJob.Text = "Выбрать";
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(307, 72);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Результат";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.авторToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // tbFullTile1
            // 
            this.tbFullTile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullTile1.Location = new System.Drawing.Point(40, 60);
            this.tbFullTile1.Name = "tbFullTile1";
            this.tbFullTile1.Size = new System.Drawing.Size(30, 38);
            this.tbFullTile1.TabIndex = 10;
            this.tbFullTile1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFullTile2
            // 
            this.tbFullTile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullTile2.Location = new System.Drawing.Point(226, 60);
            this.tbFullTile2.Name = "tbFullTile2";
            this.tbFullTile2.Size = new System.Drawing.Size(30, 38);
            this.tbFullTile2.TabIndex = 11;
            this.tbFullTile2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbResultFullTile
            // 
            this.tbResultFullTile.BackColor = System.Drawing.SystemColors.Window;
            this.tbResultFullTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultFullTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResultFullTile.Location = new System.Drawing.Point(398, 60);
            this.tbResultFullTile.Name = "tbResultFullTile";
            this.tbResultFullTile.ReadOnly = true;
            this.tbResultFullTile.Size = new System.Drawing.Size(30, 38);
            this.tbResultFullTile.TabIndex = 12;
            this.tbResultFullTile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 162);
            this.Controls.Add(this.tbResultFullTile);
            this.Controls.Add(this.tbFullTile2);
            this.Controls.Add(this.tbFullTile1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.tbResultNumerator);
            this.Controls.Add(this.tbResultDenominator);
            this.Controls.Add(this.tbDenominator2);
            this.Controls.Add(this.tbNumerator2);
            this.Controls.Add(this.tbDenominator1);
            this.Controls.Add(this.tbNumerator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Дробный калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.TextBox tbFullTile1;
        private System.Windows.Forms.TextBox tbFullTile2;
        private System.Windows.Forms.TextBox tbResultFullTile;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    }
}

