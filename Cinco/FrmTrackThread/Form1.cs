using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            lblThread.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");

            MyThreadClass threading = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(threading.Thread1));
            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            Thread threadB = new Thread(new ThreadStart(threading.Thread2));
            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            Thread threadC = new Thread(new ThreadStart(threading.Thread1));
            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            Thread threadD = new Thread(new ThreadStart(threading.Thread2));
            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblThread.Text = "-End Thread-";
            Console.WriteLine("-End Thread-");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
