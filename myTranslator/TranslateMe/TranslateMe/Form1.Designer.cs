namespace TranslateMe
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
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.selectLPair = new System.Windows.Forms.ComboBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tranlator = new System.Windows.Forms.TabPage();
            this.repeatWord = new System.Windows.Forms.TabPage();
            this.checkAnswer = new System.Windows.Forms.Button();
            this.wordToTranslate = new System.Windows.Forms.Label();
            this.selectWordCollection = new System.Windows.Forms.CheckedListBox();
            this.answer = new System.Windows.Forms.RichTextBox();
            this.settings = new System.Windows.Forms.TabPage();
            this.bntChangeFilePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeDictionaryKey = new System.Windows.Forms.Button();
            this.btnChangeTranslateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDictionaryKey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTranslateKey = new System.Windows.Forms.RichTextBox();
            this.selectAllWords = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tranlator.SuspendLayout();
            this.repeatWord.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(25, 25);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(513, 147);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(25, 199);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(513, 147);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "";
            // 
            // selectLPair
            // 
            this.selectLPair.FormattingEnabled = true;
            this.selectLPair.Items.AddRange(new object[] {
            "en-ru",
            "ru-en"});
            this.selectLPair.Location = new System.Drawing.Point(562, 25);
            this.selectLPair.Name = "selectLPair";
            this.selectLPair.Size = new System.Drawing.Size(121, 24);
            this.selectLPair.TabIndex = 2;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(562, 120);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(121, 52);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(562, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tranlator);
            this.tabControl1.Controls.Add(this.repeatWord);
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 429);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tranlator
            // 
            this.Tranlator.Controls.Add(this.tbInput);
            this.Tranlator.Controls.Add(this.btnSave);
            this.Tranlator.Controls.Add(this.tbResult);
            this.Tranlator.Controls.Add(this.btnTranslate);
            this.Tranlator.Controls.Add(this.selectLPair);
            this.Tranlator.Location = new System.Drawing.Point(4, 25);
            this.Tranlator.Name = "Tranlator";
            this.Tranlator.Padding = new System.Windows.Forms.Padding(3);
            this.Tranlator.Size = new System.Drawing.Size(762, 400);
            this.Tranlator.TabIndex = 0;
            this.Tranlator.Text = "Tranlator";
            this.Tranlator.UseVisualStyleBackColor = true;
            // 
            // repeatWord
            // 
            this.repeatWord.Controls.Add(this.btnHelp);
            this.repeatWord.Controls.Add(this.selectAllWords);
            this.repeatWord.Controls.Add(this.checkAnswer);
            this.repeatWord.Controls.Add(this.wordToTranslate);
            this.repeatWord.Controls.Add(this.selectWordCollection);
            this.repeatWord.Controls.Add(this.answer);
            this.repeatWord.Location = new System.Drawing.Point(4, 25);
            this.repeatWord.Name = "repeatWord";
            this.repeatWord.Padding = new System.Windows.Forms.Padding(3);
            this.repeatWord.Size = new System.Drawing.Size(762, 400);
            this.repeatWord.TabIndex = 1;
            this.repeatWord.Text = "Repeat of learned words";
            this.repeatWord.UseVisualStyleBackColor = true;
            // 
            // checkAnswer
            // 
            this.checkAnswer.Location = new System.Drawing.Point(561, 276);
            this.checkAnswer.Name = "checkAnswer";
            this.checkAnswer.Size = new System.Drawing.Size(168, 45);
            this.checkAnswer.TabIndex = 3;
            this.checkAnswer.Text = "Check";
            this.checkAnswer.UseVisualStyleBackColor = true;
            this.checkAnswer.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // wordToTranslate
            // 
            this.wordToTranslate.AutoSize = true;
            this.wordToTranslate.Location = new System.Drawing.Point(25, 156);
            this.wordToTranslate.Name = "wordToTranslate";
            this.wordToTranslate.Size = new System.Drawing.Size(0, 17);
            this.wordToTranslate.TabIndex = 2;
            // 
            // selectWordCollection
            // 
            this.selectWordCollection.ColumnWidth = 250;
            this.selectWordCollection.FormattingEnabled = true;
            this.selectWordCollection.Items.AddRange(new object[] {
            "all word",
            "added in last month words",
            "added in last week words",
            "added yesterday words",
            "last 100 words",
            "last 50 words",
            "last 10 words"});
            this.selectWordCollection.Location = new System.Drawing.Point(256, 16);
            this.selectWordCollection.MultiColumn = true;
            this.selectWordCollection.Name = "selectWordCollection";
            this.selectWordCollection.Size = new System.Drawing.Size(272, 123);
            this.selectWordCollection.TabIndex = 1;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(28, 225);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(510, 96);
            this.answer.TabIndex = 0;
            this.answer.Text = "";
            // 
            // settings
            // 
            this.settings.Controls.Add(this.bntChangeFilePath);
            this.settings.Controls.Add(this.label3);
            this.settings.Controls.Add(this.tbFilePath);
            this.settings.Controls.Add(this.button1);
            this.settings.Controls.Add(this.btnChangeDictionaryKey);
            this.settings.Controls.Add(this.btnChangeTranslateKey);
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.tbDictionaryKey);
            this.settings.Controls.Add(this.label1);
            this.settings.Controls.Add(this.tbTranslateKey);
            this.settings.Location = new System.Drawing.Point(4, 25);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(762, 400);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // bntChangeFilePath
            // 
            this.bntChangeFilePath.Location = new System.Drawing.Point(629, 243);
            this.bntChangeFilePath.Name = "bntChangeFilePath";
            this.bntChangeFilePath.Size = new System.Drawing.Size(110, 42);
            this.bntChangeFilePath.TabIndex = 16;
            this.bntChangeFilePath.Text = "Change";
            this.bntChangeFilePath.UseVisualStyleBackColor = true;
            this.bntChangeFilePath.Click += new System.EventHandler(this.bntChangeFilePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "File path";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(22, 242);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(592, 43);
            this.tbFilePath.TabIndex = 14;
            this.tbFilePath.Text = "";
            this.tbFilePath.Click += new System.EventHandler(this.bntChangeFilePath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnChangeDictionaryKey
            // 
            this.btnChangeDictionaryKey.Location = new System.Drawing.Point(629, 147);
            this.btnChangeDictionaryKey.Name = "btnChangeDictionaryKey";
            this.btnChangeDictionaryKey.Size = new System.Drawing.Size(110, 42);
            this.btnChangeDictionaryKey.TabIndex = 12;
            this.btnChangeDictionaryKey.Text = "Change";
            this.btnChangeDictionaryKey.UseVisualStyleBackColor = true;
            this.btnChangeDictionaryKey.Click += new System.EventHandler(this.btnChangeDictionaryKey_Click);
            // 
            // btnChangeTranslateKey
            // 
            this.btnChangeTranslateKey.Location = new System.Drawing.Point(629, 52);
            this.btnChangeTranslateKey.Name = "btnChangeTranslateKey";
            this.btnChangeTranslateKey.Size = new System.Drawing.Size(110, 42);
            this.btnChangeTranslateKey.TabIndex = 11;
            this.btnChangeTranslateKey.Text = "Change";
            this.btnChangeTranslateKey.UseVisualStyleBackColor = true;
            this.btnChangeTranslateKey.Click += new System.EventHandler(this.btnChangeTranslateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dictionary Api key";
            // 
            // tbDictionaryKey
            // 
            this.tbDictionaryKey.Location = new System.Drawing.Point(22, 146);
            this.tbDictionaryKey.Name = "tbDictionaryKey";
            this.tbDictionaryKey.Size = new System.Drawing.Size(592, 43);
            this.tbDictionaryKey.TabIndex = 9;
            this.tbDictionaryKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Translate Api key";
            // 
            // tbTranslateKey
            // 
            this.tbTranslateKey.Location = new System.Drawing.Point(26, 52);
            this.tbTranslateKey.Name = "tbTranslateKey";
            this.tbTranslateKey.Size = new System.Drawing.Size(592, 43);
            this.tbTranslateKey.TabIndex = 7;
            this.tbTranslateKey.Text = "";
            // 
            // selectAllWords
            // 
            this.selectAllWords.AutoSize = true;
            this.selectAllWords.Location = new System.Drawing.Point(68, 37);
            this.selectAllWords.Name = "selectAllWords";
            this.selectAllWords.Size = new System.Drawing.Size(85, 21);
            this.selectAllWords.TabIndex = 4;
            this.selectAllWords.TabStop = true;
            this.selectAllWords.Text = "All words";
            this.selectAllWords.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(561, 225);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(168, 45);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Tranlator.ResumeLayout(false);
            this.repeatWord.ResumeLayout(false);
            this.repeatWord.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.ComboBox selectLPair;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tranlator;
        private System.Windows.Forms.TabPage repeatWord;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Button bntChangeFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangeDictionaryKey;
        private System.Windows.Forms.Button btnChangeTranslateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDictionaryKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbTranslateKey;
        private System.Windows.Forms.Button checkAnswer;
        private System.Windows.Forms.Label wordToTranslate;
        private System.Windows.Forms.CheckedListBox selectWordCollection;
        private System.Windows.Forms.RichTextBox answer;
        private System.Windows.Forms.RadioButton selectAllWords;
        private System.Windows.Forms.Button btnHelp;
    }
}

