using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCSCTimer
{
    public partial class Form1 : Form
    {
        int remaining;
        bool start_flg = false;


        public Form1()
        {
            InitializeComponent();

            //初期設定　5分
            time.h = 0;
            time.m = 5;
            time.s = 0;
            time.yellow_m = 0;
            time.yellow_s = 0;
            time.red_m = 0;
            time.red_s = 0;

            time.sec = 300;
            remaining = time.sec;   //残り時間

            //初期設定　画面サイズ1920×1080
            size.w = 1920;
            size.h = 1080;

            size.form_w = size.w;
            size.form_h = (int)(size.h * 0.05);

            size.bar_w = size.w - 250;
            size.bar_h = (int)(size.h * 0.03);
            size.bar_location = new Point(235, 10);

            size.label_w = 165;
            size.label_h = 40;
            size.label_font = new Font("Yu Gothic UI", 26, FontStyle.Bold);

            size.button_w = 45;
            size.button_h = 45;
            size.button_font = new Font("Yu Gothic UI", 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = size.form_w;
            this.Height = size.form_h; 

            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.ForeColor = Color.Blue;
            progressBar1.Width = size.bar_w;
            progressBar1.Height = size.bar_h;
            progressBar1.Location = size.bar_location;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = time.sec;
            progressBar1.Value = time.sec;

            label1.Width = size.label_w;
            label1.Height = size.label_h;
            label1.Font = size.label_font;
            label1.Text = "00:05:00";

            button1.Width = size.button_w;
            button1.Height = size.button_h;
            button1.Font = size.button_font;
            button1.Text = "▶";

            //1000ミリ秒（＝1秒）ごとにタイマーのTickメソッドを実行せよ、という意味
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            if(start_flg)
            {
                start_flg = false;
                button1.Text = "▶";
                timer1.Enabled = false;
            }
            else
            {
                start_flg = true;
                button1.Text = "■";
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remaining--;

            if (remaining <= (time.yellow_m * 60 + time.yellow_s))
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (remaining <= (time.red_m * 60 + time.red_s))
            {
                progressBar1.ForeColor = Color.Red;
            }
            viewtime();
        }
        private void viewtime()
        {
            //0秒以上のとき
            if (remaining >= 0)
            {
                //残り時間を2桁表記で
                label1.Text = "" + remaining / 36000 % 10 + remaining / 3600 % 10 +
                               ":" + remaining / 600 % 6 + remaining / 60 % 10 +
                               ":" + remaining / 10 % 6 + remaining % 10;

                progressBar1.Value = remaining;
            }
            //0秒を過ぎたとき
            else
            {
                //残り時間をマイナス表記で
                int remaining_m = remaining * -1;

                label1.ForeColor = Color.Red;
                
                label1.Text = "-" + remaining_m / 36000 % 10 + remaining_m / 3600 % 10 +
                               ":" + remaining_m / 600 % 6 + remaining_m / 60 % 10 +
                               ":" + remaining_m / 10 % 6 + remaining_m % 10;
            }             
        }

        private void reset()
        {
            remaining = time.sec;

            progressBar1.ForeColor = Color.Blue;
            label1.ForeColor = Color.White;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Form2 form2=new Form2())
            {
                form2.ShowDialog();     //設定画面を開く。設定画面が閉じるまで次のコードにいかない。

                progressBar1.Maximum = time.sec;
                progressBar1.Width = size.bar_w;
                progressBar1.Height = size.bar_h;
                progressBar1.Location = size.bar_location;

                this.Width = size.form_w;
                this.Height = size.form_h;

                button1.Width = size.button_w;
                button1.Height= size.button_h;
                button1.Font = size.button_font;

                label1.Width = size.label_w;
                label1.Height = size.label_h;
                label1.Font = size.label_font;

                remaining = time.sec;
                progressBar1.ForeColor = Color.Blue;
                label1.ForeColor = Color.White;

                viewtime();

                this.Refresh();
            }
        }

        private void リセットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            viewtime();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Rキー押下でリセット
                case Keys.R:
                    reset();
                    viewtime();

                    break;

                //Escキー押下で終了
                case Keys.Escape:
                    this.Close();

                    break;

                //エンターまたはスペースで開始/停止
            }
        }
    }

}
