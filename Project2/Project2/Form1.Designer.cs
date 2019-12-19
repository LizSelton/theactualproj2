namespace Project2
{
    partial class Project2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project2));
            this.presidentialLabel = new System.Windows.Forms.Label();
            this.labelInfoOption = new System.Windows.Forms.Label();
            this.ffCatListBoxValue = new System.Windows.Forms.ListBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.funFactLabel = new System.Windows.Forms.Label();
            this.ffSubCatLabel = new System.Windows.Forms.Label();
            this.ffSubCatValue = new System.Windows.Forms.ListBox();
            this.previewPresButton = new System.Windows.Forms.Button();
            this.writePresButton = new System.Windows.Forms.Button();
            this.presListBoxValue = new System.Windows.Forms.ListBox();
            this.presComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChoosePrez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // presidentialLabel
            // 
            this.presidentialLabel.AutoSize = true;
            this.presidentialLabel.BackColor = System.Drawing.Color.Transparent;
            this.presidentialLabel.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presidentialLabel.ForeColor = System.Drawing.Color.White;
            this.presidentialLabel.Location = new System.Drawing.Point(497, -6);
            this.presidentialLabel.Name = "presidentialLabel";
            this.presidentialLabel.Size = new System.Drawing.Size(578, 147);
            this.presidentialLabel.TabIndex = 1;
            this.presidentialLabel.Text = "Presidential";
            // 
            // labelInfoOption
            // 
            this.labelInfoOption.AutoSize = true;
            this.labelInfoOption.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoOption.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoOption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelInfoOption.Location = new System.Drawing.Point(745, 125);
            this.labelInfoOption.Name = "labelInfoOption";
            this.labelInfoOption.Size = new System.Drawing.Size(208, 28);
            this.labelInfoOption.TabIndex = 3;
            this.labelInfoOption.Text = "Select a Fun Fact(s):";
            // 
            // ffCatListBoxValue
            // 
            this.ffCatListBoxValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffCatListBoxValue.ForeColor = System.Drawing.Color.DarkRed;
            this.ffCatListBoxValue.FormattingEnabled = true;
            this.ffCatListBoxValue.ItemHeight = 22;
            this.ffCatListBoxValue.Location = new System.Drawing.Point(750, 166);
            this.ffCatListBoxValue.Name = "ffCatListBoxValue";
            this.ffCatListBoxValue.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ffCatListBoxValue.Size = new System.Drawing.Size(181, 136);
            this.ffCatListBoxValue.TabIndex = 4;
            // 
            // previewButton
            // 
            this.previewButton.BackColor = System.Drawing.Color.DarkRed;
            this.previewButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewButton.ForeColor = System.Drawing.Color.White;
            this.previewButton.Location = new System.Drawing.Point(970, 166);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(261, 50);
            this.previewButton.TabIndex = 5;
            this.previewButton.Text = "Preview Fun Fact(s)";
            this.previewButton.UseVisualStyleBackColor = false;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.Color.White;
            this.writeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.writeButton.Location = new System.Drawing.Point(970, 228);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(261, 42);
            this.writeButton.TabIndex = 6;
            this.writeButton.Text = "Write Fun Fact(s) to File";
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // funFactLabel
            // 
            this.funFactLabel.AutoSize = true;
            this.funFactLabel.BackColor = System.Drawing.Color.Transparent;
            this.funFactLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funFactLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.funFactLabel.Location = new System.Drawing.Point(419, 339);
            this.funFactLabel.Name = "funFactLabel";
            this.funFactLabel.Size = new System.Drawing.Size(316, 28);
            this.funFactLabel.TabIndex = 7;
            this.funFactLabel.Text = "Choose a Presidential Fun Fact:";
            // 
            // ffSubCatLabel
            // 
            this.ffSubCatLabel.AutoSize = true;
            this.ffSubCatLabel.BackColor = System.Drawing.Color.Transparent;
            this.ffSubCatLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffSubCatLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ffSubCatLabel.Location = new System.Drawing.Point(805, 339);
            this.ffSubCatLabel.Name = "ffSubCatLabel";
            this.ffSubCatLabel.Size = new System.Drawing.Size(340, 28);
            this.ffSubCatLabel.TabIndex = 10;
            this.ffSubCatLabel.Text = "Select a Fun Fact(s) Sub-Category:";
            // 
            // ffSubCatValue
            // 
            this.ffSubCatValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffSubCatValue.ForeColor = System.Drawing.Color.DarkRed;
            this.ffSubCatValue.FormattingEnabled = true;
            this.ffSubCatValue.ItemHeight = 22;
            this.ffSubCatValue.Location = new System.Drawing.Point(808, 382);
            this.ffSubCatValue.Name = "ffSubCatValue";
            this.ffSubCatValue.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ffSubCatValue.Size = new System.Drawing.Size(335, 92);
            this.ffSubCatValue.TabIndex = 11;
            // 
            // previewPresButton
            // 
            this.previewPresButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.previewPresButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewPresButton.ForeColor = System.Drawing.Color.White;
            this.previewPresButton.Location = new System.Drawing.Point(424, 424);
            this.previewPresButton.Name = "previewPresButton";
            this.previewPresButton.Size = new System.Drawing.Size(291, 50);
            this.previewPresButton.TabIndex = 12;
            this.previewPresButton.Text = "Preview President(s)";
            this.previewPresButton.UseVisualStyleBackColor = false;
            this.previewPresButton.Click += new System.EventHandler(this.previewPresButton_Click);
            // 
            // writePresButton
            // 
            this.writePresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writePresButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.writePresButton.Location = new System.Drawing.Point(424, 488);
            this.writePresButton.Name = "writePresButton";
            this.writePresButton.Size = new System.Drawing.Size(291, 42);
            this.writePresButton.TabIndex = 13;
            this.writePresButton.Text = "Write President(s) to File";
            this.writePresButton.UseVisualStyleBackColor = true;
            this.writePresButton.Click += new System.EventHandler(this.writePresButton_Click);
            // 
            // presListBoxValue
            // 
            this.presListBoxValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presListBoxValue.ForeColor = System.Drawing.Color.DarkRed;
            this.presListBoxValue.FormattingEnabled = true;
            this.presListBoxValue.ItemHeight = 22;
            this.presListBoxValue.Location = new System.Drawing.Point(524, 166);
            this.presListBoxValue.Name = "presListBoxValue";
            this.presListBoxValue.Size = new System.Drawing.Size(191, 136);
            this.presListBoxValue.TabIndex = 14;
            // 
            // presComboBox
            // 
            this.presComboBox.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presComboBox.ForeColor = System.Drawing.Color.DarkRed;
            this.presComboBox.FormattingEnabled = true;
            this.presComboBox.Location = new System.Drawing.Point(424, 379);
            this.presComboBox.Name = "presComboBox";
            this.presComboBox.Size = new System.Drawing.Size(311, 30);
            this.presComboBox.TabIndex = 15;
            this.presComboBox.SelectedIndexChanged += new System.EventHandler(this.presComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(1054, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "FUN FACTS";
            // 
            // labelChoosePrez
            // 
            this.labelChoosePrez.AutoSize = true;
            this.labelChoosePrez.BackColor = System.Drawing.Color.Transparent;
            this.labelChoosePrez.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosePrez.ForeColor = System.Drawing.Color.DarkRed;
            this.labelChoosePrez.Location = new System.Drawing.Point(519, 125);
            this.labelChoosePrez.Name = "labelChoosePrez";
            this.labelChoosePrez.Size = new System.Drawing.Size(196, 28);
            this.labelChoosePrez.TabIndex = 17;
            this.labelChoosePrez.Text = "Choose a President:";
            // 
            // Project2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 573);
            this.Controls.Add(this.labelChoosePrez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presComboBox);
            this.Controls.Add(this.presListBoxValue);
            this.Controls.Add(this.writePresButton);
            this.Controls.Add(this.previewPresButton);
            this.Controls.Add(this.ffSubCatValue);
            this.Controls.Add(this.ffSubCatLabel);
            this.Controls.Add(this.funFactLabel);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.ffCatListBoxValue);
            this.Controls.Add(this.labelInfoOption);
            this.Controls.Add(this.presidentialLabel);
            this.DoubleBuffered = true;
            this.Name = "Project2";
            this.Text = "Project 2";
            this.Load += new System.EventHandler(this.Project2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label presidentialLabel;
        private System.Windows.Forms.Label labelInfoOption;
        private System.Windows.Forms.ListBox ffCatListBoxValue;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Label funFactLabel;
        private System.Windows.Forms.Label ffSubCatLabel;
        private System.Windows.Forms.ListBox ffSubCatValue;
        private System.Windows.Forms.Button previewPresButton;
        private System.Windows.Forms.Button writePresButton;
        private System.Windows.Forms.ListBox presListBoxValue;
        private System.Windows.Forms.ComboBox presComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChoosePrez;
    }
}

