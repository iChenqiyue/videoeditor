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

   
    public partial class mainform : Form
    {

        
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        public string fileselected = "";

        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            


        }
        #region 窗体设置
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// 最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //窗体移动
        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
        #endregion

        /// <summary>
        /// 显示选中视频信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_files_SelectionChanged(object sender, EventArgs e)
        {
            
        }


        #region 倍速设置



        #endregion





        private Form activeform = null;
        private void openchidform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_container.Controls.Add(childform);
            panel_container.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }



        private void btn_depository_Click(object sender, EventArgs e)
        {
            repository myform = new repository();
            myform.fileselected += new fileselectHandler(fileselect);
            openchidform(myform);
        }

        void fileselect(string filename)
        {
            fileselected = filename;
            openchidform(new editor(fileselected));
        }
    }
}
