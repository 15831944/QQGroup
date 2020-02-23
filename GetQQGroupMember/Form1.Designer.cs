namespace GetQQGroupMember
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.colGroupNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvQQ = new System.Windows.Forms.DataGridView();
            this.QQNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNewQQ = new System.Windows.Forms.DataGridView();
            this.QQNewNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMsgStart = new System.Windows.Forms.Button();
            this.btnMsgStop = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGetGroup = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewQQ)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(40, 40);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1500, 619);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 619);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 707);
            this.panel1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1101, 707);
            this.panel6.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 707);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(374, 707);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "群列表";
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AllowUserToDeleteRows = false;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupNum});
            this.dgvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroup.Location = new System.Drawing.Point(6, 34);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(6);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.RowHeadersWidth = 82;
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(362, 667);
            this.dgvGroup.TabIndex = 3;
            // 
            // colGroupNum
            // 
            this.colGroupNum.DataPropertyName = "ShowName";
            this.colGroupNum.HeaderText = "QQ群名";
            this.colGroupNum.MinimumWidth = 10;
            this.colGroupNum.Name = "colGroupNum";
            this.colGroupNum.ReadOnly = true;
            this.colGroupNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGroupNum.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(374, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(361, 707);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "群成员";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvQQ);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 667);
            this.panel3.TabIndex = 9;
            // 
            // dgvQQ
            // 
            this.dgvQQ.AllowUserToAddRows = false;
            this.dgvQQ.AllowUserToDeleteRows = false;
            this.dgvQQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QQNum});
            this.dgvQQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQQ.Location = new System.Drawing.Point(0, 0);
            this.dgvQQ.Margin = new System.Windows.Forms.Padding(6);
            this.dgvQQ.Name = "dgvQQ";
            this.dgvQQ.ReadOnly = true;
            this.dgvQQ.RowHeadersWidth = 82;
            this.dgvQQ.RowTemplate.Height = 23;
            this.dgvQQ.Size = new System.Drawing.Size(349, 667);
            this.dgvQQ.TabIndex = 2;
            // 
            // QQNum
            // 
            this.QQNum.DataPropertyName = "ShowName";
            this.QQNum.HeaderText = "QQ号";
            this.QQNum.MinimumWidth = 10;
            this.QQNum.Name = "QQNum";
            this.QQNum.ReadOnly = true;
            this.QQNum.Width = 200;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 450);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(16, 16);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(735, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(366, 707);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "新增成员";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvNewQQ);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 667);
            this.panel4.TabIndex = 9;
            // 
            // dgvNewQQ
            // 
            this.dgvNewQQ.AllowUserToAddRows = false;
            this.dgvNewQQ.AllowUserToDeleteRows = false;
            this.dgvNewQQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewQQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QQNewNum});
            this.dgvNewQQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNewQQ.Location = new System.Drawing.Point(0, 0);
            this.dgvNewQQ.Margin = new System.Windows.Forms.Padding(6);
            this.dgvNewQQ.Name = "dgvNewQQ";
            this.dgvNewQQ.ReadOnly = true;
            this.dgvNewQQ.RowHeadersWidth = 82;
            this.dgvNewQQ.RowTemplate.Height = 23;
            this.dgvNewQQ.Size = new System.Drawing.Size(354, 667);
            this.dgvNewQQ.TabIndex = 3;
            // 
            // QQNewNum
            // 
            this.QQNewNum.DataPropertyName = "ShowName";
            this.QQNewNum.HeaderText = "QQ号";
            this.QQNewNum.MinimumWidth = 10;
            this.QQNewNum.Name = "QQNewNum";
            this.QQNewNum.ReadOnly = true;
            this.QQNewNum.Width = 200;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnMsgStart);
            this.panel5.Controls.Add(this.btnMsgStop);
            this.panel5.Controls.Add(this.btnStop);
            this.panel5.Controls.Add(this.btnGetGroup);
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1101, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 707);
            this.panel5.TabIndex = 19;
            // 
            // btnMsgStart
            // 
            this.btnMsgStart.Location = new System.Drawing.Point(40, 232);
            this.btnMsgStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnMsgStart.Name = "btnMsgStart";
            this.btnMsgStart.Size = new System.Drawing.Size(323, 46);
            this.btnMsgStart.TabIndex = 20;
            this.btnMsgStart.Text = "开始提示监测";
            this.btnMsgStart.UseVisualStyleBackColor = true;
            this.btnMsgStart.Click += new System.EventHandler(this.BtnMsgStart_Click);
            // 
            // btnMsgStop
            // 
            this.btnMsgStop.Location = new System.Drawing.Point(40, 300);
            this.btnMsgStop.Margin = new System.Windows.Forms.Padding(6);
            this.btnMsgStop.Name = "btnMsgStop";
            this.btnMsgStop.Size = new System.Drawing.Size(323, 46);
            this.btnMsgStop.TabIndex = 19;
            this.btnMsgStop.Text = "停止提示监测";
            this.btnMsgStop.UseVisualStyleBackColor = true;
            this.btnMsgStop.Click += new System.EventHandler(this.BtnMsgStop_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(40, 164);
            this.btnStop.Margin = new System.Windows.Forms.Padding(6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(323, 46);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "停止监测";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnGetGroup
            // 
            this.btnGetGroup.Location = new System.Drawing.Point(40, 23);
            this.btnGetGroup.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetGroup.Name = "btnGetGroup";
            this.btnGetGroup.Size = new System.Drawing.Size(323, 46);
            this.btnGetGroup.TabIndex = 18;
            this.btnGetGroup.Text = "获取QQ群";
            this.btnGetGroup.UseVisualStyleBackColor = true;
            this.btnGetGroup.Click += new System.EventHandler(this.BtnGetGroup_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 94);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(323, 46);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "开始监测";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 619);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1500, 5);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "新增历史记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1326);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "获取成员";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewQQ)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNewQQ;
        private System.Windows.Forms.DataGridView dgvQQ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQNewNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQNum;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupNum;
        private System.Windows.Forms.Button btnGetGroup;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnMsgStart;
        private System.Windows.Forms.Button btnMsgStop;
        private System.Windows.Forms.Button button1;
    }
}

