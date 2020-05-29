namespace WindowsFormsApp3
{
    partial class Form2
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.save = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.look = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Red;
            pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources._13231;
            pictureBox1.Location = new System.Drawing.Point(473, 416);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(96, 87);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Gold;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.Image = global::WindowsFormsApp3.Properties.Resources._59328187_1126526754220315_1852964954395639808_n;
            this.save.Location = new System.Drawing.Point(282, 189);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 69);
            this.save.TabIndex = 2;
            this.save.Text = "ฝาก";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // logo2
            // 
            this.logo2.AutoSize = true;
            this.logo2.BackColor = System.Drawing.Color.Lime;
            this.logo2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.logo2.ForeColor = System.Drawing.Color.White;
            this.logo2.Location = new System.Drawing.Point(226, 19);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(553, 73);
            this.logo2.TabIndex = 1;
            this.logo2.Text = "ธนาคารเงินคำกำแก้ว";
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.Gold;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.withdraw.Image = global::WindowsFormsApp3.Properties.Resources._59328187_1126526754220315_1852964954395639808_n;
            this.withdraw.Location = new System.Drawing.Point(600, 189);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(158, 69);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "ถอน";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Gold;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.open.Image = global::WindowsFormsApp3.Properties.Resources._59328187_1126526754220315_1852964954395639808_n;
            this.open.Location = new System.Drawing.Point(120, 356);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(211, 62);
            this.open.TabIndex = 4;
            this.open.Text = "เปิดบัญชี";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // look
            // 
            this.look.BackColor = System.Drawing.Color.Gold;
            this.look.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.look.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.look.Image = global::WindowsFormsApp3.Properties.Resources._59328187_1126526754220315_1852964954395639808_n;
            this.look.Location = new System.Drawing.Point(717, 365);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(263, 69);
            this.look.TabIndex = 5;
            this.look.Text = "ดูการเคลือนไหวบัญชี";
            this.look.UseVisualStyleBackColor = false;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._87417402_498199154419312_6915623213212893184_n;
            this.ClientSize = new System.Drawing.Size(1075, 611);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.look);
            this.Controls.Add(this.open);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.save);
            this.Name = "Form2";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label logo2;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button look;
    }
}