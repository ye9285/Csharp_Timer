namespace JCSCTimer
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
            this.num_h = new System.Windows.Forms.NumericUpDown();
            this.num_m = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num_m_yellow = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_m_red = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.num_s = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.num_s_yellow = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.num_s_red = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s_red)).BeginInit();
            this.SuspendLayout();
            // 
            // num_h
            // 
            this.num_h.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_h.Location = new System.Drawing.Point(56, 38);
            this.num_h.Name = "num_h";
            this.num_h.Size = new System.Drawing.Size(60, 38);
            this.num_h.TabIndex = 0;
            // 
            // num_m
            // 
            this.num_m.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_m.Location = new System.Drawing.Point(172, 38);
            this.num_m.Name = "num_m";
            this.num_m.Size = new System.Drawing.Size(60, 38);
            this.num_m.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(238, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "分";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_OK.Location = new System.Drawing.Point(78, 323);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(117, 43);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cancel.Location = new System.Drawing.Point(288, 323);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(121, 43);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "画面サイズ";
            // 
            // cmb_size
            // 
            this.cmb_size.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Items.AddRange(new object[] {
            "1920×1080",
            "1680×1050",
            "1600×900",
            "1440×900",
            "1366×768",
            "1280×1024",
            "1024×768",
            "800×600"});
            this.cmb_size.Location = new System.Drawing.Point(136, 236);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(249, 33);
            this.cmb_size.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(92, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "残り";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(238, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "分";
            // 
            // num_m_yellow
            // 
            this.num_m_yellow.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_m_yellow.Location = new System.Drawing.Point(172, 92);
            this.num_m_yellow.Name = "num_m_yellow";
            this.num_m_yellow.Size = new System.Drawing.Size(60, 38);
            this.num_m_yellow.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(238, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "分";
            // 
            // num_m_red
            // 
            this.num_m_red.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_m_red.Location = new System.Drawing.Point(172, 149);
            this.num_m_red.Name = "num_m_red";
            this.num_m_red.Size = new System.Drawing.Size(60, 38);
            this.num_m_red.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(92, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "残り";
            // 
            // num_s
            // 
            this.num_s.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_s.Location = new System.Drawing.Point(288, 38);
            this.num_s.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_s.Name = "num_s";
            this.num_s.Size = new System.Drawing.Size(60, 38);
            this.num_s.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(354, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "秒";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(354, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "秒で黄色";
            // 
            // num_s_yellow
            // 
            this.num_s_yellow.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_s_yellow.Location = new System.Drawing.Point(288, 92);
            this.num_s_yellow.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_s_yellow.Name = "num_s_yellow";
            this.num_s_yellow.Size = new System.Drawing.Size(60, 38);
            this.num_s_yellow.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(354, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "秒で赤";
            // 
            // num_s_red
            // 
            this.num_s_red.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num_s_red.Location = new System.Drawing.Point(288, 149);
            this.num_s_red.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_s_red.Name = "num_s_red";
            this.num_s_red.Size = new System.Drawing.Size(60, 38);
            this.num_s_red.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 205);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "タイマー";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 418);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.num_s_red);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_s_yellow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_m_red);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_m_yellow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_s);
            this.Controls.Add(this.num_m);
            this.Controls.Add(this.num_h);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_m_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_s_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_h;
        private System.Windows.Forms.NumericUpDown num_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_m_yellow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_m_red;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_s_yellow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_s_red;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}