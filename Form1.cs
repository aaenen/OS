using System;
using System.Data;
using System.Windows.Forms;

namespace 两道批处理系统的两级调度_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 创建一个内存中正在执行的进程的表
        /// </summary>
        DataTable ProcessingOnProcess;
        /// <summary>
        /// 创建一个已提交作业队列的表
        /// </summary>
        DataTable SubmittedJobQueue;
        /// <summary>
        /// 创建一个内存中就绪的进程队列的表
        /// </summary>
        DataTable ReadyProcessQueue;
        /// <summary>
        /// 创建一个未提交作业队列的表
        /// </summary>
        DataTable JobQueueNotSubmitted;
        /// <summary>
        /// 创建一个已完成作业队列的表
        /// </summary>
        DataTable JobSchedulingResults;
        /// <summary>
        /// 定义了一个全局变量，显示当前时间
        /// </summary>
        int CurrentMoment = 1000;
        /// <summary>
        /// 定义了一个全局变量，显示已运行了的时间
        /// </summary>
        int CumulativeTime = 0;
        /// <summary>
        /// 定义了一个全局变量，显示平均带权周转时间
        /// </summary>
        double AverageWeightedTurnaroundTime = 0;
        /// <summary>
        /// 定义了一个全局变量，显示平均周转时间
        /// </summary>
        double AverageTurnaroundTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             在程序一运行就创建表
             */
            InitProcessingOnProcess();
            InitSubmittedJobQueue();
            InitReadyProcessQueue();
            InitJobQueueNotSubmitted();
            InitJobSchedulingResults();

            InsertData();                           //导入实验数据
            buttonStop.Enabled = false;            //开局默认暂停按钮不可用
        }

        /// <summary>
        /// 在“内存正在执行的进程”的表中插入数据
        /// </summary>
        private void InitProcessingOnProcess()
        {
            ProcessingOnProcess = new DataTable();
            ProcessingOnProcess.Columns.Add("作业名称", typeof(string));
            ProcessingOnProcess.Columns.Add("到达时间", typeof(int));
            ProcessingOnProcess.Columns.Add("估计运行时间", typeof(int));
            ProcessingOnProcess.Columns.Add("进入内存时间", typeof(int));
            ProcessingOnProcess.Columns.Add("开始时间", typeof(int));
            ProcessingOnProcess.Columns.Add("已用时间", typeof(int));
            ProcessingOnProcess.Columns.Add("剩余时间", typeof(int));
            ProcessingOnProcess.Columns.Add("优先数", typeof(int));
            ProcessingOnProcess.Columns.Add("当前状态", typeof(string));
            dataGridViewProcessingOnProcess.DataSource = ProcessingOnProcess;          //Partition表的数据源是Partition
            dataGridViewProcessingOnProcess.AutoGenerateColumns = true;                //可以自动生成列
        }

        /// <summary>
        /// 在一个“已提交作业队列”的表中插入数据
        /// </summary>
        private void InitSubmittedJobQueue()
        {
            SubmittedJobQueue = new DataTable();
            SubmittedJobQueue.Columns.Add("作业名称", typeof(string));
            SubmittedJobQueue.Columns.Add("到达时间", typeof(int));
            SubmittedJobQueue.Columns.Add("估计运行时间", typeof(int));
            SubmittedJobQueue.Columns.Add("优先数", typeof(int));
            SubmittedJobQueue.Columns.Add("当前状态", typeof(string));
            dataGridViewSubmittedJobQueue.DataSource = SubmittedJobQueue;          //SubmittedJobQueue表的数据源是SubmittedJobQueue
            dataGridViewSubmittedJobQueue.AutoGenerateColumns = true;                //可以自动生成列
        }

        /// <summary>
        /// 在“内存中就绪的进程队列”的表中插入数据
        /// </summary>
        private void InitReadyProcessQueue()
        {
            ReadyProcessQueue = new DataTable();
            ReadyProcessQueue.Columns.Add("作业名称", typeof(string));
            ReadyProcessQueue.Columns.Add("到达时间", typeof(int));
            ReadyProcessQueue.Columns.Add("估计运行时间", typeof(int));
            ReadyProcessQueue.Columns.Add("进入内存时间", typeof(int));
            ReadyProcessQueue.Columns.Add("开始时间", typeof(int));
            ReadyProcessQueue.Columns.Add("已用时间", typeof(int));
            ReadyProcessQueue.Columns.Add("剩余时间", typeof(int));
            ReadyProcessQueue.Columns.Add("优先数", typeof(int));
            ReadyProcessQueue.Columns.Add("当前状态", typeof(string));
            dataGridViewReadyProcessQueue.DataSource = ReadyProcessQueue;          //ReadyProcessQueue表的数据源是ReadyProcessQueue
            dataGridViewReadyProcessQueue.AutoGenerateColumns = true;                //可以自动生成列
        }

        /// <summary>
        /// 在“未提交作业队列”的表中插入数据
        /// </summary>
        private void InitJobQueueNotSubmitted()
        {
            JobQueueNotSubmitted = new DataTable();
            JobQueueNotSubmitted.Columns.Add("作业名称", typeof(string));
            JobQueueNotSubmitted.Columns.Add("到达时间", typeof(int));
            JobQueueNotSubmitted.Columns.Add("估计运行时间", typeof(int));
            JobQueueNotSubmitted.Columns.Add("优先数", typeof(int));
            JobQueueNotSubmitted.Columns.Add("当前状态", typeof(string));
            dataGridViewJobQueueNotSubmitted.DataSource = JobQueueNotSubmitted;          //JobQueueNotSubmitted表的数据源是JobQueueNotSubmitted
            dataGridViewJobQueueNotSubmitted.AutoGenerateColumns = true;                //可以自动生成列
        }

        /// <summary>
        /// 在“已完成队列”的表中插入数据
        /// </summary>
        private void InitJobSchedulingResults()
        {
            JobSchedulingResults = new DataTable();
            JobSchedulingResults.Columns.Add("作业名称", typeof(string));
            JobSchedulingResults.Columns.Add("到达时间", typeof(int));
            JobSchedulingResults.Columns.Add("估计运行时间", typeof(int));
            JobSchedulingResults.Columns.Add("进入内存时间", typeof(int));
            JobSchedulingResults.Columns.Add("开始时间", typeof(int));
            JobSchedulingResults.Columns.Add("结束时间", typeof(int));
            JobSchedulingResults.Columns.Add("优先数", typeof(int));
            JobSchedulingResults.Columns.Add("周转时间", typeof(int));
            JobSchedulingResults.Columns.Add("带权周转时间", typeof(double));
            JobSchedulingResults.Columns.Add("当前状态", typeof(string));
            dataGridViewJobSchedulingResults.DataSource = JobSchedulingResults;          //JobSchedulingResults表的数据源是JobSchedulingResults
            dataGridViewJobSchedulingResults.AutoGenerateColumns = true;                //可以自动生成列
        }
        private void InsertData()
        {
            DataRow dr = JobQueueNotSubmitted.NewRow();
            dr.SetField("作业名称", "JOB1");
            dr.SetField("到达时间", 1000);
            dr.SetField("估计运行时间", 40);
            dr.SetField("优先数", 5);
            dr.SetField("当前状态", "未提交");
            JobQueueNotSubmitted.Rows.Add(dr);
            DataRow dr2 = JobQueueNotSubmitted.NewRow();
            dr2.SetField("作业名称", "JOB2");
            dr2.SetField("到达时间", 1020);
            dr2.SetField("估计运行时间", 30);
            dr2.SetField("优先数", 3);
            dr2.SetField("当前状态", "未提交");
            JobQueueNotSubmitted.Rows.Add(dr2);
            DataRow dr3 = JobQueueNotSubmitted.NewRow();
            dr3.SetField("作业名称", "JOB3");
            dr3.SetField("到达时间", 1030);
            dr3.SetField("估计运行时间", 50);
            dr3.SetField("优先数", 4);
            dr3.SetField("当前状态", "未提交");
            JobQueueNotSubmitted.Rows.Add(dr3);
            DataRow dr4 = JobQueueNotSubmitted.NewRow();
            dr4.SetField("作业名称", "JOB4");
            dr4.SetField("到达时间", 1050);
            dr4.SetField("估计运行时间", 20);
            dr4.SetField("优先数", 6);
            dr4.SetField("当前状态", "未提交");
            JobQueueNotSubmitted.Rows.Add(dr4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NoSubmitToSubmitted(CurrentMoment);                              //未提交作业队列提交到已提交作业队列
            SubmittedJobQueueSort();                                         //每个时刻都要对已提交作业队列中的表按估计运行时间升序
            labelCurrentMoment.Text = CurrentMoment.ToString();             //显示当前时刻
            labelCumulativeTime.Text = CumulativeTime.ToString();           //显示已运行时间

            /*
             判断结束的标志，“未提交作业队列”“就绪作业队列”“正在执行的进程”“内存中就绪的队列”四表为空，则结束
             */
            if (ProcessingOnProcess.Rows.Count == 0 && SubmittedJobQueue.Rows.Count == 0 && ReadyProcessQueue.Rows.Count == 0 && JobQueueNotSubmitted.Rows.Count == 0)
            {
                timer1.Stop();          //停止时间片轮转
                MessageBox.Show("恭喜你，运行完成！");
                //CurrentMoment = 0;
                labelCurrentMoment.Text = CurrentMoment.ToString();
                buttonRun.Enabled = false;           //上锁，不可以点击运行按钮，重置后才可以点
                buttonStepByStep.Enabled = false;      //上锁，不可以点击暂停按钮，重置后才可以点
                buttonStop.Enabled = false;           //上锁，不可以点击单步运行按钮，重置后才可以点
                return;
            }

            /*
             内存中的正在执行的进程队列调到已完成作业队列，判断标志是正在执行的进程的剩余时间=0
             */
            if (ProcessingOnProcess.Rows.Count !=0 && ProcessingOnProcess.Rows[0].Field<int>("剩余时间") == 0)
            {
                RunToResult(CurrentMoment);
            }

            /*
             已提交作业队列到内存中的就绪的进程队列，判断标志内存中的就绪的进程队列行数+正在执行的进程队列行数<2且已提交作业队列的行数>0
             */
            if (ProcessingOnProcess.Rows.Count + ReadyProcessQueue.Rows.Count < 2 && SubmittedJobQueue.Rows.Count > 0)
            {
                SubmittedToReady();
                ReadyProcessQueueSort();
            }

            /*
             内存中的就绪的进程队列到内存中正在执行的进程队列，判断标志内存中的就绪的进程队列行数>0且内存中正在执行的进程队列
             */
            if (ReadyProcessQueue.Rows.Count > 0 && ProcessingOnProcess.Rows.Count == 0)
            {
                ReadyToRun(CurrentMoment);
            }

            /*
             判断是否有抢占，有则执行抢占
             判断标志是内存中正在执行的进程和内存中就绪的进程队列的行数==1，且优先数符合条件*/
            if (ReadyProcessQueue.Rows.Count == 1  && ProcessingOnProcess.Rows.Count == 1 && ProcessingOnProcess.Rows[0].Field<int>("优先数") > ReadyProcessQueue.Rows[0].Field<int>("优先数"))
            {
                RunToReady();
                ReadyToRun(CurrentMoment);
            }

            /*
             修改已用时间、剩余时间
             */
            if (ProcessingOnProcess.Rows.Count != 0)
            {
                ChangeTime();
            }

            /*
            修改平均带权周转时间和平均周转时间，判断标志是已完成进程队列中有数据
            labelAverageTurnaroundTime修改平均周转时间
            */
            if (JobSchedulingResults.Rows.Count != 0)
            {
                CalculateAverageWeightedTurnaroundTime(ref AverageWeightedTurnaroundTime, ref AverageTurnaroundTime);
                labelAverageWeightedTurnaroundTime.Text = AverageWeightedTurnaroundTime.ToString("N3");             //显示平均带权周转时间
                labelAverageTurnaroundTime.Text = AverageTurnaroundTime.ToString("N3");             //显示平均周转时间
            }

            /*
             每一个时钟周期，当前时间和累计运行时间+1
             */
            CurrentMoment++;
            if (CurrentMoment % 100 == 60)
            {
                CurrentMoment += 40;
            }
            CumulativeTime++;
        }
        /// <summary>
        /// 将未提交的作业提交到已提交作业队列
        /// </summary>
        /// <param name="CurrentMoment">传入当前时刻，设为到达时间</param>
        private void NoSubmitToSubmitted(int CurrentMoment)
        {
            DataRow[] drs = JobQueueNotSubmitted.Select("到达时间 = " + CurrentMoment.ToString(), "到达时间 ASC");
            foreach (DataRow dr in drs)
            {
                dr.SetField("当前状态", "已提交");
                SubmittedJobQueue.ImportRow(dr);
            }
            foreach (DataRow dr in drs)
            {
                JobQueueNotSubmitted.Rows.Remove(dr);
            }
        }

        /// <summary>
        /// 点击运行按钮触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Run_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;         //点击运行后，除非暂停和重置，不然不能再次运行
            buttonStop.Enabled = true;         //运行后，可以暂停
            timer1.Interval = int.Parse(textBoxClock.Text);//修改时钟周期
            timer1.Enabled = true;      //打开timer
            timer1.Start();             //开启时刻
            textBoxClock.Enabled = false;               //上锁，开始运行后就不能再输入时钟周期了
        }

        /// <summary>
        /// 点击暂停按钮触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3Stop_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = true;           //点击暂停后，能再次运行
            buttonStop.Enabled = false;         //暂停后，不可以再暂停
            timer1.Stop();              //停止时刻
            timer1.Enabled = false;     //关闭timer 
        }

        /// <summary>
        /// 点击重置后触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2Reset_Click(object sender, EventArgs e)
        {
            /*
             点击重置后，两个按钮恢复原来的状态，即运行可以按，暂停不可以按，可以修改时钟周期
             */
            buttonStop.Enabled = false;
            buttonRun.Enabled = true;
            textBoxClock.Enabled = true;
            buttonStepByStep.Enabled = true;

            timer1.Stop();                      //停止时间表
            /*
             清空五个表格，并往“未提交作业队列中添加已有数据”
             */
            ProcessingOnProcess.Rows.Clear();
            SubmittedJobQueue.Rows.Clear();
            ReadyProcessQueue.Rows.Clear();
            JobQueueNotSubmitted.Rows.Clear();
            JobSchedulingResults.Rows.Clear();

            InsertData();                           //导入实验数据

            /*
             * 当前时刻归1000，累计时间归0,时钟周期归500
             */
            CurrentMoment = 1000;
            labelCurrentMoment.Text = CurrentMoment.ToString();
            CumulativeTime = 0;
            labelCumulativeTime.Text = CumulativeTime.ToString();
            textBoxClock.Text = "500";
        }

        /// <summary>
        /// 定义一个方法，对已提交作业队列中的表进行排序
        /// </summary>
        private void SubmittedJobQueueSort()
        {
            SubmittedJobQueue.DefaultView.Sort = "到达时间 ASC";    //对界面上的表进行排序
            /*
             对内存里面的就绪作业队列按照到达时间升序（ASC）
             */
            DataView dv = SubmittedJobQueue.DefaultView;
            dv.Sort = "到达时间 ASC";
            SubmittedJobQueue = dv.ToTable().Copy();
            dataGridViewSubmittedJobQueue.DataSource = SubmittedJobQueue;
        }

        /// <summary>
        /// 定义一个方法，对内存中的就绪的进程队列中的表进行排序
        /// </summary>
        private void ReadyProcessQueueSort()
        {
            ReadyProcessQueue.DefaultView.Sort = "优先数 ASC";    //对界面上的表进行排序
            /*
             对内存里面的就绪作业队列按照优先数升序（ASC）
             */
            DataView dv = ReadyProcessQueue.DefaultView;
            dv.Sort = "优先数 ASC";
            ReadyProcessQueue = dv.ToTable().Copy();
            dataGridViewReadyProcessQueue.DataSource = ReadyProcessQueue;
        }

        /// <summary>
        /// 定义一个方法，把已提交作业队列中符合条件的提取到内存中就绪的进程队列
        /// </summary>
        private void SubmittedToReady()
        {
            DataRow dr = ReadyProcessQueue.NewRow();
            DataRow dr2 = SubmittedJobQueue.Rows[0];
            dr.SetField("作业名称", dr2.Field<string>("作业名称"));
            dr.SetField("到达时间", dr2.Field<int>("到达时间"));
            dr.SetField("估计运行时间", dr2.Field<int>("估计运行时间"));
            dr.SetField("进入内存时间", CurrentMoment);
            dr["开始时间"] = DBNull.Value;
            dr.SetField("已用时间", 0);
            dr.SetField("剩余时间", dr2.Field<int>("估计运行时间"));
            dr.SetField("优先数", dr2.Field<int>("优先数"));
            dr.SetField("当前状态", "就绪");
            ReadyProcessQueue.Rows.Add(dr);
            SubmittedJobQueue.Rows.RemoveAt(0);
        }

        /// <summary>
        /// 定义一个方法,把内存中的就绪的进程队列掉到内存中正在执行的进程队列
        /// </summary>
        /// <param name="CurrentMoment"></param>
        private void ReadyToRun(int CurrentMoment)
        {
            DataRow dr = ProcessingOnProcess.NewRow();
            DataRow dr2 = ReadyProcessQueue.Rows[0];
            dr.SetField("作业名称", dr2.Field<string>("作业名称"));
            dr.SetField("到达时间", dr2.Field<int>("到达时间"));
            dr.SetField("估计运行时间", dr2.Field<int>("估计运行时间"));
            dr.SetField("进入内存时间", dr2.Field<int>("进入内存时间"));
            if (dr2["开始时间"] == DBNull.Value)
            {
                dr.SetField("开始时间", CurrentMoment);
            }
            else
            {
                dr.SetField("开始时间", dr2.Field<int>("开始时间"));
            }
            dr.SetField("已用时间", dr2.Field<int>("已用时间"));
            dr.SetField("剩余时间", dr2.Field<int>("剩余时间"));
            dr.SetField("优先数", dr2.Field<int>("优先数"));
            dr.SetField("当前状态", "执行中");
            ProcessingOnProcess.Rows.Add(dr);
            ReadyProcessQueue.Rows.RemoveAt(0);
        }

        /// <summary>
        /// 计算周转时间
        /// </summary>
        /// <param name="workSubmitTime"></param>
        /// <returns></returns>
        private int TurnoverTime(int workSubmitTime)
        {
            int workNeedminute = workSubmitTime % 100;
            int workNeedhour = (workSubmitTime % 1000 - workNeedminute) / 100;
            int nowTimeminute = CurrentMoment % 100;
            int nowTimeHour = (CurrentMoment % 1000 - nowTimeminute) / 100;
            int turnoverTime = nowTimeHour * 60 + nowTimeminute - workNeedhour * 60 - workNeedminute ;
            return turnoverTime;
        }
        /// <summary>
        /// 计算带权周转时间
        /// </summary>
        /// <param name="workSubmitTime"></param>
        /// <param name="workneedTime"></param>
        /// <returns></returns>
        private double WeightedTurnoverTime(int workSubmitTime, int workneedTime)
        {
            int workSubmitminute = workSubmitTime % 100;
            int workSubmithour = (workSubmitTime % 1000 - workSubmitminute) / 100;
            int nowTimeminute = CurrentMoment % 100;
            int nowTimeHour = (CurrentMoment % 1000 - nowTimeminute) / 100;
            int turnoverTime = nowTimeHour * 60 + nowTimeminute - workSubmithour * 60 - workSubmitminute ;
            double weighterTurnoverTime = ((double)turnoverTime) / ((double)workneedTime);
            return weighterTurnoverTime;
        }
        /// <summary>
        ///修改内存中正在执行的进程的已用时间、剩余时间
        /// </summary>
        private void ChangeTime()
        {
            DataRow dr = ProcessingOnProcess.Rows[0];
            dr.SetField("已用时间", dr.Field<int>("已用时间") + 1);         //每过一个时刻，已用时间+1
            dr.SetField("剩余时间", dr.Field<int>("剩余时间") - 1);         //每过一个时刻，剩余时间-1
        }

        /// <summary>
        /// 定义一个方法,把内存中的正在执行的进程队列调到内存中就绪的进程队列
        /// </summary>
        private void RunToReady()
        {
            DataRow dr = ReadyProcessQueue.NewRow();
            DataRow dr2 = ProcessingOnProcess.Rows[0];
            dr.SetField("作业名称", dr2.Field<string>("作业名称"));
            dr.SetField("到达时间", dr2.Field<int>("到达时间"));
            dr.SetField("估计运行时间", dr2.Field<int>("估计运行时间"));
            dr.SetField("进入内存时间", dr2.Field<int>("进入内存时间"));
            dr.SetField("开始时间", dr2.Field<int>("开始时间"));
            dr.SetField("已用时间", dr2.Field<int>("已用时间"));
            dr.SetField("剩余时间", dr2.Field<int>("剩余时间"));
            dr.SetField("优先数", dr2.Field<int>("优先数"));
            dr.SetField("当前状态", "就绪");
            ReadyProcessQueue.Rows.Add(dr);
            ProcessingOnProcess.Rows.RemoveAt(0);
        }

        /// <summary>
        /// 定义一个方法,把内存中的正在执行的进程队列调到已完成作业队列
        /// </summary>
        private void RunToResult(int CurrentMoment)
        {
            DataRow dr = JobSchedulingResults.NewRow();
            DataRow dr2 = ProcessingOnProcess.Rows[0];
            dr.SetField("作业名称", dr2.Field<string>("作业名称"));
            dr.SetField("到达时间", dr2.Field<int>("到达时间"));
            dr.SetField("估计运行时间", dr2.Field<int>("估计运行时间"));
            dr.SetField("进入内存时间", dr2.Field<int>("进入内存时间"));
            dr.SetField("开始时间", dr2.Field<int>("开始时间"));
            dr.SetField("结束时间", CurrentMoment);
            dr.SetField("优先数", dr2.Field<int>("优先数"));
            dr.SetField("周转时间", TurnoverTime(dr2.Field<int>("到达时间")));
            dr.SetField("带权周转时间", WeightedTurnoverTime(dr2.Field<int>("到达时间"), dr2.Field<int>("估计运行时间")));
            dr.SetField("当前状态", "已完成");
            JobSchedulingResults.Rows.Add(dr);
            ProcessingOnProcess.Rows.RemoveAt(0);
        }

        /// <summary>
        /// 定义一个计算平均带权周转时间、平均周转时间的方法
        /// </summary>
        /// <param name="AverageWeightedTurnaroundTime"></param>
        /// <param name="AverageTurnaroundTime"></param>
        private void CalculateAverageWeightedTurnaroundTime(ref double AverageWeightedTurnaroundTime, ref double AverageTurnaroundTime)
        {
            double sum = 0;
            double sum2 = 0;
            double num = JobSchedulingResults.Rows.Count;
            foreach (DataRow dr in JobSchedulingResults.Rows)
            {
                sum += dr.Field<double>("带权周转时间");
                sum2 += dr.Field<int>("周转时间");
            }
            AverageWeightedTurnaroundTime = sum / num;
            AverageTurnaroundTime = sum2 / num;

        }

        private void buttonStepByStep_Click(object sender, EventArgs e)
        {
            timer1.Stop();              //停止时刻
            timer1.Enabled = false;     //关闭timer
            buttonRun.Enabled = true;           //点击单步执行后，能再次运行
            buttonStop.Enabled = false;         //点击单步执行后，不可以再暂停
            NoSubmitToSubmitted(CurrentMoment);                              //未提交作业队列提交到已提交作业队列
            SubmittedJobQueueSort();                                         //每个时刻都要对已提交作业队列中的表按估计运行时间升序
            labelCurrentMoment.Text = CurrentMoment.ToString();             //显示当前时刻
            labelCumulativeTime.Text = CumulativeTime.ToString();           //显示已运行时间

            /*
             判断结束的标志，“未提交作业队列”“就绪作业队列”“正在执行的进程”“内存中就绪的队列”四表为空，则结束
             */
            if (ProcessingOnProcess.Rows.Count == 0 && SubmittedJobQueue.Rows.Count == 0 && ReadyProcessQueue.Rows.Count == 0 && JobQueueNotSubmitted.Rows.Count == 0)
            {
                timer1.Stop();          //停止时间片轮转
                MessageBox.Show("恭喜你，运行完成！");
                //CurrentMoment = 0;
                labelCurrentMoment.Text = CurrentMoment.ToString();
                buttonRun.Enabled = false;           //上锁，不可以点击运行按钮，重置后才可以点
                buttonStepByStep.Enabled = false;      //上锁，不可以点击暂停按钮，重置后才可以点
                buttonStop.Enabled = false;           //上锁，不可以点击单步运行按钮，重置后才可以点
                return;
            }

            /*
             内存中的正在执行的进程队列调到已完成作业队列，判断标志是正在执行的进程的剩余时间=0
             */
            if (ProcessingOnProcess.Rows.Count != 0 && ProcessingOnProcess.Rows[0].Field<int>("剩余时间") == 0)
            {
                RunToResult(CurrentMoment);
            }

            /*
             已提交作业队列到内存中的就绪的进程队列，判断标志内存中的就绪的进程队列行数+正在执行的进程队列行数<2且已提交作业队列的行数>0
             */
            if (ProcessingOnProcess.Rows.Count + ReadyProcessQueue.Rows.Count < 2 && SubmittedJobQueue.Rows.Count > 0)
            {
                SubmittedToReady();
                ReadyProcessQueueSort();
            }

            /*
             内存中的就绪的进程队列到内存中正在执行的进程队列，判断标志内存中的就绪的进程队列行数>0且内存中正在执行的进程队列
             */
            if (ReadyProcessQueue.Rows.Count > 0 && ProcessingOnProcess.Rows.Count == 0)
            {
                ReadyToRun(CurrentMoment);
            }

            /*
             判断是否有抢占，有则执行抢占
             判断标志是内存中正在执行的进程和内存中就绪的进程队列的行数==1，且优先数符合条件*/
            if (ReadyProcessQueue.Rows.Count == 1 && ProcessingOnProcess.Rows.Count == 1 && ProcessingOnProcess.Rows[0].Field<int>("优先数") > ReadyProcessQueue.Rows[0].Field<int>("优先数"))
            {
                RunToReady();
                ReadyToRun(CurrentMoment);
            }

            /*
             修改已用时间、剩余时间
             */
            if (ProcessingOnProcess.Rows.Count != 0)
            {
                ChangeTime();
            }

            /*
            修改平均带权周转时间和平均周转时间，判断标志是已完成进程队列中有数据
            labelAverageTurnaroundTime修改平均周转时间
            */
            if (JobSchedulingResults.Rows.Count != 0)
            {
                CalculateAverageWeightedTurnaroundTime(ref AverageWeightedTurnaroundTime, ref AverageTurnaroundTime);
                labelAverageWeightedTurnaroundTime.Text = AverageWeightedTurnaroundTime.ToString("N3");             //显示平均带权周转时间
                labelAverageTurnaroundTime.Text = AverageTurnaroundTime.ToString("N3");             //显示平均周转时间
            }

            /*
             每一个时钟周期，当前时间和累计运行时间+1
             */
            CurrentMoment++;
            if (CurrentMoment % 100 == 60)
            {
                CurrentMoment += 40;
            }
            CumulativeTime++;
        }
    }
}
