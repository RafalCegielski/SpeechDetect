namespace SpeechDetect
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadGrammar = new System.Windows.Forms.Button();
            this.btnRandomWord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStartRecognize = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(198, 58);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(296, 63);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Wynik: 0 %";
            // 
            // labelWord
            // 
            this.labelWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWord.Location = new System.Drawing.Point(0, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(696, 100);
            this.labelWord.TabIndex = 2;
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(287, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lub wylosuj słowo";
            // 
            // btnLoadGrammar
            // 
            this.btnLoadGrammar.Image = global::SpeechDetect.Properties.Resources.słownik;
            this.btnLoadGrammar.Location = new System.Drawing.Point(532, 484);
            this.btnLoadGrammar.Name = "btnLoadGrammar";
            this.btnLoadGrammar.Size = new System.Drawing.Size(95, 96);
            this.btnLoadGrammar.TabIndex = 4;
            this.btnLoadGrammar.UseVisualStyleBackColor = true;
            this.btnLoadGrammar.Click += new System.EventHandler(this.btnLoadGrammar_Click);
            // 
            // btnRandomWord
            // 
            this.btnRandomWord.Image = global::SpeechDetect.Properties.Resources.kostka;
            this.btnRandomWord.Location = new System.Drawing.Point(291, 484);
            this.btnRandomWord.Margin = new System.Windows.Forms.Padding(0);
            this.btnRandomWord.Name = "btnRandomWord";
            this.btnRandomWord.Size = new System.Drawing.Size(132, 96);
            this.btnRandomWord.TabIndex = 0;
            this.btnRandomWord.UseVisualStyleBackColor = true;
            this.btnRandomWord.Click += new System.EventHandler(this.btnRandomWord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(528, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wczytaj słownik";
            // 
            // btnStartRecognize
            // 
            this.btnStartRecognize.Image = global::SpeechDetect.Properties.Resources.Record;
            this.btnStartRecognize.Location = new System.Drawing.Point(300, 233);
            this.btnStartRecognize.Name = "btnStartRecognize";
            this.btnStartRecognize.Size = new System.Drawing.Size(95, 96);
            this.btnStartRecognize.TabIndex = 10;
            this.btnStartRecognize.UseVisualStyleBackColor = true;
            this.btnStartRecognize.Click += new System.EventHandler(this.btnStartRecognize_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(311, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nagrywaj";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWord);
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 100);
            this.panel1.TabIndex = 13;
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Location = new System.Drawing.Point(291, 432);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(132, 21);
            this.comboBoxWords.TabIndex = 16;
            this.comboBoxWords.SelectedIndexChanged += new System.EventHandler(this.comboBoxWords_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(287, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wybierz słowo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeechDetect.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(696, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStartRecognize);
            this.Controls.Add(this.btnLoadGrammar);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.btnRandomWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomWord;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button btnLoadGrammar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStartRecognize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxWords;
        private System.Windows.Forms.Label label1;
    }
}

