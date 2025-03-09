namespace WindowsFormsApp1
{
    partial class FoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuy1 = new System.Windows.Forms.Button();
            this.btnBuy2 = new System.Windows.Forms.Button();
            this.btnBuy3 = new System.Windows.Forms.Button();
            this.btnBuy4 = new System.Windows.Forms.Button();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lblPrice4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 743);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuy1
            // 
            this.btnBuy1.Location = new System.Drawing.Point(584, 313);
            this.btnBuy1.Name = "btnBuy1";
            this.btnBuy1.Size = new System.Drawing.Size(75, 23);
            this.btnBuy1.TabIndex = 1;
            this.btnBuy1.Text = "BUY";
            this.btnBuy1.UseVisualStyleBackColor = true;
            this.btnBuy1.Click += new System.EventHandler(this.btnBuy1_Click_1);
            // 
            // btnBuy2
            // 
            this.btnBuy2.Location = new System.Drawing.Point(1135, 313);
            this.btnBuy2.Name = "btnBuy2";
            this.btnBuy2.Size = new System.Drawing.Size(75, 23);
            this.btnBuy2.TabIndex = 2;
            this.btnBuy2.Text = "BUY";
            this.btnBuy2.UseVisualStyleBackColor = true;
            this.btnBuy2.Click += new System.EventHandler(this.btnBuy2_Click_1);
            // 
            // btnBuy3
            // 
            this.btnBuy3.Location = new System.Drawing.Point(584, 655);
            this.btnBuy3.Name = "btnBuy3";
            this.btnBuy3.Size = new System.Drawing.Size(75, 23);
            this.btnBuy3.TabIndex = 3;
            this.btnBuy3.Text = "BUY";
            this.btnBuy3.UseVisualStyleBackColor = true;
            this.btnBuy3.Click += new System.EventHandler(this.btnBuy3_Click_1);
            // 
            // btnBuy4
            // 
            this.btnBuy4.Location = new System.Drawing.Point(1135, 655);
            this.btnBuy4.Name = "btnBuy4";
            this.btnBuy4.Size = new System.Drawing.Size(75, 23);
            this.btnBuy4.TabIndex = 4;
            this.btnBuy4.Text = "BUY";
            this.btnBuy4.UseVisualStyleBackColor = true;
            this.btnBuy4.Click += new System.EventHandler(this.btnBuy4_Click_1);
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.ForeColor = System.Drawing.Color.Black;
            this.lblPrice1.Location = new System.Drawing.Point(239, 28);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(84, 29);
            this.lblPrice1.TabIndex = 5;
            this.lblPrice1.Text = "$1,000";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(785, 28);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(65, 29);
            this.lblPrice2.TabIndex = 6;
            this.lblPrice2.Text = "$900";
            // 
            // lblPrice3
            // 
            this.lblPrice3.AutoSize = true;
            this.lblPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice3.Location = new System.Drawing.Point(239, 389);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(65, 29);
            this.lblPrice3.TabIndex = 7;
            this.lblPrice3.Text = "$750";
            // 
            // lblPrice4
            // 
            this.lblPrice4.AutoSize = true;
            this.lblPrice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice4.Location = new System.Drawing.Point(785, 389);
            this.lblPrice4.Name = "lblPrice4";
            this.lblPrice4.Size = new System.Drawing.Size(65, 29);
            this.lblPrice4.TabIndex = 8;
            this.lblPrice4.Text = "$600";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 742);
            this.Controls.Add(this.lblPrice4);
            this.Controls.Add(this.lblPrice3);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.btnBuy4);
            this.Controls.Add(this.btnBuy3);
            this.Controls.Add(this.btnBuy2);
            this.Controls.Add(this.btnBuy1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuy1;
        private System.Windows.Forms.Button btnBuy2;
        private System.Windows.Forms.Button btnBuy3;
        private System.Windows.Forms.Button btnBuy4;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Label lblPrice4;
    }
}