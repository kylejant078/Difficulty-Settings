
namespace Difficulty_Settings
{
    partial class DifficultySettings
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
            this.difficultySelect = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // difficultySelect
            // 
            this.difficultySelect.AutoSize = true;
            this.difficultySelect.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultySelect.ForeColor = System.Drawing.Color.White;
            this.difficultySelect.Location = new System.Drawing.Point(184, 140);
            this.difficultySelect.Name = "difficultySelect";
            this.difficultySelect.Size = new System.Drawing.Size(260, 24);
            this.difficultySelect.TabIndex = 1;
            this.difficultySelect.Text = "Select Your Difficulty Level:";
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(115, 190);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(104, 35);
            this.easyButton.TabIndex = 2;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.White;
            this.hardButton.Location = new System.Drawing.Point(390, 190);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(104, 35);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.White;
            this.mediumButton.Location = new System.Drawing.Point(253, 190);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(104, 35);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.beginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.beginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.White;
            this.beginButton.Location = new System.Drawing.Point(188, 270);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(225, 35);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(341, 59);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(139, 29);
            this.nameInput.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel.Location = new System.Drawing.Point(294, 388);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 21);
            this.outputLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Your Name Hero:";
            // 
            // DifficultySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultySelect);
            this.Name = "DifficultySettings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroName;
        private System.Windows.Forms.Label difficultySelect;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
    }
}

