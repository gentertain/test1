using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int move1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "TEST";
            button1.BackColor = Color.Red;
            move1 = move1 + 1;
            label2.Text = move1.ToString();
            progressBar1.Value = move1;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
