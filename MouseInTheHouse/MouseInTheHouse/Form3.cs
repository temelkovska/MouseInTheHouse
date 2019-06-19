using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseInTheHouse
{
    public partial class Instructions_Form : Form
    {
        public Instructions_Form()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Form1 pocetna = new Form1();
            pocetna.Show();*/
        }
        private void Form3_FormClosed(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 pocetna = new Form1();
            pocetna.Show();
        }
    }
}
