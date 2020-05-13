namespace videoeditor
{
    partial class repository
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repository));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.panel_operator = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_detial = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_video = new System.Windows.Forms.Panel();
            this.panel_play = new System.Windows.Forms.Panel();
            this.pic_play = new System.Windows.Forms.PictureBox();
            this.panel_Player = new System.Windows.Forms.Panel();
            this.panelspeed = new System.Windows.Forms.Panel();
            this.btn_speed = new System.Windows.Forms.Button();
            this.cbo_speed = new System.Windows.Forms.ComboBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.panel_volume = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_timeline = new System.Windows.Forms.Panel();
            this.pic_volume = new System.Windows.Forms.PictureBox();
            this.pic_pre = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_pause = new System.Windows.Forms.PictureBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_result = new System.Windows.Forms.Panel();
            this.dgv_files = new System.Windows.Forms.DataGridView();
            this.panel_search = new System.Windows.Forms.Panel();
            this.gbo_search = new System.Windows.Forms.GroupBox();
            this.pan_search = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.panel_container.SuspendLayout();
            this.panel_detail.SuspendLayout();
            this.panel_operator.SuspendLayout();
            this.panel_video.SuspendLayout();
            this.panel_play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            this.panel_Player.SuspendLayout();
            this.panelspeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).BeginInit();
            this.panel_left.SuspendLayout();
            this.panel_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).BeginInit();
            this.panel_search.SuspendLayout();
            this.gbo_search.SuspendLayout();
            this.pan_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel_detail);
            this.panel_container.Controls.Add(this.panel_video);
            this.panel_container.Controls.Add(this.panel_left);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1274, 892);
            this.panel_container.TabIndex = 2;
            // 
            // panel_detail
            // 
            this.panel_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_detail.Controls.Add(this.panel_operator);
            this.panel_detail.Controls.Add(this.lbl_detial);
            this.panel_detail.Controls.Add(this.lbl_title);
            this.panel_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_detail.Location = new System.Drawing.Point(412, 520);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Size = new System.Drawing.Size(862, 372);
            this.panel_detail.TabIndex = 3;
            // 
            // panel_operator
            // 
            this.panel_operator.Controls.Add(this.btn_delete);
            this.panel_operator.Controls.Add(this.btn_edit);
            this.panel_operator.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_operator.Location = new System.Drawing.Point(743, 0);
            this.panel_operator.Name = "panel_operator";
            this.panel_operator.Size = new System.Drawing.Size(119, 372);
            this.panel_operator.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(18, 80);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 45);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(18, 20);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(80, 45);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_detial
            // 
            this.lbl_detial.AutoSize = true;
            this.lbl_detial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_detial.ForeColor = System.Drawing.Color.White;
            this.lbl_detial.Location = new System.Drawing.Point(27, 54);
            this.lbl_detial.Name = "lbl_detial";
            this.lbl_detial.Size = new System.Drawing.Size(75, 20);
            this.lbl_detial.TabIndex = 1;
            this.lbl_detial.Text = "Detial......";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(25, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(77, 33);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title:";
            // 
            // panel_video
            // 
            this.panel_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel_video.Controls.Add(this.panel_play);
            this.panel_video.Controls.Add(this.panel_Player);
            this.panel_video.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_video.Location = new System.Drawing.Point(412, 0);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(862, 520);
            this.panel_video.TabIndex = 2;
            // 
            // panel_play
            // 
            this.panel_play.Controls.Add(this.pic_play);
            this.panel_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_play.Location = new System.Drawing.Point(0, 0);
            this.panel_play.Name = "panel_play";
            this.panel_play.Size = new System.Drawing.Size(862, 412);
            this.panel_play.TabIndex = 13;
            // 
            // pic_play
            // 
            this.pic_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_play.Image = global::videoeditor.Properties.Resources.play;
            this.pic_play.Location = new System.Drawing.Point(356, 128);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(137, 144);
            this.pic_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_play.TabIndex = 12;
            this.pic_play.TabStop = false;
            // 
            // panel_Player
            // 
            this.panel_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_Player.Controls.Add(this.panelspeed);
            this.panel_Player.Controls.Add(this.lbl_volume);
            this.panel_Player.Controls.Add(this.panel_volume);
            this.panel_Player.Controls.Add(this.label2);
            this.panel_Player.Controls.Add(this.label1);
            this.panel_Player.Controls.Add(this.panel_timeline);
            this.panel_Player.Controls.Add(this.pic_volume);
            this.panel_Player.Controls.Add(this.pic_pre);
            this.panel_Player.Controls.Add(this.pic_next);
            this.panel_Player.Controls.Add(this.pic_pause);
            this.panel_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Player.Location = new System.Drawing.Point(0, 412);
            this.panel_Player.Name = "panel_Player";
            this.panel_Player.Size = new System.Drawing.Size(862, 108);
            this.panel_Player.TabIndex = 2;
            // 
            // panelspeed
            // 
            this.panelspeed.Controls.Add(this.btn_speed);
            this.panelspeed.Controls.Add(this.cbo_speed);
            this.panelspeed.Location = new System.Drawing.Point(574, 52);
            this.panelspeed.Name = "panelspeed";
            this.panelspeed.Size = new System.Drawing.Size(98, 38);
            this.panelspeed.TabIndex = 13;
            // 
            // btn_speed
            // 
            this.btn_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_speed.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_speed.ForeColor = System.Drawing.Color.White;
            this.btn_speed.Location = new System.Drawing.Point(0, 0);
            this.btn_speed.Name = "btn_speed";
            this.btn_speed.Size = new System.Drawing.Size(98, 38);
            this.btn_speed.TabIndex = 2;
            this.btn_speed.Text = "倍速";
            this.btn_speed.UseVisualStyleBackColor = false;
            this.btn_speed.Click += new System.EventHandler(this.btn_speed_Click);
            // 
            // cbo_speed
            // 
            this.cbo_speed.BackColor = System.Drawing.Color.Black;
            this.cbo_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_speed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.cbo_speed.ForeColor = System.Drawing.Color.White;
            this.cbo_speed.FormattingEnabled = true;
            this.cbo_speed.Items.AddRange(new object[] {
            "0.5X",
            "0.75X",
            "1.0X",
            "1.25X",
            "1.5X"});
            this.cbo_speed.Location = new System.Drawing.Point(0, 0);
            this.cbo_speed.Name = "cbo_speed";
            this.cbo_speed.Size = new System.Drawing.Size(98, 35);
            this.cbo_speed.TabIndex = 12;
            this.cbo_speed.SelectedIndexChanged += new System.EventHandler(this.cbo_speed_SelectedIndexChanged);
            // 
            // lbl_volume
            // 
            this.lbl_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_volume.Location = new System.Drawing.Point(297, 59);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(23, 15);
            this.lbl_volume.TabIndex = 11;
            this.lbl_volume.Text = "0%";
            // 
            // panel_volume
            // 
            this.panel_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel_volume.Location = new System.Drawing.Point(142, 65);
            this.panel_volume.Name = "panel_volume";
            this.panel_volume.Size = new System.Drawing.Size(150, 5);
            this.panel_volume.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "00:00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(806, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "00:00";
            // 
            // panel_timeline
            // 
            this.panel_timeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_timeline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.panel_timeline.Location = new System.Drawing.Point(58, 24);
            this.panel_timeline.Name = "panel_timeline";
            this.panel_timeline.Size = new System.Drawing.Size(742, 5);
            this.panel_timeline.TabIndex = 8;
            // 
            // pic_volume
            // 
            this.pic_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_volume.Image = ((System.Drawing.Image)(resources.GetObject("pic_volume.Image")));
            this.pic_volume.Location = new System.Drawing.Point(109, 56);
            this.pic_volume.Name = "pic_volume";
            this.pic_volume.Size = new System.Drawing.Size(24, 24);
            this.pic_volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_volume.TabIndex = 7;
            this.pic_volume.TabStop = false;
            // 
            // pic_pre
            // 
            this.pic_pre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pre.Image = ((System.Drawing.Image)(resources.GetObject("pic_pre.Image")));
            this.pic_pre.Location = new System.Drawing.Point(360, 56);
            this.pic_pre.Name = "pic_pre";
            this.pic_pre.Size = new System.Drawing.Size(24, 24);
            this.pic_pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pre.TabIndex = 3;
            this.pic_pre.TabStop = false;
            // 
            // pic_next
            // 
            this.pic_next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_next.Image = ((System.Drawing.Image)(resources.GetObject("pic_next.Image")));
            this.pic_next.Location = new System.Drawing.Point(469, 56);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(24, 24);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_next.TabIndex = 2;
            this.pic_next.TabStop = false;
            // 
            // pic_pause
            // 
            this.pic_pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pause.Image = ((System.Drawing.Image)(resources.GetObject("pic_pause.Image")));
            this.pic_pause.Location = new System.Drawing.Point(411, 52);
            this.pic_pause.Name = "pic_pause";
            this.pic_pause.Size = new System.Drawing.Size(32, 32);
            this.pic_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pause.TabIndex = 1;
            this.pic_pause.TabStop = false;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.panel_result);
            this.panel_left.Controls.Add(this.panel_search);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(412, 892);
            this.panel_left.TabIndex = 1;
            // 
            // panel_result
            // 
            this.panel_result.Controls.Add(this.dgv_files);
            this.panel_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_result.Location = new System.Drawing.Point(0, 128);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(412, 764);
            this.panel_result.TabIndex = 1;
            // 
            // dgv_files
            // 
            this.dgv_files.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgv_files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_files.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_files.GridColor = System.Drawing.Color.Gray;
            this.dgv_files.Location = new System.Drawing.Point(0, 0);
            this.dgv_files.Name = "dgv_files";
            this.dgv_files.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_files.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_files.RowHeadersVisible = false;
            this.dgv_files.RowHeadersWidth = 51;
            this.dgv_files.RowTemplate.Height = 27;
            this.dgv_files.Size = new System.Drawing.Size(412, 764);
            this.dgv_files.TabIndex = 0;
            this.dgv_files.SelectionChanged += new System.EventHandler(this.dgv_files_SelectionChanged);
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_search.Controls.Add(this.gbo_search);
            this.panel_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search.Location = new System.Drawing.Point(0, 0);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(412, 128);
            this.panel_search.TabIndex = 0;
            // 
            // gbo_search
            // 
            this.gbo_search.Controls.Add(this.pan_search);
            this.gbo_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbo_search.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbo_search.ForeColor = System.Drawing.Color.White;
            this.gbo_search.Location = new System.Drawing.Point(0, 0);
            this.gbo_search.Name = "gbo_search";
            this.gbo_search.Size = new System.Drawing.Size(412, 128);
            this.gbo_search.TabIndex = 0;
            this.gbo_search.TabStop = false;
            this.gbo_search.Text = "搜索";
            // 
            // pan_search
            // 
            this.pan_search.BackColor = System.Drawing.Color.White;
            this.pan_search.Controls.Add(this.txt_search);
            this.pan_search.Controls.Add(this.pic_search);
            this.pan_search.Location = new System.Drawing.Point(42, 58);
            this.pan_search.Name = "pan_search";
            this.pan_search.Size = new System.Drawing.Size(311, 35);
            this.pan_search.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_search.Location = new System.Drawing.Point(46, 5);
            this.txt_search.Margin = new System.Windows.Forms.Padding(1);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(255, 24);
            this.txt_search.TabIndex = 1;
            // 
            // pic_search
            // 
            this.pic_search.Image = global::videoeditor.Properties.Resources.search;
            this.pic_search.Location = new System.Drawing.Point(0, 0);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(38, 39);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_search.TabIndex = 0;
            this.pic_search.TabStop = false;
            // 
            // repository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1274, 892);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "repository";
            this.Text = "repository";
            this.Load += new System.EventHandler(this.repository_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_detail.ResumeLayout(false);
            this.panel_detail.PerformLayout();
            this.panel_operator.ResumeLayout(false);
            this.panel_video.ResumeLayout(false);
            this.panel_play.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            this.panel_Player.ResumeLayout(false);
            this.panel_Player.PerformLayout();
            this.panelspeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.gbo_search.ResumeLayout(false);
            this.pan_search.ResumeLayout(false);
            this.pan_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.Panel panel_operator;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_detial;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.Panel panel_play;
        private System.Windows.Forms.PictureBox pic_play;
        private System.Windows.Forms.Panel panel_Player;
        private System.Windows.Forms.Panel panelspeed;
        private System.Windows.Forms.Button btn_speed;
        private System.Windows.Forms.ComboBox cbo_speed;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Panel panel_volume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_timeline;
        private System.Windows.Forms.PictureBox pic_volume;
        private System.Windows.Forms.PictureBox pic_pre;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_pause;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.DataGridView dgv_files;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.GroupBox gbo_search;
        private System.Windows.Forms.Panel pan_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pic_search;
    }
}