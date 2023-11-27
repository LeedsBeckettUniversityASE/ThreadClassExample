using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadLive;

namespace ThreadClassExample
{
    public partial class Form1 : Form
    {
        //thread 1
        Flasher F1, F2;
        public Form1()
        {
            InitializeComponent();
            F1 = new Flasher(button1, Color.Red, Color.Yellow, "Hel","lo");
            F2 = new Flasher(button1, Color.Blue, Color.Green, "Good","bye");
            Console.WriteLine("Thead 1...main program");
        }

        /// <summary>
        /// Thread method to flash a button
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {

            //running = !running;                 //signal to the thread to flash the button or not
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Kill!");
            F1.Kill();
            F2.Kill();
            timer1.Enabled = true;  //Enabled timer
        }

        private void T1but_Click(object sender, EventArgs e)
        {
            if (F1.Running)
                F1.Stop();
            else
                F1.Start();
        }

        private void T2but_Click(object sender, EventArgs e)
        {
            if (F2.Running)
                F2.Stop();
            else
                F2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick ");
        }
    }
}
