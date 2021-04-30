
namespace Equation_Solver
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
            this.denklem_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kok1 = new System.Windows.Forms.TextBox();
            this.kok2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toplami = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carpimi = new System.Windows.Forms.TextBox();
            this.disk = new System.Windows.Forms.Label();
            this.disk_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // denklem_txt
            // 
            this.denklem_txt.Location = new System.Drawing.Point(64, 6);
            this.denklem_txt.Name = "denklem_txt";
            this.denklem_txt.Size = new System.Drawing.Size(149, 20);
            this.denklem_txt.TabIndex = 0;
            this.denklem_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çöz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kok1
            // 
            this.kok1.Location = new System.Drawing.Point(376, 11);
            this.kok1.Name = "kok1";
            this.kok1.ReadOnly = true;
            this.kok1.Size = new System.Drawing.Size(146, 20);
            this.kok1.TabIndex = 2;
            // 
            // kok2
            // 
            this.kok2.Location = new System.Drawing.Point(376, 51);
            this.kok2.Name = "kok2";
            this.kok2.ReadOnly = true;
            this.kok2.Size = new System.Drawing.Size(146, 20);
            this.kok2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kok 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kok 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "K\'ler Toplamı";
            // 
            // toplami
            // 
            this.toplami.Location = new System.Drawing.Point(376, 91);
            this.toplami.Name = "toplami";
            this.toplami.ReadOnly = true;
            this.toplami.Size = new System.Drawing.Size(146, 20);
            this.toplami.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "K\'ler Çarpımı";
            // 
            // carpimi
            // 
            this.carpimi.Location = new System.Drawing.Point(376, 131);
            this.carpimi.Name = "carpimi";
            this.carpimi.ReadOnly = true;
            this.carpimi.Size = new System.Drawing.Size(146, 20);
            this.carpimi.TabIndex = 9;
            // 
            // disk
            // 
            this.disk.AutoSize = true;
            this.disk.Location = new System.Drawing.Point(290, 178);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(80, 13);
            this.disk.TabIndex = 10;
            this.disk.Text = "Δ( Diskriminant)";
            // 
            // disk_txt
            // 
            this.disk_txt.Location = new System.Drawing.Point(376, 171);
            this.disk_txt.Name = "disk_txt";
            this.disk_txt.ReadOnly = true;
            this.disk_txt.Size = new System.Drawing.Size(146, 20);
            this.disk_txt.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Örnek";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 188);
            this.button3.TabIndex = 13;
            this.button3.Text = "Yardım ?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(3, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Denklem->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 202);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.disk_txt);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.carpimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toplami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kok2);
            this.Controls.Add(this.kok1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.denklem_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Denklem Çöz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox denklem_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kok1;
        private System.Windows.Forms.TextBox kok2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toplami;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carpimi;
        private System.Windows.Forms.Label disk;
        private System.Windows.Forms.TextBox disk_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

