using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart01_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Start01);
            th.Start();
        }

        private void Start01()
        {
            for (int i = 0; i < 1000000001; i++)
            {
                progressBar1.Value = i / 10000000;
            }
        }

        private void btnStart02_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Start02);
            th.Start();
        }

        private void Start02()
        {
            for (int i = 0; i < 1000000001; i++)
            {
                progressBar2.Value = i / 10000000;
            }
        }
    }
}
