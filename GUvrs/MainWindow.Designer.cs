﻿namespace GUvrs
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblPlayerNameText = new System.Windows.Forms.Label();
            this.lblOpponentIDText = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayerNameValue = new System.Windows.Forms.Label();
            this.lblOpponentIDValue = new System.Windows.Forms.Label();
            this.lblPlayerIDValue = new System.Windows.Forms.Label();
            this.lblPlayerIDText = new System.Windows.Forms.Label();
            this.lblOpponentNameValue = new System.Windows.Forms.Label();
            this.lblOpponentNameText = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerNameText
            // 
            this.lblPlayerNameText.AutoSize = true;
            this.lblPlayerNameText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerNameText.Location = new System.Drawing.Point(33, 18);
            this.lblPlayerNameText.Name = "lblPlayerNameText";
            this.lblPlayerNameText.Size = new System.Drawing.Size(91, 14);
            this.lblPlayerNameText.TabIndex = 0;
            this.lblPlayerNameText.Text = "Player Name:";
            // 
            // lblOpponentIDText
            // 
            this.lblOpponentIDText.AutoSize = true;
            this.lblOpponentIDText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpponentIDText.Location = new System.Drawing.Point(31, 98);
            this.lblOpponentIDText.Name = "lblOpponentIDText";
            this.lblOpponentIDText.Size = new System.Drawing.Size(91, 14);
            this.lblOpponentIDText.TabIndex = 1;
            this.lblOpponentIDText.Text = "Opponent ID:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayerNameValue
            // 
            this.lblPlayerNameValue.AutoSize = true;
            this.lblPlayerNameValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerNameValue.Location = new System.Drawing.Point(134, 18);
            this.lblPlayerNameValue.Name = "lblPlayerNameValue";
            this.lblPlayerNameValue.Size = new System.Drawing.Size(70, 14);
            this.lblPlayerNameValue.TabIndex = 4;
            this.lblPlayerNameValue.Text = "000000000";
            // 
            // lblOpponentIDValue
            // 
            this.lblOpponentIDValue.AutoSize = true;
            this.lblOpponentIDValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpponentIDValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblOpponentIDValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOpponentIDValue.Location = new System.Drawing.Point(132, 98);
            this.lblOpponentIDValue.Name = "lblOpponentIDValue";
            this.lblOpponentIDValue.Size = new System.Drawing.Size(70, 14);
            this.lblOpponentIDValue.TabIndex = 5;
            this.lblOpponentIDValue.Text = "000000000";
            this.lblOpponentIDValue.Click += new System.EventHandler(this.lblOpponentIDValue_Click);
            // 
            // lblPlayerIDValue
            // 
            this.lblPlayerIDValue.AutoSize = true;
            this.lblPlayerIDValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayerIDValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerIDValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayerIDValue.Location = new System.Drawing.Point(134, 32);
            this.lblPlayerIDValue.Name = "lblPlayerIDValue";
            this.lblPlayerIDValue.Size = new System.Drawing.Size(70, 14);
            this.lblPlayerIDValue.TabIndex = 7;
            this.lblPlayerIDValue.Text = "000000000";
            this.lblPlayerIDValue.Click += new System.EventHandler(this.lblPlayerIDValue_Click);
            // 
            // lblPlayerIDText
            // 
            this.lblPlayerIDText.AutoSize = true;
            this.lblPlayerIDText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerIDText.Location = new System.Drawing.Point(33, 32);
            this.lblPlayerIDText.Name = "lblPlayerIDText";
            this.lblPlayerIDText.Size = new System.Drawing.Size(77, 14);
            this.lblPlayerIDText.TabIndex = 6;
            this.lblPlayerIDText.Text = "Player ID:";
            // 
            // lblOpponentNameValue
            // 
            this.lblOpponentNameValue.AutoSize = true;
            this.lblOpponentNameValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpponentNameValue.Location = new System.Drawing.Point(132, 84);
            this.lblOpponentNameValue.Name = "lblOpponentNameValue";
            this.lblOpponentNameValue.Size = new System.Drawing.Size(70, 14);
            this.lblOpponentNameValue.TabIndex = 9;
            this.lblOpponentNameValue.Text = "000000000";
            // 
            // lblOpponentNameText
            // 
            this.lblOpponentNameText.AutoSize = true;
            this.lblOpponentNameText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpponentNameText.Location = new System.Drawing.Point(31, 84);
            this.lblOpponentNameText.Name = "lblOpponentNameText";
            this.lblOpponentNameText.Size = new System.Drawing.Size(105, 14);
            this.lblOpponentNameText.TabIndex = 8;
            this.lblOpponentNameText.Text = "Opponent Name:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.Location = new System.Drawing.Point(31, 138);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(198, 45);
            this.lblWarning.TabIndex = 11;
            this.lblWarning.Text = "Warning: This is a BETA edition. \r\nIt may be subject to errors, or issues. \r\nPlea" +
    "se report any you find to github.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblOpponentNameValue);
            this.Controls.Add(this.lblOpponentNameText);
            this.Controls.Add(this.lblPlayerIDValue);
            this.Controls.Add(this.lblPlayerIDText);
            this.Controls.Add(this.lblOpponentIDValue);
            this.Controls.Add(this.lblPlayerNameValue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOpponentIDText);
            this.Controls.Add(this.lblPlayerNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GU versus - BETA 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPlayerNameText;
        private Label lblOpponentIDText;
        private Button btnReset;
        private Label lblPlayerNameValue;
        private Label lblOpponentIDValue;
        private Label lblPlayerIDValue;
        private Label lblPlayerIDText;
        private Label lblOpponentNameValue;
        private Label lblOpponentNameText;
        private Label lblWarning;
    }
}