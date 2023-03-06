namespace bin_archive_compiler
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
            this.ExtractButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ExtractFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExtractOutputPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertOutputPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertFolderPath = new System.Windows.Forms.TextBox();
            this.ExtractFileSearch = new System.Windows.Forms.Button();
            this.ExtractOutputSearch = new System.Windows.Forms.Button();
            this.InsertDirectoreSearch = new System.Windows.Forms.Button();
            this.InsertOutputSearch = new System.Windows.Forms.Button();
            this.ExtractValErr = new System.Windows.Forms.Label();
            this.InsertValErr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertOutputName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractButton.Location = new System.Drawing.Point(670, 136);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(255, 44);
            this.ExtractButton.TabIndex = 0;
            this.ExtractButton.Text = "Разобрать архив";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertButton.Location = new System.Drawing.Point(670, 392);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(255, 44);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Собрать архив";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertFile_Click);
            // 
            // ExtractFilePath
            // 
            this.ExtractFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractFilePath.Location = new System.Drawing.Point(416, 12);
            this.ExtractFilePath.Name = "ExtractFilePath";
            this.ExtractFilePath.Size = new System.Drawing.Size(509, 34);
            this.ExtractFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберете bin архив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберете место для вывода";
            // 
            // ExtractOutputPath
            // 
            this.ExtractOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractOutputPath.Location = new System.Drawing.Point(416, 78);
            this.ExtractOutputPath.Name = "ExtractOutputPath";
            this.ExtractOutputPath.Size = new System.Drawing.Size(509, 34);
            this.ExtractOutputPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберете место для вывода";
            // 
            // InsertOutputPath
            // 
            this.InsertOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertOutputPath.Location = new System.Drawing.Point(416, 270);
            this.InsertOutputPath.Name = "InsertOutputPath";
            this.InsertOutputPath.Size = new System.Drawing.Size(509, 34);
            this.InsertOutputPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберете папку с файлами";
            // 
            // InsertFolderPath
            // 
            this.InsertFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertFolderPath.Location = new System.Drawing.Point(416, 204);
            this.InsertFolderPath.Name = "InsertFolderPath";
            this.InsertFolderPath.Size = new System.Drawing.Size(509, 34);
            this.InsertFolderPath.TabIndex = 6;
            // 
            // ExtractFileSearch
            // 
            this.ExtractFileSearch.Location = new System.Drawing.Point(931, 15);
            this.ExtractFileSearch.Name = "ExtractFileSearch";
            this.ExtractFileSearch.Size = new System.Drawing.Size(60, 28);
            this.ExtractFileSearch.TabIndex = 10;
            this.ExtractFileSearch.Text = "Найти";
            this.ExtractFileSearch.UseVisualStyleBackColor = true;
            this.ExtractFileSearch.Click += new System.EventHandler(this.ExtractFileSearch_Click);
            // 
            // ExtractOutputSearch
            // 
            this.ExtractOutputSearch.Location = new System.Drawing.Point(931, 81);
            this.ExtractOutputSearch.Name = "ExtractOutputSearch";
            this.ExtractOutputSearch.Size = new System.Drawing.Size(60, 28);
            this.ExtractOutputSearch.TabIndex = 11;
            this.ExtractOutputSearch.Text = "Найти";
            this.ExtractOutputSearch.UseVisualStyleBackColor = true;
            this.ExtractOutputSearch.Click += new System.EventHandler(this.ExtractOutputSearch_Click);
            // 
            // InsertDirectoreSearch
            // 
            this.InsertDirectoreSearch.Location = new System.Drawing.Point(931, 207);
            this.InsertDirectoreSearch.Name = "InsertDirectoreSearch";
            this.InsertDirectoreSearch.Size = new System.Drawing.Size(60, 28);
            this.InsertDirectoreSearch.TabIndex = 12;
            this.InsertDirectoreSearch.Text = "Найти";
            this.InsertDirectoreSearch.UseVisualStyleBackColor = true;
            this.InsertDirectoreSearch.Click += new System.EventHandler(this.InsertDirectoreSearch_Click);
            // 
            // InsertOutputSearch
            // 
            this.InsertOutputSearch.Location = new System.Drawing.Point(931, 273);
            this.InsertOutputSearch.Name = "InsertOutputSearch";
            this.InsertOutputSearch.Size = new System.Drawing.Size(60, 28);
            this.InsertOutputSearch.TabIndex = 13;
            this.InsertOutputSearch.Text = "Найти";
            this.InsertOutputSearch.UseVisualStyleBackColor = true;
            this.InsertOutputSearch.Click += new System.EventHandler(this.InsertOutputSearch_Click);
            // 
            // ExtractValErr
            // 
            this.ExtractValErr.AutoSize = true;
            this.ExtractValErr.ForeColor = System.Drawing.Color.Red;
            this.ExtractValErr.Location = new System.Drawing.Point(607, 154);
            this.ExtractValErr.Name = "ExtractValErr";
            this.ExtractValErr.Size = new System.Drawing.Size(57, 16);
            this.ExtractValErr.TabIndex = 16;
            this.ExtractValErr.Text = "Ошибка";
            this.ExtractValErr.Visible = false;
            // 
            // InsertValErr
            // 
            this.InsertValErr.AutoSize = true;
            this.InsertValErr.ForeColor = System.Drawing.Color.Red;
            this.InsertValErr.Location = new System.Drawing.Point(607, 410);
            this.InsertValErr.Name = "InsertValErr";
            this.InsertValErr.Size = new System.Drawing.Size(57, 16);
            this.InsertValErr.TabIndex = 17;
            this.InsertValErr.Text = "Ошибка";
            this.InsertValErr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Выберете название для архива";
            // 
            // InsertOutputName
            // 
            this.InsertOutputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertOutputName.Location = new System.Drawing.Point(416, 334);
            this.InsertOutputName.Name = "InsertOutputName";
            this.InsertOutputName.Size = new System.Drawing.Size(509, 34);
            this.InsertOutputName.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InsertOutputName);
            this.Controls.Add(this.InsertValErr);
            this.Controls.Add(this.ExtractValErr);
            this.Controls.Add(this.InsertOutputSearch);
            this.Controls.Add(this.InsertDirectoreSearch);
            this.Controls.Add(this.ExtractOutputSearch);
            this.Controls.Add(this.ExtractFileSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsertFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExtractOutputPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtractFilePath);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ExtractButton);
            this.Name = "Form1";
            this.Text = "bin-archive-compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox ExtractFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExtractOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InsertOutputPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InsertFolderPath;
        private System.Windows.Forms.Button ExtractFileSearch;
        private System.Windows.Forms.Button ExtractOutputSearch;
        private System.Windows.Forms.Button InsertDirectoreSearch;
        private System.Windows.Forms.Button InsertOutputSearch;
        private System.Windows.Forms.Label ExtractValErr;
        private System.Windows.Forms.Label InsertValErr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InsertOutputName;
    }
}

