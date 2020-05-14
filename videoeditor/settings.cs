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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_directory.Text = folderBrowserDialog.SelectedPath;
                userpath.filepath= folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            txt_directory.Text = userpath.filepath;
        }
    }
}
