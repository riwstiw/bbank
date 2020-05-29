namespace WindowsFormsApp3
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
            this.login = new System.Windows.Forms.Button();
            this.logo1 = new System.Windows.Forms.Label();
            this.us = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.login.Location = new System.Drawing.Point(396, 476);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(291, 82);
            this.login.TabIndex = 1;
            this.login.Text = "เข้าสู่หน้าหลัก";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logo1
            // 
            this.logo1.AutoSize = true;
            this.logo1.BackColor = System.Drawing.Color.Transparent;
            this.logo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.logo1.ForeColor = System.Drawing.Color.DarkRed;
            this.logo1.Location = new System.Drawing.Point(161, 58);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(816, 108);
            this.logo1.TabIndex = 2;
            this.logo1.Text = "ธนาคารเงินคำกำแก้ว";
            this.logo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // us
            // 
            this.us.BackColor = System.Drawing.SystemColors.Menu;
            this.us.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.us.Location = new System.Drawing.Point(352, 258);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(360, 44);
            this.us.TabIndex = 3;
            // 
            // pw
            // 
            this.pw.BackColor = System.Drawing.SystemColors.Menu;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pw.Location = new System.Drawing.Point(352, 349);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(360, 44);
            this.pw.TabIndex = 4;
            this.pw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(482, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(482, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._97486081_264127681377522_6459552412850978816_n;
            this.ClientSize = new System.Drawing.Size(1120, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.us);
            this.Controls.Add(this.logo1);
            this.Controls.Add(this.login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label logo1;
        private System.Windows.Forms.TextBox us;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

