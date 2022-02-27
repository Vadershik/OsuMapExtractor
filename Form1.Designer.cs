
namespace OsuMapExtractor
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
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.InputBoxFolder = new System.Windows.Forms.TextBox();
            this.OutputBoxFolder = new System.Windows.Forms.TextBox();
            this.InputFolderChangeButton = new System.Windows.Forms.Button();
            this.OutPutFolderChangeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(269, 74);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 79);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osu Songs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Folder:";
            // 
            // InputBoxFolder
            // 
            this.InputBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputBoxFolder.Location = new System.Drawing.Point(111, 12);
            this.InputBoxFolder.Name = "InputBoxFolder";
            this.InputBoxFolder.Size = new System.Drawing.Size(152, 23);
            this.InputBoxFolder.TabIndex = 3;
            // 
            // OutputBoxFolder
            // 
            this.OutputBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputBoxFolder.Location = new System.Drawing.Point(111, 43);
            this.OutputBoxFolder.Name = "OutputBoxFolder";
            this.OutputBoxFolder.Size = new System.Drawing.Size(152, 23);
            this.OutputBoxFolder.TabIndex = 4;
            // 
            // InputFolderChangeButton
            // 
            this.InputFolderChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputFolderChangeButton.Location = new System.Drawing.Point(269, 12);
            this.InputFolderChangeButton.Name = "InputFolderChangeButton";
            this.InputFolderChangeButton.Size = new System.Drawing.Size(86, 23);
            this.InputFolderChangeButton.TabIndex = 5;
            this.InputFolderChangeButton.Text = "Change";
            this.InputFolderChangeButton.UseVisualStyleBackColor = true;
            this.InputFolderChangeButton.Click += new System.EventHandler(this.InputFolderChangeButton_Click);
            // 
            // OutPutFolderChangeButton
            // 
            this.OutPutFolderChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutPutFolderChangeButton.Location = new System.Drawing.Point(268, 43);
            this.OutPutFolderChangeButton.Name = "OutPutFolderChangeButton";
            this.OutPutFolderChangeButton.Size = new System.Drawing.Size(86, 23);
            this.OutPutFolderChangeButton.TabIndex = 6;
            this.OutPutFolderChangeButton.Text = "Change";
            this.OutPutFolderChangeButton.UseVisualStyleBackColor = true;
            this.OutPutFolderChangeButton.Click += new System.EventHandler(this.OutPutFolderChangeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cols maps:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "none - all maps\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name Filter:";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(110, 127);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(151, 26);
            this.SearchBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutPutFolderChangeButton);
            this.Controls.Add(this.InputFolderChangeButton);
            this.Controls.Add(this.OutputBoxFolder);
            this.Controls.Add(this.InputBoxFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 203);
            this.MinimumSize = new System.Drawing.Size(394, 203);
            this.Name = "Form1";
            this.Text = "Osu Map Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox InputBoxFolder;
        private System.Windows.Forms.TextBox OutputBoxFolder;
        private System.Windows.Forms.Button InputFolderChangeButton;
        private System.Windows.Forms.Button OutPutFolderChangeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchBox;
    }
}

