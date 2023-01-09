namespace Parfonov_RE_21mp_LR5
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
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_SHA512 = new System.Windows.Forms.RadioButton();
            this.rb_SHA384 = new System.Windows.Forms.RadioButton();
            this.rb_SHA256 = new System.Windows.Forms.RadioButton();
            this.rb_SHA1 = new System.Windows.Forms.RadioButton();
            this.rb_MD5 = new System.Windows.Forms.RadioButton();
            this.rb_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rb_HAVAL = new System.Windows.Forms.RadioButton();
            this.rb_CRC32 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bInFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_mb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_b = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(197, 60);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(176, 22);
            this.tInFilePath.TabIndex = 0;
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(197, 108);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(176, 22);
            this.tOutFilePath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_SHA512);
            this.groupBox1.Controls.Add(this.rb_SHA384);
            this.groupBox1.Controls.Add(this.rb_SHA256);
            this.groupBox1.Controls.Add(this.rb_SHA1);
            this.groupBox1.Controls.Add(this.rb_MD5);
            this.groupBox1.Controls.Add(this.rb_RIPEMD160);
            this.groupBox1.Controls.Add(this.rb_HAVAL);
            this.groupBox1.Controls.Add(this.rb_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(34, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи";
            // 
            // rb_SHA512
            // 
            this.rb_SHA512.AutoSize = true;
            this.rb_SHA512.Location = new System.Drawing.Point(126, 142);
            this.rb_SHA512.Name = "rb_SHA512";
            this.rb_SHA512.Size = new System.Drawing.Size(81, 20);
            this.rb_SHA512.TabIndex = 7;
            this.rb_SHA512.TabStop = true;
            this.rb_SHA512.Text = "SHA-512";
            this.rb_SHA512.UseVisualStyleBackColor = true;
            // 
            // rb_SHA384
            // 
            this.rb_SHA384.AutoSize = true;
            this.rb_SHA384.Location = new System.Drawing.Point(126, 104);
            this.rb_SHA384.Name = "rb_SHA384";
            this.rb_SHA384.Size = new System.Drawing.Size(81, 20);
            this.rb_SHA384.TabIndex = 6;
            this.rb_SHA384.TabStop = true;
            this.rb_SHA384.Text = "SHA-384";
            this.rb_SHA384.UseVisualStyleBackColor = true;
            // 
            // rb_SHA256
            // 
            this.rb_SHA256.AutoSize = true;
            this.rb_SHA256.Location = new System.Drawing.Point(127, 68);
            this.rb_SHA256.Name = "rb_SHA256";
            this.rb_SHA256.Size = new System.Drawing.Size(81, 20);
            this.rb_SHA256.TabIndex = 5;
            this.rb_SHA256.TabStop = true;
            this.rb_SHA256.Text = "SHA-256";
            this.rb_SHA256.UseVisualStyleBackColor = true;
            // 
            // rb_SHA1
            // 
            this.rb_SHA1.AutoSize = true;
            this.rb_SHA1.Location = new System.Drawing.Point(127, 29);
            this.rb_SHA1.Name = "rb_SHA1";
            this.rb_SHA1.Size = new System.Drawing.Size(67, 20);
            this.rb_SHA1.TabIndex = 4;
            this.rb_SHA1.TabStop = true;
            this.rb_SHA1.Text = "SHA-1";
            this.rb_SHA1.UseVisualStyleBackColor = true;
            // 
            // rb_MD5
            // 
            this.rb_MD5.AutoSize = true;
            this.rb_MD5.Location = new System.Drawing.Point(6, 142);
            this.rb_MD5.Name = "rb_MD5";
            this.rb_MD5.Size = new System.Drawing.Size(56, 20);
            this.rb_MD5.TabIndex = 3;
            this.rb_MD5.TabStop = true;
            this.rb_MD5.Text = "MD5";
            this.rb_MD5.UseVisualStyleBackColor = true;
            // 
            // rb_RIPEMD160
            // 
            this.rb_RIPEMD160.AutoSize = true;
            this.rb_RIPEMD160.Location = new System.Drawing.Point(6, 104);
            this.rb_RIPEMD160.Name = "rb_RIPEMD160";
            this.rb_RIPEMD160.Size = new System.Drawing.Size(101, 20);
            this.rb_RIPEMD160.TabIndex = 2;
            this.rb_RIPEMD160.TabStop = true;
            this.rb_RIPEMD160.Text = "RIPEMD160";
            this.rb_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rb_HAVAL
            // 
            this.rb_HAVAL.AutoSize = true;
            this.rb_HAVAL.Location = new System.Drawing.Point(7, 68);
            this.rb_HAVAL.Name = "rb_HAVAL";
            this.rb_HAVAL.Size = new System.Drawing.Size(116, 20);
            this.rb_HAVAL.TabIndex = 1;
            this.rb_HAVAL.TabStop = true;
            this.rb_HAVAL.Text = "HashAlgorithm";
            this.rb_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rb_CRC32
            // 
            this.rb_CRC32.AutoSize = true;
            this.rb_CRC32.Location = new System.Drawing.Point(7, 29);
            this.rb_CRC32.Name = "rb_CRC32";
            this.rb_CRC32.Size = new System.Drawing.Size(70, 20);
            this.rb_CRC32.TabIndex = 0;
            this.rb_CRC32.TabStop = true;
            this.rb_CRC32.Text = "CRC32";
            this.rb_CRC32.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вихідний файл:";
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(379, 58);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(48, 24);
            this.bInFile.TabIndex = 5;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.bInFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(379, 106);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(48, 24);
            this.bOutFile.TabIndex = 6;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(286, 361);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(89, 23);
            this.bStart.TabIndex = 7;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(398, 361);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(87, 23);
            this.bClean.TabIndex = 8;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_mb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(286, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт)";
            // 
            // label_mb
            // 
            this.label_mb.AutoSize = true;
            this.label_mb.Location = new System.Drawing.Point(139, 34);
            this.label_mb.Name = "label_mb";
            this.label_mb.Size = new System.Drawing.Size(28, 16);
            this.label_mb.TabIndex = 1;
            this.label_mb.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_b);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label_time);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(285, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 103);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байт)";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(137, 33);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(28, 16);
            this.label_b.TabIndex = 3;
            this.label_b.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тривалість кодування:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(75, 75);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 16);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вихідного файлу:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(51, 368);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 16);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Парфьонов Г. В.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(194, 368);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 16);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ЛР5";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 396);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.bInFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_SHA512;
        private System.Windows.Forms.RadioButton rb_SHA384;
        private System.Windows.Forms.RadioButton rb_SHA256;
        private System.Windows.Forms.RadioButton rb_SHA1;
        private System.Windows.Forms.RadioButton rb_MD5;
        private System.Windows.Forms.RadioButton rb_RIPEMD160;
        private System.Windows.Forms.RadioButton rb_HAVAL;
        private System.Windows.Forms.RadioButton rb_CRC32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bInFile;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_mb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

