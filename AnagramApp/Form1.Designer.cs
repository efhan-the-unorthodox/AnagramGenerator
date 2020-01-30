namespace AnagramApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRandChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandomCharacters = new System.Windows.Forms.Button();
            this.generateWords = new System.Windows.Forms.Button();
            this.lbAnagrams = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anagram";
            // 
            // tbRandChar
            // 
            this.tbRandChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRandChar.Location = new System.Drawing.Point(235, 112);
            this.tbRandChar.Name = "tbRandChar";
            this.tbRandChar.Size = new System.Drawing.Size(299, 34);
            this.tbRandChar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Characters";
            // 
            // btnRandomCharacters
            // 
            this.btnRandomCharacters.Location = new System.Drawing.Point(235, 169);
            this.btnRandomCharacters.Name = "btnRandomCharacters";
            this.btnRandomCharacters.Size = new System.Drawing.Size(106, 34);
            this.btnRandomCharacters.TabIndex = 3;
            this.btnRandomCharacters.Text = "Random";
            this.btnRandomCharacters.UseVisualStyleBackColor = true;
            this.btnRandomCharacters.Click += new System.EventHandler(this.randomCharacters_Click);
            // 
            // generateWords
            // 
            this.generateWords.Location = new System.Drawing.Point(363, 169);
            this.generateWords.Name = "generateWords";
            this.generateWords.Size = new System.Drawing.Size(106, 34);
            this.generateWords.TabIndex = 4;
            this.generateWords.Text = "Generate";
            this.generateWords.UseVisualStyleBackColor = true;
            this.generateWords.Click += new System.EventHandler(this.generateWords_Click);
            // 
            // lbAnagrams
            // 
            this.lbAnagrams.FormattingEnabled = true;
            this.lbAnagrams.ItemHeight = 16;
            this.lbAnagrams.Location = new System.Drawing.Point(235, 242);
            this.lbAnagrams.Name = "lbAnagrams";
            this.lbAnagrams.Size = new System.Drawing.Size(299, 196);
            this.lbAnagrams.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAnagrams);
            this.Controls.Add(this.generateWords);
            this.Controls.Add(this.btnRandomCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRandChar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Anagram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRandChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandomCharacters;
        private System.Windows.Forms.Button generateWords;
        private System.Windows.Forms.ListBox lbAnagrams;
    }
}

