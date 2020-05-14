using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace videoeditor
{
    public delegate void fileselectHandler(string filename);  //定义委托

    public partial class repository : Form
    {
        public repository()
        {
            InitializeComponent();
        }

        public event fileselectHandler fileselected;  //定义事件
        //全局变量
        
        string files_path = userpath.filepath;
        public string filename = "";
        styleinit dgvstyle = new styleinit();

        private void repository_Load(object sender, EventArgs e)
        {
            //初始化表格格式
            dgvstyle.ColorDataGridView(dgv_files);

            //获得仓库路径中视频文件
            DirectoryInfo folder = new DirectoryInfo(files_path);
            var Files = Directory.GetFiles(files_path).Where(s => s.EndsWith(".MP4") || s.EndsWith(".WMV") || s.EndsWith(".WMV")
            || s.EndsWith(".AVI") || s.EndsWith(".MOV") || s.EndsWith(".F4") || s.EndsWith(".MKV"));
            DataTable dt = new DataTable("fileinfo");
            dt.Columns.Add("文件名");
            dt.Columns.Add("修改时间");
            dt.Columns.Add("大小");

            foreach (string file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                dt.Rows.Add(fileInfo.Name, fileInfo.LastWriteTime, System.Math.Ceiling(fileInfo.Length / 1024.0) + " KB");
            }
            dgv_files.DataSource = dt;

            //调整表格显示格式
            dgv_files.Columns[0].FillWeight = 140;
            dgv_files.Columns[2].FillWeight = 70;

            trackbar_volume.Visible = false;

        }


        /// <summary>
        /// 显示选中视频信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_files_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_files.SelectedRows.Count > 0)
                lbl_title.Text = dgv_files.SelectedRows[0].Cells[0].Value.ToString();
        }



        #region 倍速设置
        private void btn_speed_Click(object sender, EventArgs e)
        {
            cbo_speed.DroppedDown = true;
        }
      
        private void cbo_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_speed.SelectedItem.ToString() == "1.0X")
            {
                btn_speed.Text = "倍速";
            }
            else
            {
                btn_speed.Text = cbo_speed.SelectedItem.ToString();
            }
        }


        #endregion


        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            filename = files_path.Replace("/", @"\") + @"\" + lbl_title.Text;
            Console.WriteLine(filename);
            fileselected(filename);
            this.Close();           
        }

        private void pic_volume_Click(object sender, EventArgs e)
        {
            if (trackbar_volume.Visible == false)
                trackbar_volume.Visible = true;
            else
                trackbar_volume.Visible = false;
        }
    }
}
