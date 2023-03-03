using System.Diagnostics;
namespace TestAppl
{
    public partial class Form1 : Form
    {
        private Stopwatch Stopwatch;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            Stopwatch = new Stopwatch();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StopwatchData.mdf;Integrated Security=True";
        }

        private void start_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
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
