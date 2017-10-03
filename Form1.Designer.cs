namespace ChuongTrinhXamXamXiDu
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.bCong = new System.Windows.Forms.Button();
            this.bTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(23, 56);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 0;
            this.a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(161, 56);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 1;
            // 
            // bCong
            // 
            this.bCong.Location = new System.Drawing.Point(48, 197);
            this.bCong.Name = "bCong";
            this.bCong.Size = new System.Drawing.Size(75, 23);
            this.bCong.TabIndex = 2;
            this.bCong.Text = "Cộng";
            this.bCong.UseVisualStyleBackColor = true;
            this.bCong.Click += new System.EventHandler(this.bCong_Click);
            // 
            // bTru
            // 
            this.bTru.Location = new System.Drawing.Point(161, 197);
            this.bTru.Name = "bTru";
            this.bTru.Size = new System.Drawing.Size(75, 23);
            this.bTru.TabIndex = 3;
            this.bTru.Text = "Trừ";
            this.bTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bTru);
            this.Controls.Add(this.bCong);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "ChuongTrinhXamXamXiDu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Button bCong;
        private System.Windows.Forms.Button bTru;
    }
}

