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
            using (ApplicationContext db = new ApplicationContext())
            {

                listBox1.DataSource = (from time in db.Times
                                       select time.Name).ToList();

                listBox2.DataSource = (from time in db.Times
                                       select time.Time).ToList();

            }

        }
        public string tmp { get { return listBox2.SelectedItem.ToString(); } }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
