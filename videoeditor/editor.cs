using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace videoeditor
{
    public partial class editor : Form
    {
        public int font_index = 0;
        private bool addtext_selected = false;
        styleinit dgvstyle = new styleinit();
        private bool is_play = false;


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
            if (file_selected != "")
            {
                initvideo();
            }
            fontbind();
            trackbar_volume.Visible = false;
            dgvstyle.ColorDataGridView(dgv_history);
            DataTable dt = new DataTable("edithistory");
            dt.Columns.Add("操作记录");
            dgv_history.DataSource = dt;
        }
        private void initvideo()
        {
            int videotime = (int)axTimelineControl.GetMediaDuration(file_selected);
            axTimelineControl.AddVideoClip(1, file_selected, 0, axTimelineControl.GetMediaDuration(file_selected), 0, 2);
            axTimelineControl.AddAudioClip(5, file_selected, 0, axTimelineControl.GetMediaDuration(file_selected), 0, (float)1.0);
            DateTime end_time = DateTime.Parse(DateTime.Now.ToString("00:00:00")).AddSeconds(videotime);
            trackbar_timeline.Maximum = (int)axTimelineControl.GetMediaDuration(file_selected);
            trackbar_timeline.Minimum = 0;
            //将转换的datetime对象格式化
            string endtime = string.Format("{0:HH:mm:ss}", end_time);
            lbl_end.Text = endtime;
        }

        private void btn_addtext_Click(object sender, EventArgs e)
        {
            if (file_selected == "")
                return;
            //光标形状变化
            this.Cursor = Cursors.IBeam;
            addtext_selected = true;
            /*fontDialog1.ShowDialog();
            font_index = (int)fontDialog1.Font.ToHfont();
            axTimelineControl.AddTextClip2(7, "This is a test", 9, 16, font_index, 100, 40,0,0,0);*/
        }

        private void cbo_font_DropDown(object sender, EventArgs e)
        {
            /*fontDialog1.ShowDialog();
            font_index = (int)fontDialog1.Font.ToHfont();*/
        }

        private void fontbind()
        {
            FontFamily[] fontFamilies;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Get the array of FontFamily objects.
            fontFamilies = installedFontCollection.Families;
            
            // The loop below creates a large string that is a comma-separated
            // list of all font family names.
            List<FontFamily> fontfamiles = new List<FontFamily>(fontFamilies);
            cbo_font.DataSource = fontfamiles;
            cbo_font.DisplayMember = "Name";
        }

        #region 添加文字
        /// <summary>
        /// 添加文字在点击处
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_play_Click(object sender, EventArgs e)
        {
            if (addtext_selected == true)
            {
                ///添加一个textbox或者label在click 位置
            }
        }

        private void panel_play_MouseLeave(object sender, EventArgs e)
        {
            if (addtext_selected == true)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void panel_play_MouseMove(object sender, MouseEventArgs e)
        {
            if (addtext_selected == true)
            {
                this.Cursor = Cursors.IBeam;
            }
        }
        #endregion



        private void pic_pause_Click(object sender, EventArgs e)
        {
            if (file_selected == "")
                return;
            axTimelineControl.SetPreviewWnd((int)panel_play.Handle);
            
            if (is_play == false) {
                pic_pause.Image = global::videoeditor.Properties.Resources.stop;
                is_play = true;
                axTimelineControl.Play();
            }
            else
            {
                pic_pause.Image = global::videoeditor.Properties.Resources.playfill;
                is_play = false;
                axTimelineControl.Stop();
            }

        }

        private void pic_volume_Click(object sender, EventArgs e)
        {
            if (trackbar_volume.Visible == false)
                trackbar_volume.Visible = true;
            else
                trackbar_volume.Visible = false;
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_selected = openFileDialog.FileName;
                initvideo();
            }
        }
    }
}
