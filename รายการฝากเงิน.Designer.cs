namespace WindowsFormsApp3
{
    partial class รายการฝากเงิน
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.nbr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(168, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "ฝากเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepPink;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 231);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(149, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "จำนวนเงิน";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 160);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(188, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "รหัสนักศึกษา";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.idbox.Location = new System.Drawing.Point(360, 155);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(341, 53);
            this.idbox.TabIndex = 3;
            this.idbox.TextChanged += new System.EventHandler(this.idbox_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Red;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.Location = new System.Drawing.Point(435, 362);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(170, 74);
            this.save.TabIndex = 5;
            this.save.Text = "ฝาก";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.back.Location = new System.Drawing.Point(26, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 50);
            this.back.TabIndex = 9;
            this.back.Text = "ย้อนกลับ";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // nbr
            // 
            this.nbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nbr.Location = new System.Drawing.Point(360, 228);
            this.nbr.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(341, 49);
            this.nbr.TabIndex = 10;
            // 
            // รายการฝากเงิน
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._48384701_1138804956287997_5291311094906748928_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 636);
            this.Controls.Add(this.nbr);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "รายการฝากเงิน";
            this.Text = "รายการฝากเงิน";
            ((System.ComponentModel.ISupportInitialize)(this.nbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.NumericUpDown nbr;
    }
}