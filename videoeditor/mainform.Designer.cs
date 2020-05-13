namespace videoeditor
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_editform = new System.Windows.Forms.Button();
            this.btn_depository = new System.Windows.Forms.Button();
            this.btn_logo = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.btn_record = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_top.Controls.Add(this.btn_record);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_max);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Controls.Add(this.btn_settings);
            this.panel_top.Controls.Add(this.btn_editform);
            this.panel_top.Controls.Add(this.btn_depository);
            this.panel_top.Controls.Add(this.btn_logo);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1132, 66);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(928, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(68, 66);
            this.btn_min.TabIndex = 7;
            this.btn_min.Text = "—";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.Location = new System.Drawing.Point(996, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(68, 66);
            this.btn_max.TabIndex = 6;
            this.btn_max.Text = "口";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1064, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(68, 66);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(330, 0);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(110, 66);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "设置";
            this.btn_settings.UseVisualStyleBackColor = false;
            // 
            // btn_editform
            // 
            this.btn_editform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_editform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editform.FlatAppearance.BorderSize = 0;
            this.btn_editform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editform.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_editform.ForeColor = System.Drawing.Color.White;
            this.btn_editform.Location = new System.Drawing.Point(220, 0);
            this.btn_editform.Name = "btn_editform";
            this.btn_editform.Size = new System.Drawing.Size(110, 66);
            this.btn_editform.TabIndex = 3;
            this.btn_editform.Text = "编辑";
            this.btn_editform.UseVisualStyleBackColor = false;
            // 
            // btn_depository
            // 
            this.btn_depository.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_depository.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_depository.FlatAppearance.BorderSize = 0;
            this.btn_depository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_depository.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_depository.ForeColor = System.Drawing.Color.White;
            this.btn_depository.Location = new System.Drawing.Point(110, 0);
            this.btn_depository.Name = "btn_depository";
            this.btn_depository.Size = new System.Drawing.Size(110, 66);
            this.btn_depository.TabIndex = 4;
            this.btn_depository.Text = "仓库";
            this.btn_depository.UseVisualStyleBackColor = false;
            this.btn_depository.Click += new System.EventHandler(this.btn_depository_Click);
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_logo.FlatAppearance.BorderSize = 0;
            this.btn_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Location = new System.Drawing.Point(0, 0);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(110, 66);
            this.btn_logo.TabIndex = 1;
            this.btn_logo.Text = "LOGO";
            this.btn_logo.UseVisualStyleBackColor = false;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 66);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1132, 669);
            this.panel_container.TabIndex = 1;
            // 
            // btn_record
            // 
            this.btn_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_record.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_record.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_record.ForeColor = System.Drawing.Color.White;
            this.btn_record.Image = global::videoeditor.Properties.Resources.record;
            this.btn_record.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_record.Location = new System.Drawing.Point(641, 14);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(143, 38);
            this.btn_record.TabIndex = 8;
            this.btn_record.Text = "开始录制";
            this.btn_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_record.UseVisualStyleBackColor = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 735);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.Button btn_depository;
        private System.Windows.Forms.Button btn_editform;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Panel panel_container;
    }
}

