namespace HangmanGame
{
    partial class HangmanForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HangmanForm_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "finish";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // scoreboardListBox
            // 
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.ItemHeight = 16;
            this.scoreboardListBox.Location = new System.Drawing.Point(255, 1);
            this.scoreboardListBox.Name = "scoreboardListBox";
            this.scoreboardListBox.Size = new System.Drawing.Size(120, 84);
            this.scoreboardListBox.TabIndex = 3;
            this.scoreboardListBox.SelectedIndexChanged += new System.EventHandler(this.scoreboardListBox_SelectedIndexChanged);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(452, 89);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(70, 16);
            this.wordLabel.TabIndex = 4;
            this.wordLabel.Text = "wordLabel";
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Location = new System.Drawing.Point(170, 98);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(44, 16);
            this.incorrectLabel.TabIndex = 5;
            this.incorrectLabel.Text = "label1";
            // 
            // HangmanForm
            // 
            this.ClientSize = new System.Drawing.Size(641, 381);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.scoreboardListBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Name = "HangmanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label wordlength;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSubmitLetter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox scoreboardListBox;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label incorrectLabel;
    }
}

