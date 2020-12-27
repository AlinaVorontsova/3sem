namespace lab4
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchTime = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.buttonParallelSearch = new System.Windows.Forms.Button();
            this.listBoxParallelResult = new System.Windows.Forms.ListBox();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чтение из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(401, 39);
            this.textBoxFileReadTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(191, 22);
            this.textBoxFileReadTime.TabIndex = 1;
            this.textBoxFileReadTime.TextChanged += new System.EventHandler(this.textBoxFileReadTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время чтения из файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество уникальных слов в файле";
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.Location = new System.Drawing.Point(507, 68);
            this.textBoxFileReadCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxFileReadCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поиск слова";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите слово:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(123, 117);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(203, 22);
            this.textBoxFind.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(360, 114);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(145, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Найти слово";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время поиска:";
            // 
            // textBoxSearchTime
            // 
            this.textBoxSearchTime.Location = new System.Drawing.Point(123, 148);
            this.textBoxSearchTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchTime.Name = "textBoxSearchTime";
            this.textBoxSearchTime.Size = new System.Drawing.Size(203, 22);
            this.textBoxSearchTime.TabIndex = 10;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(123, 187);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(203, 132);
            this.listBoxResult.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Лаборатоная работа 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Лаборатоная работа 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Максимальное расстояние";
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(215, 372);
            this.textBoxMaxDist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(132, 22);
            this.textBoxMaxDist.TabIndex = 15;
            // 
            // buttonParallelSearch
            // 
            this.buttonParallelSearch.Location = new System.Drawing.Point(16, 513);
            this.buttonParallelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonParallelSearch.Name = "buttonParallelSearch";
            this.buttonParallelSearch.Size = new System.Drawing.Size(191, 28);
            this.buttonParallelSearch.TabIndex = 16;
            this.buttonParallelSearch.Text = "Параллельный поиск";
            this.buttonParallelSearch.UseVisualStyleBackColor = true;
            this.buttonParallelSearch.Click += new System.EventHandler(this.buttonParallelSearch_Click);
            // 
            // listBoxParallelResult
            // 
            this.listBoxParallelResult.FormattingEnabled = true;
            this.listBoxParallelResult.ItemHeight = 16;
            this.listBoxParallelResult.Location = new System.Drawing.Point(144, 549);
            this.listBoxParallelResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxParallelResult.Name = "listBoxParallelResult";
            this.listBoxParallelResult.Size = new System.Drawing.Size(388, 180);
            this.listBoxParallelResult.TabIndex = 17;
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(215, 409);
            this.textBoxThreadCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(132, 22);
            this.textBoxThreadCount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Число потоков";
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(624, 670);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(123, 59);
            this.buttonSaveReport.TabIndex = 20;
            this.buttonSaveReport.Text = "Сохранить отчёт";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(254, 452);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(132, 22);
            this.textBoxThreadCountAll.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Вычисленное количество потоков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 745);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.buttonSaveReport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.listBoxParallelResult);
            this.Controls.Add(this.buttonParallelSearch);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxSearchTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchTime;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Button buttonParallelSearch;
        private System.Windows.Forms.ListBox listBoxParallelResult;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.Label label11;
    }
}

