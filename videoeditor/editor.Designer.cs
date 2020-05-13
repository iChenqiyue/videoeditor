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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_video = new System.Windows.Forms.Panel();
            this.panel_play = new System.Windows.Forms.Panel();
            this.pic_play = new System.Windows.Forms.PictureBox();
            this.axTimelineControl = new AxTimelineAxLib.AxTimelineControl();
            this.btn_addtext = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cbo_font = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel_video.SuspendLayout();
            this.panel_play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_font);
            this.panel1.Controls.Add(this.btn_addtext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(952, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 688);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 688);
            this.panel2.TabIndex = 2;
            // 
            // panel_video
            // 
            this.panel_video.BackColor = System.Drawing.Color.Red;
            this.panel_video.Controls.Add(this.panel_play);
            this.panel_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_video.Location = new System.Drawing.Point(315, 0);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(637, 688);
            this.panel_video.TabIndex = 3;
            // 
            // panel_play
            // 
            this.panel_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_play.Controls.Add(this.pic_play);
            this.panel_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_play.Location = new System.Drawing.Point(0, 0);
            this.panel_play.Name = "panel_play";
            this.panel_play.Size = new System.Drawing.Size(637, 688);
            this.panel_play.TabIndex = 13;
            // 
            // pic_play
            // 
            this.pic_play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_play.Image = global::videoeditor.Properties.Resources.play;
            this.pic_play.Location = new System.Drawing.Point(189, 171);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(258, 291);
            this.pic_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_play.TabIndex = 12;
            this.pic_play.TabStop = false;
            this.pic_play.Click += new System.EventHandler(this.pic_play_Click);
            // 
            // axTimelineControl
            // 
            this.axTimelineControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axTimelineControl.Enabled = true;
            this.axTimelineControl.Location = new System.Drawing.Point(0, 688);
            this.axTimelineControl.Name = "axTimelineControl";
            this.axTimelineControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTimelineControl.OcxState")));
            this.axTimelineControl.Size = new System.Drawing.Size(1274, 204);
            this.axTimelineControl.TabIndex = 0;
            // 
            // btn_addtext
            // 
            this.btn_addtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addtext.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addtext.ForeColor = System.Drawing.Color.White;
            this.btn_addtext.Location = new System.Drawing.Point(48, 43);
            this.btn_addtext.Name = "btn_addtext";
            this.btn_addtext.Size = new System.Drawing.Size(75, 53);
            this.btn_addtext.TabIndex = 0;
            this.btn_addtext.Text = "T";
            this.btn_addtext.UseVisualStyleBackColor = true;
            this.btn_addtext.Click += new System.EventHandler(this.btn_addtext_Click);
            // 
            // cbo_font
            // 
            this.cbo_font.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_font.FormattingEnabled = true;
            this.cbo_font.Location = new System.Drawing.Point(48, 133);
            this.cbo_font.Name = "cbo_font";
            this.cbo_font.Size = new System.Drawing.Size(121, 35);
            this.cbo_font.TabIndex = 1;
            this.cbo_font.Text = "Font";
            this.cbo_font.DropDown += new System.EventHandler(this.cbo_font_DropDown);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1274, 892);
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axTimelineControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "editor";
            this.Text = "editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel_video.ResumeLayout(false);
            this.panel_play.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.Panel panel_play;
        private System.Windows.Forms.PictureBox pic_play;
        private AxTimelineAxLib.AxTimelineControl axTimelineControl;
        private System.Windows.Forms.Button btn_addtext;
        private System.Windows.Forms.ComboBox cbo_font;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}