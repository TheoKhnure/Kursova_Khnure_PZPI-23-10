namespace WindowsFormsApp1
{
    partial class Golovna
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nazad = new System.Windows.Forms.Button();
            this.vpered = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.zliy0 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Archiv = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1689, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.photo_2024_04_09_01_51_26_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.nazad);
            this.panel2.Controls.Add(this.vpered);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.zliy0);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1689, 832);
            this.panel2.TabIndex = 1;
            // 
            // nazad
            // 
            this.nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.nazad.FlatAppearance.BorderSize = 2;
            this.nazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.nazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nazad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nazad.Location = new System.Drawing.Point(21, 775);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(164, 57);
            this.nazad.TabIndex = 4;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // vpered
            // 
            this.vpered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpered.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.vpered.FlatAppearance.BorderSize = 2;
            this.vpered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.vpered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.vpered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vpered.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vpered.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vpered.Location = new System.Drawing.Point(316, 775);
            this.vpered.Name = "vpered";
            this.vpered.Size = new System.Drawing.Size(160, 57);
            this.vpered.TabIndex = 3;
            this.vpered.Text = "Вперед";
            this.vpered.UseVisualStyleBackColor = true;
            this.vpered.Click += new System.EventHandler(this.vpered_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 556);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // zliy0
            // 
            this.zliy0.AutoSize = true;
            this.zliy0.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zliy0.ForeColor = System.Drawing.SystemColors.Highlight;
            this.zliy0.Location = new System.Drawing.Point(567, 76);
            this.zliy0.Name = "zliy0";
            this.zliy0.Size = new System.Drawing.Size(353, 41);
            this.zliy0.TabIndex = 1;
            this.zliy0.Text = "Відкрити інформацію";
            this.zliy0.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.Archiv);
            this.panel3.Controls.Add(this.Search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1323, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 832);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(63, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вийти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.vihid_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(63, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "Додати";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.addict_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(63, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "Угрупування";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.group_Click);
            // 
            // Archiv
            // 
            this.Archiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Archiv.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Archiv.FlatAppearance.BorderSize = 2;
            this.Archiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Archiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Archiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Archiv.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Archiv.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Archiv.Location = new System.Drawing.Point(63, 193);
            this.Archiv.Name = "Archiv";
            this.Archiv.Size = new System.Drawing.Size(238, 91);
            this.Archiv.TabIndex = 1;
            this.Archiv.Text = "Архів";
            this.Archiv.UseVisualStyleBackColor = true;
            this.Archiv.Click += new System.EventHandler(this.arhiv_Click);
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Search.FlatAppearance.BorderSize = 2;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Search.Location = new System.Drawing.Point(63, 50);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(238, 91);
            this.Search.TabIndex = 1;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(1224, 763);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(247, 80);
            this.button4.TabIndex = 14;
            this.button4.Text = "Перенести в архів";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Golovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1689, 901);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Golovna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Golovna";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Archiv;
        private System.Windows.Forms.Label zliy0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button vpered;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button button4;
    }
}