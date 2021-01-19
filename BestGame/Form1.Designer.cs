namespace BestGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Shoot = new System.Windows.Forms.PictureBox();
            this.Relaod = new System.Windows.Forms.PictureBox();
            this.Spin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Away = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relaod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(313, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shooting Game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(769, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reload";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(32, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Spin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(711, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Shoot";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(25, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Away";
            // 
            // Shoot
            // 
            this.Shoot.Image = global::BestGame.Properties.Resources.Shoo;
            this.Shoot.Location = new System.Drawing.Point(685, 342);
            this.Shoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(139, 70);
            this.Shoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoot.TabIndex = 14;
            this.Shoot.TabStop = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click_1);
            // 
            // Relaod
            // 
            this.Relaod.Image = global::BestGame.Properties.Resources.Reloo;
            this.Relaod.Location = new System.Drawing.Point(751, 265);
            this.Relaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Relaod.Name = "Relaod";
            this.Relaod.Size = new System.Drawing.Size(89, 54);
            this.Relaod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Relaod.TabIndex = 13;
            this.Relaod.TabStop = false;
            this.Relaod.Click += new System.EventHandler(this.Relaod_Click_1);
            // 
            // Spin
            // 
            this.Spin.Image = global::BestGame.Properties.Resources.spii;
            this.Spin.Location = new System.Drawing.Point(15, 358);
            this.Spin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(89, 54);
            this.Spin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spin.TabIndex = 11;
            this.Spin.TabStop = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestGame.Properties.Resources.Backlook;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Away
            // 
            this.Away.Image = global::BestGame.Properties.Resources.awoo;
            this.Away.Location = new System.Drawing.Point(15, 265);
            this.Away.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Away.Name = "Away";
            this.Away.Size = new System.Drawing.Size(89, 73);
            this.Away.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Away.TabIndex = 19;
            this.Away.TabStop = false;
            this.Away.Click += new System.EventHandler(this.Away_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BestGame.Properties.Resources.exii;
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 426);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Away);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Relaod);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Shoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relaod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Shoot;
        private System.Windows.Forms.PictureBox Relaod;
        private System.Windows.Forms.PictureBox Spin;
        private System.Windows.Forms.PictureBox Away;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

