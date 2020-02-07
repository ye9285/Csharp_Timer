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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            num_h.Value = time.h;
            num_m.Value = time.m;
            num_s.Value = time.s;

            num_m_yellow.Value = time.yellow_m;
            num_s_yellow.Value = time.yellow_s;
            num_m_red.Value = time.red_m;
            num_s_red.Value = time.red_s;

            if ((size.w == 1920) && (size.h == 1080))
            {
                cmb_size.SelectedIndex = 0;
            }
            else if ((size.w == 1680) && (size.h == 1050))
            {
                cmb_size.SelectedIndex = 1;
            }
            else if ((size.w == 1600) && (size.h == 900))
            {
                cmb_size.SelectedIndex = 2;
            }
            else if ((size.w == 1440) && (size.h == 900))
            {
                cmb_size.SelectedIndex = 3;
            }
            else if ((size.w == 1366) && (size.h == 768))
            {
                cmb_size.SelectedIndex = 4;
            }
            else if ((size.w == 1280) && (size.h == 1024))
            {
                cmb_size.SelectedIndex = 5;
            }
            else if ((size.w == 1024) && (size.h == 768))
            {
                cmb_size.SelectedIndex = 6;
            }
            else if ((size.w == 800) && (size.h == 600))
            {
                cmb_size.SelectedIndex = 7;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            time.h = num_h.Value;
            time.m = num_m.Value;
            time.s = num_s.Value;

            time.yellow_m = num_m_yellow.Value;
            time.yellow_s = num_s_yellow.Value;
            time.red_m = num_m_red.Value;
            time.red_s = num_s_red.Value;

            time.sec = (int)(time.h * 3600 + time.m * 60 + time.s);

            switch(cmb_size.SelectedIndex)
            {
                case 0:
                    size.w = 1920;
                    size.h = 1080;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w-250;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(235,10);

                    size.label_w = 165;
                    size.label_h = 40;
                    size.label_font = new Font("Yu Gothic UI", 26, FontStyle.Bold);

                    size.button_w = 45;
                    size.button_h = 45;
                    size.button_font = new Font("Yu Gothic UI", 20);

                    break;

                case 1:
                    size.w = 1680;
                    size.h = 1050;

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

                    break;

                case 2:
                    size.w = 1600;
                    size.h = 900;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w - 230;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(220, 10);

                    size.label_w = 150;
                    size.label_h = 40;
                    size.label_font = new Font("Yu Gothic UI", 22, FontStyle.Bold);

                    size.button_w = 37;
                    size.button_h = 37;
                    size.button_font = new Font("Yu Gothic UI", 16);

                    break;

                case 3:
                    size.w = 1440;
                    size.h = 900;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w - 230;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(220, 10);

                    size.label_w = 150;
                    size.label_h = 40;
                    size.label_font = new Font("Yu Gothic UI", 22, FontStyle.Bold);

                    size.button_w = 37;
                    size.button_h = 37;
                    size.button_font = new Font("Yu Gothic UI", 16);

                    break;

                case 4:
                    size.w = 1366;
                    size.h = 768;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w - 230;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(210, 7);

                    size.label_w = 145;
                    size.label_h = 38;
                    size.label_font = new Font("Yu Gothic UI", 20, FontStyle.Bold);

                    size.button_w = 33;
                    size.button_h = 33;
                    size.button_font = new Font("Yu Gothic UI", 14);

                    break;

                case 5:
                    size.w = 1280;
                    size.h = 1024;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.045);

                    size.bar_w = size.w - 230;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(210, 7);

                    size.label_w = 150;
                    size.label_h = 40;
                    size.label_font = new Font("Yu Gothic UI", 22, FontStyle.Bold);

                    size.button_w = 37;
                    size.button_h = 37;
                    size.button_font = new Font("Yu Gothic UI", 16);

                    break;

                case 6:
                    size.w = 1024;
                    size.h = 768;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w - 220;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(210, 7);

                    size.label_w = 145;
                    size.label_h = 38;
                    size.label_font = new Font("Yu Gothic UI", 20, FontStyle.Bold);

                    size.button_w = 33;
                    size.button_h = 33;
                    size.button_font = new Font("Yu Gothic UI", 14);

                    break;

                case 7:
                    size.w = 800;
                    size.h = 600;

                    size.form_w = size.w;
                    size.form_h = (int)(size.h * 0.05);

                    size.bar_w = size.w - 220;
                    size.bar_h = (int)(size.h * 0.03);
                    size.bar_location = new Point(200, 7);

                    size.label_w = 135;
                    size.label_h = 35;
                    size.label_font = new Font("Yu Gothic UI", 18, FontStyle.Bold);

                    size.button_w = 25;
                    size.button_h = 25;
                    size.button_font = new Font("Yu Gothic UI", 10);

                    break;
            }
            this.Close();
        }

    }
}
