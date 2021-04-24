
namespace Play_Button
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.background = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerWords = new System.Windows.Forms.Label();
            this.timerNumber = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(-1, -3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(338, 277);
            this.background.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(107, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 51);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerWords
            // 
            this.timerWords.AutoSize = true;
            this.timerWords.BackColor = System.Drawing.Color.Black;
            this.timerWords.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerWords.ForeColor = System.Drawing.Color.Black;
            this.timerWords.Location = new System.Drawing.Point(43, 162);
            this.timerWords.Name = "timerWords";
            this.timerWords.Size = new System.Drawing.Size(192, 24);
            this.timerWords.TabIndex = 2;
            this.timerWords.Text = "GAME STARTS IN:";
            this.timerWords.Click += new System.EventHandler(this.timerWords_Click);
            // 
            // timerNumber
            // 
            this.timerNumber.BackColor = System.Drawing.Color.Black;
            this.timerNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerNumber.ForeColor = System.Drawing.Color.Black;
            this.timerNumber.Location = new System.Drawing.Point(241, 162);
            this.timerNumber.Name = "timerNumber";
            this.timerNumber.Size = new System.Drawing.Size(24, 23);
            this.timerNumber.TabIndex = 3;
            this.timerNumber.Text = "3";
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.Green;
            this.GO.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GO.Location = new System.Drawing.Point(110, 112);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(106, 38);
            this.GO.TabIndex = 4;
            this.GO.Text = "GO!!!!";
            this.GO.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.timerNumber);
            this.Controls.Add(this.timerWords);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Arcade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label timerWords;
        private System.Windows.Forms.Label timerNumber;
        private System.Windows.Forms.Label GO;
    }
}

