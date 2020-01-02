namespace 两道批处理系统的两级调度_2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentMoment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCumulativeTime = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.dataGridViewSubmittedJobQueue = new System.Windows.Forms.DataGridView();
            this.dataGridViewJobQueueNotSubmitted = new System.Windows.Forms.DataGridView();
            this.dataGridViewReadyProcessQueue = new System.Windows.Forms.DataGridView();
            this.dataGridViewJobSchedulingResults = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelAverageTurnaroundTime = new System.Windows.Forms.Label();
            this.labelAverageWeightedTurnaroundTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewProcessingOnProcess = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStepByStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubmittedJobQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobQueueNotSubmitted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadyProcessQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobSchedulingResults)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessingOnProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRun.Location = new System.Drawing.Point(192, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(150, 72);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "运行";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.button1Run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(924, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "时钟周期/ms";
            // 
            // textBoxClock
            // 
            this.textBoxClock.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxClock.Location = new System.Drawing.Point(928, 48);
            this.textBoxClock.Name = "textBoxClock";
            this.textBoxClock.Size = new System.Drawing.Size(86, 26);
            this.textBoxClock.TabIndex = 4;
            this.textBoxClock.Text = "500";
            this.textBoxClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前时间:";
            // 
            // labelCurrentMoment
            // 
            this.labelCurrentMoment.AutoSize = true;
            this.labelCurrentMoment.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrentMoment.Location = new System.Drawing.Point(127, 23);
            this.labelCurrentMoment.Name = "labelCurrentMoment";
            this.labelCurrentMoment.Size = new System.Drawing.Size(50, 22);
            this.labelCurrentMoment.TabIndex = 6;
            this.labelCurrentMoment.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "累计运行时间:";
            // 
            // labelCumulativeTime
            // 
            this.labelCumulativeTime.AutoSize = true;
            this.labelCumulativeTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCumulativeTime.Location = new System.Drawing.Point(128, 52);
            this.labelCumulativeTime.Name = "labelCumulativeTime";
            this.labelCumulativeTime.Size = new System.Drawing.Size(20, 22);
            this.labelCumulativeTime.TabIndex = 8;
            this.labelCumulativeTime.Text = "0";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReset.Location = new System.Drawing.Point(377, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 72);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "重 置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button2Reset_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStop.Location = new System.Drawing.Point(562, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(150, 72);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "暂 停";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button3Stop_Click);
            // 
            // dataGridViewSubmittedJobQueue
            // 
            this.dataGridViewSubmittedJobQueue.AllowUserToAddRows = false;
            this.dataGridViewSubmittedJobQueue.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataGridViewSubmittedJobQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewSubmittedJobQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubmittedJobQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewSubmittedJobQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubmittedJobQueue.EnableHeadersVisualStyles = false;
            this.dataGridViewSubmittedJobQueue.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewSubmittedJobQueue.Name = "dataGridViewSubmittedJobQueue";
            this.dataGridViewSubmittedJobQueue.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSubmittedJobQueue.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewSubmittedJobQueue.RowTemplate.Height = 23;
            this.dataGridViewSubmittedJobQueue.Size = new System.Drawing.Size(409, 166);
            this.dataGridViewSubmittedJobQueue.TabIndex = 11;
            // 
            // dataGridViewJobQueueNotSubmitted
            // 
            this.dataGridViewJobQueueNotSubmitted.AllowUserToAddRows = false;
            this.dataGridViewJobQueueNotSubmitted.AllowUserToOrderColumns = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridViewJobQueueNotSubmitted.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewJobQueueNotSubmitted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJobQueueNotSubmitted.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewJobQueueNotSubmitted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobQueueNotSubmitted.EnableHeadersVisualStyles = false;
            this.dataGridViewJobQueueNotSubmitted.Location = new System.Drawing.Point(0, 244);
            this.dataGridViewJobQueueNotSubmitted.Name = "dataGridViewJobQueueNotSubmitted";
            this.dataGridViewJobQueueNotSubmitted.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewJobQueueNotSubmitted.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewJobQueueNotSubmitted.RowTemplate.Height = 23;
            this.dataGridViewJobQueueNotSubmitted.Size = new System.Drawing.Size(409, 166);
            this.dataGridViewJobQueueNotSubmitted.TabIndex = 12;
            // 
            // dataGridViewReadyProcessQueue
            // 
            this.dataGridViewReadyProcessQueue.AllowUserToAddRows = false;
            this.dataGridViewReadyProcessQueue.AllowUserToOrderColumns = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dataGridViewReadyProcessQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewReadyProcessQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReadyProcessQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewReadyProcessQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReadyProcessQueue.EnableHeadersVisualStyles = false;
            this.dataGridViewReadyProcessQueue.Location = new System.Drawing.Point(429, 37);
            this.dataGridViewReadyProcessQueue.Name = "dataGridViewReadyProcessQueue";
            this.dataGridViewReadyProcessQueue.RowHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewReadyProcessQueue.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewReadyProcessQueue.RowTemplate.Height = 23;
            this.dataGridViewReadyProcessQueue.Size = new System.Drawing.Size(647, 166);
            this.dataGridViewReadyProcessQueue.TabIndex = 13;
            // 
            // dataGridViewJobSchedulingResults
            // 
            this.dataGridViewJobSchedulingResults.AllowUserToAddRows = false;
            this.dataGridViewJobSchedulingResults.AllowUserToOrderColumns = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dataGridViewJobSchedulingResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewJobSchedulingResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJobSchedulingResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewJobSchedulingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobSchedulingResults.EnableHeadersVisualStyles = false;
            this.dataGridViewJobSchedulingResults.Location = new System.Drawing.Point(429, 244);
            this.dataGridViewJobSchedulingResults.Name = "dataGridViewJobSchedulingResults";
            this.dataGridViewJobSchedulingResults.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewJobSchedulingResults.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewJobSchedulingResults.RowTemplate.Height = 23;
            this.dataGridViewJobSchedulingResults.Size = new System.Drawing.Size(647, 166);
            this.dataGridViewJobSchedulingResults.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "已提交作业队列";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "未提交的作业队列";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(425, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "内存中就绪的进程队列";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(425, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "已完成作业队列";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(425, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "平均周转时间:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(758, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "平均带权周转时间:";
            // 
            // labelAverageTurnaroundTime
            // 
            this.labelAverageTurnaroundTime.AutoSize = true;
            this.labelAverageTurnaroundTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAverageTurnaroundTime.Location = new System.Drawing.Point(527, 413);
            this.labelAverageTurnaroundTime.Name = "labelAverageTurnaroundTime";
            this.labelAverageTurnaroundTime.Size = new System.Drawing.Size(20, 22);
            this.labelAverageTurnaroundTime.TabIndex = 21;
            this.labelAverageTurnaroundTime.Text = "0";
            // 
            // labelAverageWeightedTurnaroundTime
            // 
            this.labelAverageWeightedTurnaroundTime.AutoSize = true;
            this.labelAverageWeightedTurnaroundTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAverageWeightedTurnaroundTime.Location = new System.Drawing.Point(888, 412);
            this.labelAverageWeightedTurnaroundTime.Name = "labelAverageWeightedTurnaroundTime";
            this.labelAverageWeightedTurnaroundTime.Size = new System.Drawing.Size(20, 22);
            this.labelAverageWeightedTurnaroundTime.TabIndex = 22;
            this.labelAverageWeightedTurnaroundTime.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAverageWeightedTurnaroundTime);
            this.panel1.Controls.Add(this.labelAverageTurnaroundTime);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridViewJobSchedulingResults);
            this.panel1.Controls.Add(this.dataGridViewReadyProcessQueue);
            this.panel1.Controls.Add(this.dataGridViewJobQueueNotSubmitted);
            this.panel1.Controls.Add(this.dataGridViewSubmittedJobQueue);
            this.panel1.Location = new System.Drawing.Point(16, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 457);
            this.panel1.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(17, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "内存中正在执行的进程";
            // 
            // dataGridViewProcessingOnProcess
            // 
            this.dataGridViewProcessingOnProcess.AllowUserToAddRows = false;
            this.dataGridViewProcessingOnProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcessingOnProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessingOnProcess.Location = new System.Drawing.Point(16, 122);
            this.dataGridViewProcessingOnProcess.Name = "dataGridViewProcessingOnProcess";
            this.dataGridViewProcessingOnProcess.RowHeadersVisible = false;
            this.dataGridViewProcessingOnProcess.RowTemplate.Height = 23;
            this.dataGridViewProcessingOnProcess.Size = new System.Drawing.Size(1076, 61);
            this.dataGridViewProcessingOnProcess.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStepByStep
            // 
            this.buttonStepByStep.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStepByStep.Location = new System.Drawing.Point(748, 12);
            this.buttonStepByStep.Name = "buttonStepByStep";
            this.buttonStepByStep.Size = new System.Drawing.Size(150, 72);
            this.buttonStepByStep.TabIndex = 26;
            this.buttonStepByStep.Text = "单步执行";
            this.buttonStepByStep.UseVisualStyleBackColor = true;
            this.buttonStepByStep.Click += new System.EventHandler(this.buttonStepByStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 629);
            this.Controls.Add(this.buttonStepByStep);
            this.Controls.Add(this.dataGridViewProcessingOnProcess);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelCumulativeTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCurrentMoment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "两道批处理系统的两级调度-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubmittedJobQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobQueueNotSubmitted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadyProcessQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobSchedulingResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessingOnProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentMoment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCumulativeTime;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.DataGridView dataGridViewSubmittedJobQueue;
        private System.Windows.Forms.DataGridView dataGridViewJobQueueNotSubmitted;
        private System.Windows.Forms.DataGridView dataGridViewReadyProcessQueue;
        private System.Windows.Forms.DataGridView dataGridViewJobSchedulingResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelAverageTurnaroundTime;
        private System.Windows.Forms.Label labelAverageWeightedTurnaroundTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewProcessingOnProcess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStepByStep;
    }
}

