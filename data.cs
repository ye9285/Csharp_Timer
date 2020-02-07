//Form間共通の変数を宣言する場所

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JCSCTimer
{
    public static class time
    {
        public static decimal h;
        public static decimal m;
        public static decimal s;

        public static decimal yellow_m;
        public static decimal yellow_s;
        public static decimal red_m;
        public static decimal red_s;

        public static int sec;
    }

    public static class size
    {
        public static int w;
        public static int h;
        public static int form_w;
        public static int form_h;
        public static int bar_w;
        public static int bar_h;
        public static Point bar_location;
        public static int label_w;
        public static int label_h;
        public static Font label_font;
        public static int button_w;
        public static int button_h;
        public static Font button_font;
    }

}