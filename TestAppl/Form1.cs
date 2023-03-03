using System.Diagnostics;
namespace TestAppl
{
    public partial class Form1 : Form
    {
        private Stopwatch Stopwatch;
        public Form1()
        {
            InitializeComponent();
            Stopwatch = new Stopwatch();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (Stopwatch.IsRunning)
            {
                Stopwatch.Stop();
                start.Text = "Start";
            }
            else
            {
                Stopwatch.Start();
                start.Text = "Stop";
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            
                var loadDialog = new LoadDialog();
            loadDialog.ShowDialog();
            string tmp = loadDialog.tmp;
            TimeLabel.Text = tmp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string inputText = inputDialog.InputText;
                using (ApplicationContext db = new ApplicationContext())
                {
                    TimeDb time = new TimeDb { Name = inputText, Time = Stopwatch.Elapsed };
                    db.Add(time);
                    db.SaveChanges();
                }
            }

        }

    }
}
