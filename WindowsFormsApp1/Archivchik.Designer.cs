namespace WindowsFormsApp1
{
    partial class Archivchik
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
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vpered = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1751, 100);
            this.panel1.TabIndex = 0;
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
            this.Search.Location = new System.Drawing.Point(27, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(157, 68);
            this.Search.TabIndex = 4;
            this.Search.Text = "Назад";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(783, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Архів";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.vpered);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.nazad);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 701);
            this.panel2.TabIndex = 0;
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
            this.vpered.Location = new System.Drawing.Point(294, 595);
            this.vpered.Name = "vpered";
            this.vpered.Size = new System.Drawing.Size(160, 57);
            this.vpered.TabIndex = 14;
            this.vpered.Text = "Вперед";
            this.vpered.UseVisualStyleBackColor = true;
            this.vpered.Click += new System.EventHandler(this.vpered_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(1354, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 132);
            this.button2.TabIndex = 13;
            this.button2.Text = "Перенести з архіву";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.nazad.Location = new System.Drawing.Point(12, 595);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(160, 57);
            this.nazad.TabIndex = 11;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(502, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Відкрити інформіцію";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 801);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Archiv";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button vpered;
    }
}