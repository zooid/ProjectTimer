using System.Diagnostics;


namespace stopwatch_project
{
    public partial class Form1 : Form
    {
        Stopwatch timer0;
        Stopwatch timer1;
        Stopwatch timer2;
        Stopwatch timer3;
        Stopwatch timer4;
        
        System.Windows.Forms.Timer _timer;
        public Form1()
        {
            InitializeComponent();
            timer0 = new Stopwatch();
            timer1 = new Stopwatch();
            timer2 = new Stopwatch();
            timer3 = new Stopwatch();
            timer4 = new Stopwatch();

            _timer = new System.Windows.Forms.Timer();
            _timer.Start();
            _timer.Interval = 1000;
            #pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            _timer.Tick += new EventHandler(_timer_Tick);
            #pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            
            long ticks = timer1.ElapsedTicks;
            long freq = Stopwatch.Frequency;
            
            double ns = 1000000000.0 * (double)ticks / freq;
            double ms = ns / 1000000.0;
            double s = ms / 1000;
            //Debug.WriteIf(ticks > 0, s.ToString());

            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private string GetCurrTime0()
        {
            long h = (timer0.ElapsedMilliseconds / (1000 * 60 * 60)) % 24;
            long m = (timer0.ElapsedMilliseconds / (1000 * 60)) % 60;
            long s = (timer0.ElapsedMilliseconds / 1000) % 60;

            String info_message = ((h >= 10) ? h : "0" + h) + ":" + ((m >= 10) ? m : "0" + m) + ":" + ((s >= 10) ? s : "0" + s);
            return info_message;
        }

        private string GetCurrTime1()
        {
            long h = (timer1.ElapsedMilliseconds / (1000 * 60 * 60)) % 24;
            long m = (timer1.ElapsedMilliseconds / (1000 * 60)) % 60;
            long s = (timer1.ElapsedMilliseconds / 1000) % 60;
            
            String info_message = ((h >= 10) ? h : "0" + h) + ":" + ((m >= 10) ? m : "0" + m) + ":" + ((s >= 10) ? s : "0" + s);
            return info_message;
        }

        private string GetCurrTime2()
        {
            long h = (timer2.ElapsedMilliseconds / (1000 * 60 * 60)) % 24;
            long m = (timer2.ElapsedMilliseconds / (1000 * 60)) % 60;
            long s = (timer2.ElapsedMilliseconds / 1000) % 60;

            String info_message = ((h >= 10) ? h : "0" + h) + ":" + ((m >= 10) ? m : "0" + m) + ":" + ((s >= 10) ? s : "0" + s);
            return info_message;
        }

        private string GetCurrTime3()
        {
            long h = (timer3.ElapsedMilliseconds / (1000 * 60 * 60)) % 24;
            long m = (timer3.ElapsedMilliseconds / (1000 * 60)) % 60;
            long s = (timer3.ElapsedMilliseconds / 1000) % 60;

            String info_message = ((h >= 10) ? h : "0" + h) + ":" + ((m >= 10) ? m : "0" + m) + ":" + ((s >= 10) ? s : "0" + s);
            return info_message;
        }

        private string GetCurrTime4()
        {
            long h = (timer4.ElapsedMilliseconds / (1000 * 60 * 60)) % 24;
            long m = (timer4.ElapsedMilliseconds / (1000 * 60)) % 60;
            long s = (timer4.ElapsedMilliseconds / 1000) % 60;

            String info_message = ((h >= 10) ? h : "0" + h) + ":" + ((m >= 10) ? m : "0" + m) + ":" + ((s >= 10) ? s : "0" + s);
            return info_message;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer0.Reset();
            timer1.Reset();
            timer2.Reset();
            timer3.Reset();
            timer4.Reset();

            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_start1_Click(object sender, EventArgs e)
        {
            timer0.Start();
            timer1.Start();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            
            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_start2_Click(object sender, EventArgs e)
        {
            timer0.Start();
            timer1.Stop();
            timer2.Start();
            timer3.Stop();
            timer4.Stop();
            
            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_start3_Click(object sender, EventArgs e)
        {
            timer0.Start();
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
            timer4.Stop();
            
            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_start4_Click(object sender, EventArgs e)
        {
            timer0.Start();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Start();
            
            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_pause_all_Click(object sender, EventArgs e)
        {
            timer0.Stop();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            
            txt_timer0.Text = GetCurrTime0();
            txt_timer0.Update();
            txt_timer1.Text = GetCurrTime1();
            txt_timer1.Update();
            txt_timer2.Text = GetCurrTime2();
            txt_timer2.Update();
            txt_timer3.Text = GetCurrTime3();
            txt_timer3.Update();
            txt_timer4.Text = GetCurrTime4();
            txt_timer4.Update();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            save_dialog();

            // Save contents of string[] directly to path\file
            //System.IO.File.WriteAllLines(filename, projects_times);
        }

        private void save_dialog()
        {
            var user_home = System.Environment.GetEnvironmentVariable("USERPROFILE");
            
            DialogResult dlg_res;
            SaveFileDialog dlg;
            dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.InitialDirectory = user_home + @"\Desktop";
            dlg.Title = "Save report";
            dlg.DefaultExt = "txt";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;

            string suffix = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss");

            dlg.FileName = @"timesheet_" + suffix + ".txt";
            
            dlg_res = dlg.ShowDialog();

            String[] projects_times;
            projects_times = new String[5];

            projects_times[0] = txt_project1.Text + "-" + txt_timer1.Text;
            projects_times[1] = txt_project2.Text + "-" + txt_timer2.Text;
            projects_times[2] = txt_project3.Text + "-" + txt_timer3.Text;
            projects_times[3] = txt_project4.Text + "-" + txt_timer4.Text;
            projects_times[4] = "total: " + txt_timer0.Text;

            if (dlg_res == DialogResult.OK)
            {
                File.WriteAllLines(dlg.FileName, projects_times);
            }
        }

        
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.BalloonTipText = "Project Timer is minimized here.";
                this.notifyIcon1.ShowBalloonTip(1000);
                
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            this.notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}