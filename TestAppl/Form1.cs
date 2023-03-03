using System.Diagnostics;
using System.Windows.Forms;

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
                start.BackColor = Color.FromArgb(0, 200, 81); // Set the background color to green
                start.ForeColor = Color.White; // Set the text color to white
                start.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
                start.FlatStyle = FlatStyle.Flat; // Set the button style to flat
                start.FlatAppearance.BorderSize = 0; // Set the border size to 0
            }
            else
            {
                Stopwatch.Start();
                start.Text = "Stop";
               start.BackColor = Color.FromArgb(220, 53, 69); // Set the background color to red
                start.ForeColor = Color.White; // Set the text color to white
                start.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
                start.FlatStyle = FlatStyle.Flat; // Set the button style to flat
                start.FlatAppearance.BorderSize = 0; // Set the border size to 0
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Stopwatch.Reset();
            start.Text = "Start";
            start.BackColor = Color.FromArgb(0, 200, 81); // Set the background color to green
            start.ForeColor = Color.White; // Set the text color to white
            start.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            start.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            start.FlatAppearance.BorderSize = 0; // Set the border size to 0
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss\:ff");
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            
                var loadDialog = new LoadDialog();
            loadDialog.ShowDialog();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            loadButton.Text = "Show Saved";
            this.Text = "Stopwatch App";
            this.BackColor = Color.FromArgb(46, 46, 46);
            this.ForeColor = Color.White;
            start.Text = "Start";
            start.BackColor = Color.FromArgb(41, 128, 185);
            start.ForeColor = Color.White;
            
            reset.Text = "Reset";
            reset.BackColor = Color.FromArgb(192, 57, 43);
            reset.ForeColor = Color.White;
            reset.BackColor = Color.FromArgb(23, 162, 184); // Set the background color to blue
            reset.ForeColor = Color.White; // Set the text color to white
            reset.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            reset.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            reset.FlatAppearance.BorderSize = 0; // Set the border size to 0

           save.BackColor = Color.FromArgb(52, 58, 64); // Set the background color to dark gray
            save.ForeColor = Color.White; // Set the text color to white
            save.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            save.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            save.FlatAppearance.BorderSize = 0; // Set the border size to 0

           loadButton.BackColor = Color.FromArgb(52, 58, 64); // Set the background color to dark gray
            loadButton.ForeColor = Color.White; // Set the text color to white
            loadButton.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            loadButton.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            loadButton.FlatAppearance.BorderSize = 0; // Set the border size to 0
        }
    }
}
