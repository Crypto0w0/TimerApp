using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        int n = 0;
        DateTime newYear = new DateTime(2023, 12, 31, 0, 0, 0);
        DateTime bDay = new DateTime(2024, 6, 7, 0, 0, 0);
        DateTime winforms = new DateTime(2023, 11, 27, 0, 0, 0);
        public Form1()
        {
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
            TimeSpan ts1 = newYear.Subtract(DateTime.Now);
            TimeSpan ts2 = bDay.Subtract(DateTime.Now);
            TimeSpan ts3 = winforms.Subtract(DateTime.Now);
            t1.Interval = 1000;
            t1.Tick += new EventHandler(T1_Tick);
            t1.Enabled = true;
            t2.Interval = 1;
            t2.Tick += new EventHandler(T2_Tick);
            t2.Enabled = true;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1.Text = ts1.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label2.Text = ts2.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label3.Text = ts3.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            InitializeComponent();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts1 = newYear.Subtract(DateTime.Now);
            TimeSpan ts2 = bDay.Subtract(DateTime.Now);
            TimeSpan ts3 = winforms.Subtract(DateTime.Now);
            label1.Text = ts1.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label2.Text = ts2.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            label3.Text = ts3.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            n += 10;
            this.Text = n.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
