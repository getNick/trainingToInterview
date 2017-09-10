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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(28, 25);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(546, 147);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = "";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(28, 199);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(546, 147);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "";
            // 
            // selectLPair
            // 
            this.selectLPair.FormattingEnabled = true;
            this.selectLPair.Items.AddRange(new object[] {
            "en-ru",
            "ru-en"});
            this.selectLPair.Location = new System.Drawing.Point(604, 54);
            this.selectLPair.Name = "selectLPair";
            this.selectLPair.Size = new System.Drawing.Size(121, 24);
            this.selectLPair.TabIndex = 2;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(604, 120);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(121, 52);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAPIKeyToolStripMenuItem,
            this.changeFilePathToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeAPIKeyToolStripMenuItem
            // 
            this.changeAPIKeyToolStripMenuItem.Name = "changeAPIKeyToolStripMenuItem";
            this.changeAPIKeyToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.changeAPIKeyToolStripMenuItem.Text = "Change API key";
            this.changeAPIKeyToolStripMenuItem.Click += new System.EventHandler(this.changeAPIKeyToolStripMenuItem_Click);
            // 
            // changeFilePathToolStripMenuItem
            // 
            this.changeFilePathToolStripMenuItem.Name = "changeFilePathToolStripMenuItem";
            this.changeFilePathToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.changeFilePathToolStripMenuItem.Text = "Change file path";
            this.changeFilePathToolStripMenuItem.Click += new System.EventHandler(this.changeFilePath);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 372);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.selectLPair);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.ComboBox selectLPair;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFilePathToolStripMenuItem;
    }
}

