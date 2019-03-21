namespace WindowsFormsApp_first_try
{
    partial class MDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDB));
            this.label1 = new System.Windows.Forms.Label();
            this.ShowDirectors = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddM = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.AddM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your movie database!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowDirectors
            // 
            this.ShowDirectors.BackColor = System.Drawing.Color.Lavender;
            this.ShowDirectors.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDirectors.Location = new System.Drawing.Point(326, 305);
            this.ShowDirectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDirectors.Name = "ShowDirectors";
            this.ShowDirectors.Size = new System.Drawing.Size(281, 36);
            this.ShowDirectors.TabIndex = 1;
            this.ShowDirectors.Text = "Show directors";
            this.ShowDirectors.UseVisualStyleBackColor = false;
            this.ShowDirectors.Click += new System.EventHandler(this.ShowDirectors_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(326, 92);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(281, 196);
            this.ListBox.TabIndex = 2;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(660, 92);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 196);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddM
            // 
            this.AddM.Controls.Add(this.UpdateButton);
            this.AddM.Controls.Add(this.RemoveButton);
            this.AddM.Controls.Add(this.AddButton);
            this.AddM.Controls.Add(this.textBoxRating);
            this.AddM.Controls.Add(this.textBoxYear);
            this.AddM.Controls.Add(this.textBoxTitle);
            this.AddM.Controls.Add(this.Rating);
            this.AddM.Controls.Add(this.Year);
            this.AddM.Controls.Add(this.Title);
            this.AddM.Location = new System.Drawing.Point(27, 92);
            this.AddM.Name = "AddM";
            this.AddM.Size = new System.Drawing.Size(258, 218);
            this.AddM.TabIndex = 4;
            this.AddM.TabStop = false;
            this.AddM.Text = "Movie";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(160, 169);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(72, 26);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(78, 168);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(72, 26);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 168);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(43, 27);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(79, 101);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 22);
            this.textBoxRating.TabIndex = 6;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(79, 65);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(79, 30);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(15, 101);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(49, 17);
            this.Rating.TabIndex = 2;
            this.Rating.Text = "Rating";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(17, 65);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(38, 17);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(15, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(35, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // MDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 458);
            this.Controls.Add(this.AddM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ShowDirectors);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MDB";
            this.Text = "MDB";
            this.AddM.ResumeLayout(false);
            this.AddM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowDirectors;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox AddM;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}

