using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppl
{
    public partial class LoadDialog : Form
    {

        public LoadDialog()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(46, 46, 46);
            this.ForeColor = Color.White;
            //
            listBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            listBox1.BackColor = Color.White;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            //
            button1.BackColor = Color.FromArgb(52, 58, 64); // Set the background color to dark gray
            button1.ForeColor = Color.White; // Set the text color to white
            button1.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            button1.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            button1.FlatAppearance.BorderSize = 0; // Set the border size to 0
            //
            button2.BackColor = Color.FromArgb(220, 53, 69); // Set the background color to red
            button2.BackColor = Color.FromArgb(220, 53, 69); // Set the background color to red
            button2.ForeColor = Color.White; // Set the text color to white
            button2.Font = new Font("Segoe UI", 6, FontStyle.Bold); // Set the font to Segoe UI Bold 14pt
            button2.FlatStyle = FlatStyle.Flat; // Set the button style to flat
            button2.FlatAppearance.BorderSize = 0; // Set the border size to 0
            using (ApplicationContext db = new ApplicationContext())
            {
                listBox1.DataSource = (from time in db.Times
                                       select time.Name +"  -   "+ time.Time).ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                this.Close();
            }
        }
    }
}
