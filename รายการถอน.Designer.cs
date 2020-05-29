namespace WindowsFormsApp3
{
    partial class รายการถอน
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
            this.back = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbr = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbr)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.back.Location = new System.Drawing.Point(28, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 50);
            this.back.TabIndex = 4;
            this.back.Text = "ย้อนกลับ";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Crimson;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.ForeColor = System.Drawing.Color.LightGray;
            this.save.Location = new System.Drawing.Point(478, 325);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(170, 74);
            this.save.TabIndex = 3;
            this.save.Text = "ถอน";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlueViolet;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(188, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "รหัสนักศึกษา";
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.idbox.Location = new System.Drawing.Point(410, 152);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(341, 53);
            this.idbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 228);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(149, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "จำนวนเงิน";
            // 
            // nbr
            // 
            this.nbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nbr.Location = new System.Drawing.Point(410, 228);
            this.nbr.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nbr.Name = "nbr";
            this.nbr.Size = new System.Drawing.Size(341, 49);
            this.nbr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(171, 64);
            this.label1.TabIndex = 15;
            this.label1.Text = "ถอนเงิน";
            // 
            // รายการถอน
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._48384701_1138804956287997_5291311094906748928_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbr);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Name = "รายการถอน";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.รายการถอน_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbr;
        private System.Windows.Forms.Label label1;
    }
}