using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoeditor
{
    public partial class editor : Form
    {
        public int font_index = 0;


        public editor()
        {
            InitializeComponent();
        }
        private string file_selected = "";
        public editor(string file)
        {
            InitializeComponent();
            file_selected = file;
        }

        private void editor_Load(object sender, EventArgs e)
        {
            
            axTimelineControl.AddVideoClip(1, file_selected, 0, axTimelineControl.GetMediaDuration(file_selected), 0, 2);
            axTimelineControl.AddAudioClip(5, file_selected, 0, axTimelineControl.GetMediaDuration(file_selected), 0,(float)1.0);
        }

        private void pic_play_Click(object sender, EventArgs e)
        {
            axTimelineControl.SetPreviewWnd((int)panel_play.Handle);
            axTimelineControl.Play();
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            axTimelineControl.Play();
        }

        private void btn_addtext_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font_index = (int)fontDialog1.Font.ToHfont();
            //axTimelineControl.AddTextClip(7, "This is a test", 9, 16, font_index, 100, 40,);
            axTimelineControl.AddTextClip2(7, "This is a test", 9, 16, font_index, 100, 40,0,0,0);
        }

        private void cbo_font_DropDown(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            font_index = (int)fontDialog1.Font.ToHfont();
            //cbo_font.Text = fontDialog1.Font.Name;
        }
    }
}
