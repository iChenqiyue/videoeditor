namespace videoeditor
{
    partial class editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.panel_right = new System.Windows.Forms.Panel();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.btn_addtext = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_deleteline = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_bold = new System.Windows.Forms.Button();
            this.btn_Italic = new System.Windows.Forms.Button();
            this.cbo_font = new System.Windows.Forms.ComboBox();
            this.panel_video = new System.Windows.Forms.Panel();
            this.trackbar_volume = new System.Windows.Forms.TrackBar();
            this.panel_play = new System.Windows.Forms.Panel();
            this.panel_Player = new System.Windows.Forms.Panel();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.trackbar_timeline = new System.Windows.Forms.TrackBar();
            this.axTimelineControl = new AxTimelineAxLib.AxTimelineControl();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pic_volume = new System.Windows.Forms.PictureBox();
            this.pic_pre = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_pause = new System.Windows.Forms.PictureBox();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.panel_left.SuspendLayout();
            this.panel_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_volume)).BeginInit();
            this.panel_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_timeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.dgv_history);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(1034, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(240, 436);
            this.panel_right.TabIndex = 1;
            // 
            // dgv_history
            // 
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_history.Location = new System.Drawing.Point(0, 0);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowHeadersWidth = 51;
            this.dgv_history.RowTemplate.Height = 27;
            this.dgv_history.Size = new System.Drawing.Size(240, 436);
            this.dgv_history.TabIndex = 0;
            // 
            // btn_addtext
            // 
            this.btn_addtext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addtext.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addtext.ForeColor = System.Drawing.Color.White;
            this.btn_addtext.Location = new System.Drawing.Point(0, 84);
            this.btn_addtext.Name = "btn_addtext";
            this.btn_addtext.Size = new System.Drawing.Size(240, 84);
            this.btn_addtext.TabIndex = 0;
            this.btn_addtext.Text = "添加文字";
            this.btn_addtext.UseVisualStyleBackColor = true;
            this.btn_addtext.Click += new System.EventHandler(this.btn_addtext_Click);
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.btn_deleteline);
            this.panel_left.Controls.Add(this.btn_underline);
            this.panel_left.Controls.Add(this.btn_bold);
            this.panel_left.Controls.Add(this.btn_Italic);
            this.panel_left.Controls.Add(this.cbo_font);
            this.panel_left.Controls.Add(this.btn_addtext);
            this.panel_left.Controls.Add(this.btn_openfile);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(240, 436);
            this.panel_left.TabIndex = 2;
            // 
            // btn_deleteline
            // 
            this.btn_deleteline.BackColor = System.Drawing.Color.Black;
            this.btn_deleteline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteline.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_deleteline.ForeColor = System.Drawing.Color.White;
            this.btn_deleteline.Location = new System.Drawing.Point(180, 280);
            this.btn_deleteline.Name = "btn_deleteline";
            this.btn_deleteline.Size = new System.Drawing.Size(35, 35);
            this.btn_deleteline.TabIndex = 11;
            this.btn_deleteline.Text = "D";
            this.btn_deleteline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteline.UseVisualStyleBackColor = false;
            // 
            // btn_underline
            // 
            this.btn_underline.BackColor = System.Drawing.Color.Black;
            this.btn_underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_underline.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_underline.ForeColor = System.Drawing.Color.White;
            this.btn_underline.Location = new System.Drawing.Point(126, 280);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(35, 35);
            this.btn_underline.TabIndex = 10;
            this.btn_underline.Text = "U";
            this.btn_underline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_underline.UseVisualStyleBackColor = false;
            // 
            // btn_bold
            // 
            this.btn_bold.BackColor = System.Drawing.Color.Black;
            this.btn_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_bold.ForeColor = System.Drawing.Color.White;
            this.btn_bold.Location = new System.Drawing.Point(75, 280);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(35, 35);
            this.btn_bold.TabIndex = 9;
            this.btn_bold.Text = "B";
            this.btn_bold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bold.UseVisualStyleBackColor = false;
            // 
            // btn_Italic
            // 
            this.btn_Italic.BackColor = System.Drawing.Color.Black;
            this.btn_Italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Italic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Italic.ForeColor = System.Drawing.Color.White;
            this.btn_Italic.Location = new System.Drawing.Point(23, 280);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(35, 35);
            this.btn_Italic.TabIndex = 8;
            this.btn_Italic.Text = "I";
            this.btn_Italic.UseVisualStyleBackColor = false;
            // 
            // cbo_font
            // 
            this.cbo_font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cbo_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_font.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_font.ForeColor = System.Drawing.Color.White;
            this.cbo_font.FormattingEnabled = true;
            this.cbo_font.Location = new System.Drawing.Point(29, 209);
            this.cbo_font.Name = "cbo_font";
            this.cbo_font.Size = new System.Drawing.Size(179, 28);
            this.cbo_font.TabIndex = 7;
            this.cbo_font.Text = "字体";
            // 
            // panel_video
            // 
            this.panel_video.BackColor = System.Drawing.Color.Red;
            this.panel_video.Controls.Add(this.trackbar_volume);
            this.panel_video.Controls.Add(this.panel_play);
            this.panel_video.Controls.Add(this.panel_Player);
            this.panel_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_video.Location = new System.Drawing.Point(240, 0);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(794, 436);
            this.panel_video.TabIndex = 3;
            // 
            // trackbar_volume
            // 
            this.trackbar_volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackbar_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.trackbar_volume.Location = new System.Drawing.Point(56, 241);
            this.trackbar_volume.Name = "trackbar_volume";
            this.trackbar_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbar_volume.Size = new System.Drawing.Size(56, 132);
            this.trackbar_volume.TabIndex = 12;
            this.trackbar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panel_play
            // 
            this.panel_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_play.Location = new System.Drawing.Point(0, 0);
            this.panel_play.Name = "panel_play";
            this.panel_play.Size = new System.Drawing.Size(794, 328);
            this.panel_play.TabIndex = 13;
            this.panel_play.Click += new System.EventHandler(this.panel_play_Click);
            this.panel_play.MouseLeave += new System.EventHandler(this.panel_play_MouseLeave);
            this.panel_play.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_play_MouseMove);
            // 
            // panel_Player
            // 
            this.panel_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_Player.Controls.Add(this.lbl_start);
            this.panel_Player.Controls.Add(this.lbl_end);
            this.panel_Player.Controls.Add(this.pic_volume);
            this.panel_Player.Controls.Add(this.pic_pre);
            this.panel_Player.Controls.Add(this.pic_next);
            this.panel_Player.Controls.Add(this.pic_pause);
            this.panel_Player.Controls.Add(this.trackbar_timeline);
            this.panel_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Player.Location = new System.Drawing.Point(0, 328);
            this.panel_Player.Name = "panel_Player";
            this.panel_Player.Size = new System.Drawing.Size(794, 108);
            this.panel_Player.TabIndex = 3;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_start.Location = new System.Drawing.Point(12, 17);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(71, 20);
            this.lbl_start.TabIndex = 10;
            this.lbl_start.Text = "00:00:00";
            // 
            // lbl_end
            // 
            this.lbl_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_end.AutoSize = true;
            this.lbl_end.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_end.Location = new System.Drawing.Point(711, 17);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(71, 20);
            this.lbl_end.TabIndex = 9;
            this.lbl_end.Text = "00:00:00";
            // 
            // trackbar_timeline
            // 
            this.trackbar_timeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackbar_timeline.Location = new System.Drawing.Point(67, 15);
            this.trackbar_timeline.Name = "trackbar_timeline";
            this.trackbar_timeline.Size = new System.Drawing.Size(640, 56);
            this.trackbar_timeline.TabIndex = 11;
            this.trackbar_timeline.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // axTimelineControl
            // 
            this.axTimelineControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axTimelineControl.Enabled = true;
            this.axTimelineControl.Location = new System.Drawing.Point(0, 436);
            this.axTimelineControl.Name = "axTimelineControl";
            this.axTimelineControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTimelineControl.OcxState")));
            this.axTimelineControl.Size = new System.Drawing.Size(1274, 240);
            this.axTimelineControl.TabIndex = 0;
            // 
            // pic_volume
            // 
            this.pic_volume.Image = ((System.Drawing.Image)(resources.GetObject("pic_volume.Image")));
            this.pic_volume.Location = new System.Drawing.Point(58, 56);
            this.pic_volume.Name = "pic_volume";
            this.pic_volume.Size = new System.Drawing.Size(24, 24);
            this.pic_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_volume.TabIndex = 7;
            this.pic_volume.TabStop = false;
            this.pic_volume.Click += new System.EventHandler(this.pic_volume_Click);
            // 
            // pic_pre
            // 
            this.pic_pre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pre.Image = global::videoeditor.Properties.Resources.backwardfill;
            this.pic_pre.Location = new System.Drawing.Point(321, 52);
            this.pic_pre.Name = "pic_pre";
            this.pic_pre.Size = new System.Drawing.Size(32, 32);
            this.pic_pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pre.TabIndex = 3;
            this.pic_pre.TabStop = false;
            // 
            // pic_next
            // 
            this.pic_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_next.Image = global::videoeditor.Properties.Resources.play_forward_fill;
            this.pic_next.Location = new System.Drawing.Point(433, 52);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(32, 32);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_next.TabIndex = 2;
            this.pic_next.TabStop = false;
            // 
            // pic_pause
            // 
            this.pic_pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pause.Image = global::videoeditor.Properties.Resources.playfill;
            this.pic_pause.Location = new System.Drawing.Point(378, 52);
            this.pic_pause.Name = "pic_pause";
            this.pic_pause.Size = new System.Drawing.Size(32, 32);
            this.pic_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pause.TabIndex = 1;
            this.pic_pause.TabStop = false;
            this.pic_pause.Click += new System.EventHandler(this.pic_pause_Click);
            // 
            // btn_openfile
            // 
            this.btn_openfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openfile.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openfile.ForeColor = System.Drawing.Color.White;
            this.btn_openfile.Location = new System.Drawing.Point(0, 0);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(240, 84);
            this.btn_openfile.TabIndex = 12;
            this.btn_openfile.Text = "添加/更换文件";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1274, 676);
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.axTimelineControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editor";
            this.Text = "editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_video.ResumeLayout(false);
            this.panel_video.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_volume)).EndInit();
            this.panel_Player.ResumeLayout(false);
            this.panel_Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_timeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.Panel panel_play;
        private AxTimelineAxLib.AxTimelineControl axTimelineControl;
        private System.Windows.Forms.Button btn_addtext;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel_Player;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.PictureBox pic_volume;
        private System.Windows.Forms.PictureBox pic_pause;
        private System.Windows.Forms.PictureBox pic_pre;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.TrackBar trackbar_volume;
        private System.Windows.Forms.TrackBar trackbar_timeline;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.Button btn_deleteline;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.Button btn_bold;
        private System.Windows.Forms.Button btn_Italic;
        private System.Windows.Forms.ComboBox cbo_font;
        private System.Windows.Forms.Button btn_openfile;
    }
}