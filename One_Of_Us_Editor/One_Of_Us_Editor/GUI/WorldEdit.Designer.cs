namespace One_Of_Us_Editor
{
    partial class WorldEdit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpawnPosValue = new System.Windows.Forms.NumericUpDown();
            this.SpawnTypeValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_1 = new System.Windows.Forms.CheckedListBox();
            this.Grid_2 = new System.Windows.Forms.CheckedListBox();
            this.Grid_3 = new System.Windows.Forms.CheckedListBox();
            this.Grid_4 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnPosValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnTypeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 576);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Spawn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spawn_POS";
            // 
            // SpawnPosValue
            // 
            this.SpawnPosValue.Location = new System.Drawing.Point(63, 92);
            this.SpawnPosValue.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SpawnPosValue.Name = "SpawnPosValue";
            this.SpawnPosValue.Size = new System.Drawing.Size(120, 20);
            this.SpawnPosValue.TabIndex = 4;
            // 
            // SpawnTypeValue
            // 
            this.SpawnTypeValue.Location = new System.Drawing.Point(63, 157);
            this.SpawnTypeValue.Maximum = new decimal(new int[] {
            1004,
            0,
            0,
            0});
            this.SpawnTypeValue.Name = "SpawnTypeValue";
            this.SpawnTypeValue.Size = new System.Drawing.Size(120, 20);
            this.SpawnTypeValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "SpawnType";
            // 
            // Grid_1
            // 
            this.Grid_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid_1.Enabled = false;
            this.Grid_1.FormattingEnabled = true;
            this.Grid_1.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.Grid_1.Location = new System.Drawing.Point(355, 194);
            this.Grid_1.Name = "Grid_1";
            this.Grid_1.Size = new System.Drawing.Size(21, 64);
            this.Grid_1.TabIndex = 7;
            // 
            // Grid_2
            // 
            this.Grid_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid_2.Enabled = false;
            this.Grid_2.FormattingEnabled = true;
            this.Grid_2.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.Grid_2.Location = new System.Drawing.Point(373, 194);
            this.Grid_2.Name = "Grid_2";
            this.Grid_2.Size = new System.Drawing.Size(21, 64);
            this.Grid_2.TabIndex = 8;
            // 
            // Grid_3
            // 
            this.Grid_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid_3.Enabled = false;
            this.Grid_3.FormattingEnabled = true;
            this.Grid_3.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.Grid_3.Location = new System.Drawing.Point(391, 194);
            this.Grid_3.Name = "Grid_3";
            this.Grid_3.Size = new System.Drawing.Size(21, 64);
            this.Grid_3.TabIndex = 9;
            // 
            // Grid_4
            // 
            this.Grid_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Grid_4.Enabled = false;
            this.Grid_4.FormattingEnabled = true;
            this.Grid_4.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.Grid_4.Location = new System.Drawing.Point(409, 194);
            this.Grid_4.Name = "Grid_4";
            this.Grid_4.Size = new System.Drawing.Size(21, 64);
            this.Grid_4.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // WorldEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Grid_4);
            this.Controls.Add(this.Grid_3);
            this.Controls.Add(this.Grid_2);
            this.Controls.Add(this.Grid_1);
            this.Controls.Add(this.SpawnTypeValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpawnPosValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WorldEdit";
            this.Text = "WorldEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnPosValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnTypeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpawnPosValue;
        private System.Windows.Forms.NumericUpDown SpawnTypeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Grid_1;
        private System.Windows.Forms.CheckedListBox Grid_2;
        private System.Windows.Forms.CheckedListBox Grid_3;
        private System.Windows.Forms.CheckedListBox Grid_4;
        private System.Windows.Forms.Button button4;
    }
}