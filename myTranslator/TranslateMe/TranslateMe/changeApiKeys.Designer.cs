namespace TranslateMe
{
    partial class changeApiKeys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTranslateKey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDictionaryKey = new System.Windows.Forms.RichTextBox();
            this.btnChangeTranslateKey = new System.Windows.Forms.Button();
            this.btnChangeDictionaryKey = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTranslateKey
            // 
            this.tbTranslateKey.Location = new System.Drawing.Point(12, 41);
            this.tbTranslateKey.Name = "tbTranslateKey";
            this.tbTranslateKey.Size = new System.Drawing.Size(592, 43);
            this.tbTranslateKey.TabIndex = 0;
            this.tbTranslateKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Translate Api key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dictionary Api key";
            // 
            // tbDictionaryKey
            // 
            this.tbDictionaryKey.Location = new System.Drawing.Point(16, 135);
            this.tbDictionaryKey.Name = "tbDictionaryKey";
            this.tbDictionaryKey.Size = new System.Drawing.Size(592, 43);
            this.tbDictionaryKey.TabIndex = 2;
            this.tbDictionaryKey.Text = "";
            // 
            // btnChangeTranslateKey
            // 
            this.btnChangeTranslateKey.Location = new System.Drawing.Point(623, 41);
            this.btnChangeTranslateKey.Name = "btnChangeTranslateKey";
            this.btnChangeTranslateKey.Size = new System.Drawing.Size(110, 42);
            this.btnChangeTranslateKey.TabIndex = 4;
            this.btnChangeTranslateKey.Text = "Change";
            this.btnChangeTranslateKey.UseVisualStyleBackColor = true;
            this.btnChangeTranslateKey.Click += new System.EventHandler(this.btnChangeTranslateKey_Click);
            // 
            // btnChangeDictionaryKey
            // 
            this.btnChangeDictionaryKey.Location = new System.Drawing.Point(623, 136);
            this.btnChangeDictionaryKey.Name = "btnChangeDictionaryKey";
            this.btnChangeDictionaryKey.Size = new System.Drawing.Size(110, 42);
            this.btnChangeDictionaryKey.TabIndex = 5;
            this.btnChangeDictionaryKey.Text = "Change";
            this.btnChangeDictionaryKey.UseVisualStyleBackColor = true;
            this.btnChangeDictionaryKey.Click += new System.EventHandler(this.btnChangeDictionaryKey_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // changeApiKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 270);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeDictionaryKey);
            this.Controls.Add(this.btnChangeTranslateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDictionaryKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTranslateKey);
            this.Name = "changeApiKeys";
            this.Text = "changeApiKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbTranslateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDictionaryKey;
        private System.Windows.Forms.Button btnChangeTranslateKey;
        private System.Windows.Forms.Button btnChangeDictionaryKey;
        private System.Windows.Forms.Button btnSave;
    }
}