namespace Алгоритм_Коха_Жао
{
    partial class Algorithm_Koha_Zao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Algorithm_Koha_Zao));
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.modifPictureBox = new System.Windows.Forms.PictureBox();
            this.embedButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.keyBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Componenta1 = new System.Windows.Forms.ComboBox();
            this.coeffDifference1 = new System.Windows.Forms.ComboBox();
            this.SizeOfBlocks1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.keyBox2 = new System.Windows.Forms.TextBox();
            this.coeffDifference2 = new System.Windows.Forms.ComboBox();
            this.SizeOfBlocks2 = new System.Windows.Forms.ComboBox();
            this.Componenta2 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OriginalPictureBox.BackgroundImage")));
            this.OriginalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OriginalPictureBox.Location = new System.Drawing.Point(12, 32);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(598, 545);
            this.OriginalPictureBox.TabIndex = 1;
            this.OriginalPictureBox.TabStop = false;
            this.OriginalPictureBox.Click += new System.EventHandler(this.OriginalPictureBox_Click);
            // 
            // pathBox
            // 
            this.pathBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBox.Location = new System.Drawing.Point(145, 25);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pathBox.Size = new System.Drawing.Size(366, 56);
            this.pathBox.TabIndex = 2;
            this.pathBox.WordWrap = false;
            // 
            // modifPictureBox
            // 
            this.modifPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.modifPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifPictureBox.BackgroundImage")));
            this.modifPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modifPictureBox.Location = new System.Drawing.Point(634, 31);
            this.modifPictureBox.Name = "modifPictureBox";
            this.modifPictureBox.Size = new System.Drawing.Size(603, 546);
            this.modifPictureBox.TabIndex = 3;
            this.modifPictureBox.TabStop = false;
            this.modifPictureBox.Click += new System.EventHandler(this.modifPictureBox_Click);
            // 
            // embedButton
            // 
            this.embedButton.BackColor = System.Drawing.Color.PaleGreen;
            this.embedButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.embedButton.Enabled = false;
            this.embedButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.embedButton.Location = new System.Drawing.Point(441, 196);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(170, 59);
            this.embedButton.TabIndex = 4;
            this.embedButton.Text = "Hide message";
            this.embedButton.UseVisualStyleBackColor = false;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.BackColor = System.Drawing.Color.PaleGreen;
            this.extractButton.Enabled = false;
            this.extractButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extractButton.Location = new System.Drawing.Point(398, 195);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(191, 59);
            this.extractButton.TabIndex = 5;
            this.extractButton.Text = "Extract message";
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(240, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(730, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image with built-in digital watermark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path to file with";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = " text message:";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Gray;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseButton.Location = new System.Drawing.Point(517, 28);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(91, 40);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.keyBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Componenta1);
            this.panel1.Controls.Add(this.coeffDifference1);
            this.panel1.Controls.Add(this.SizeOfBlocks1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pathBox);
            this.panel1.Controls.Add(this.embedButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-1, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 375);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(95, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Key for extraction:";
            // 
            // keyBox1
            // 
            this.keyBox1.Location = new System.Drawing.Point(76, 232);
            this.keyBox1.Multiline = true;
            this.keyBox1.Name = "keyBox1";
            this.keyBox1.ReadOnly = true;
            this.keyBox1.Size = new System.Drawing.Size(189, 23);
            this.keyBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(374, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Size of blocks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(61, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "P (Difference of the coefficients):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(83, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Сomponent to embed:";
            // 
            // Componenta1
            // 
            this.Componenta1.FormattingEnabled = true;
            this.Componenta1.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green"});
            this.Componenta1.Location = new System.Drawing.Point(110, 114);
            this.Componenta1.Name = "Componenta1";
            this.Componenta1.Size = new System.Drawing.Size(129, 24);
            this.Componenta1.TabIndex = 13;
            // 
            // coeffDifference1
            // 
            this.coeffDifference1.FormattingEnabled = true;
            this.coeffDifference1.Items.AddRange(new object[] {
            "10",
            "25",
            "40",
            "55",
            "70",
            "85",
            "100",
            "200"});
            this.coeffDifference1.Location = new System.Drawing.Point(110, 172);
            this.coeffDifference1.Name = "coeffDifference1";
            this.coeffDifference1.Size = new System.Drawing.Size(129, 24);
            this.coeffDifference1.TabIndex = 12;
            // 
            // SizeOfBlocks1
            // 
            this.SizeOfBlocks1.FormattingEnabled = true;
            this.SizeOfBlocks1.Items.AddRange(new object[] {
            "2x2",
            "4x4",
            "8x8"});
            this.SizeOfBlocks1.Location = new System.Drawing.Point(373, 114);
            this.SizeOfBlocks1.Name = "SizeOfBlocks1";
            this.SizeOfBlocks1.Size = new System.Drawing.Size(129, 24);
            this.SizeOfBlocks1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.keyBox2);
            this.panel2.Controls.Add(this.coeffDifference2);
            this.panel2.Controls.Add(this.SizeOfBlocks2);
            this.panel2.Controls.Add(this.Componenta2);
            this.panel2.Controls.Add(this.extractButton);
            this.panel2.Location = new System.Drawing.Point(625, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 375);
            this.panel2.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(70, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Key for extraction:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(332, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 22);
            this.label12.TabIndex = 26;
            this.label12.Text = "Size of blocks:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(20, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "P (Difference of the coefficients):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(61, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Component to embed:";
            // 
            // keyBox2
            // 
            this.keyBox2.Location = new System.Drawing.Point(54, 231);
            this.keyBox2.Name = "keyBox2";
            this.keyBox2.Size = new System.Drawing.Size(189, 22);
            this.keyBox2.TabIndex = 23;
            // 
            // coeffDifference2
            // 
            this.coeffDifference2.FormattingEnabled = true;
            this.coeffDifference2.Items.AddRange(new object[] {
            "10",
            "25",
            "40",
            "55",
            "70",
            "85",
            "100"});
            this.coeffDifference2.Location = new System.Drawing.Point(84, 171);
            this.coeffDifference2.Name = "coeffDifference2";
            this.coeffDifference2.Size = new System.Drawing.Size(128, 24);
            this.coeffDifference2.TabIndex = 22;
            // 
            // SizeOfBlocks2
            // 
            this.SizeOfBlocks2.FormattingEnabled = true;
            this.SizeOfBlocks2.Items.AddRange(new object[] {
            "2x2",
            "4x4",
            "8x8"});
            this.SizeOfBlocks2.Location = new System.Drawing.Point(331, 113);
            this.SizeOfBlocks2.Name = "SizeOfBlocks2";
            this.SizeOfBlocks2.Size = new System.Drawing.Size(129, 24);
            this.SizeOfBlocks2.TabIndex = 21;
            // 
            // Componenta2
            // 
            this.Componenta2.FormattingEnabled = true;
            this.Componenta2.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green"});
            this.Componenta2.Location = new System.Drawing.Point(83, 113);
            this.Componenta2.Name = "Componenta2";
            this.Componenta2.Size = new System.Drawing.Size(129, 24);
            this.Componenta2.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(1292, 614);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 59);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save modified image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(1292, 736);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(191, 59);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1325, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Information:";
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(1252, 57);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(273, 512);
            this.infoBox.TabIndex = 16;
            this.infoBox.Text = "";
            // 
            // Algorithm_Koha_Zao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.modifPictureBox);
            this.Controls.Add(this.OriginalPictureBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Algorithm_Koha_Zao";
            this.ShowIcon = false;
            this.Text = "AlgorithmKohaZao";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.PictureBox modifPictureBox;
        private System.Windows.Forms.Button embedButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.ComboBox SizeOfBlocks1;
        private System.Windows.Forms.ComboBox coeffDifference1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Componenta1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox keyBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox keyBox2;
        private System.Windows.Forms.ComboBox coeffDifference2;
        private System.Windows.Forms.ComboBox SizeOfBlocks2;
        private System.Windows.Forms.ComboBox Componenta2;
    }
}

