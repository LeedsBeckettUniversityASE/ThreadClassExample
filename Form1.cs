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
    /// <summary>
    /// ThreadClassExample
    /// Uses a class that implements a simple flasher thread.
    /// The two thread buttons gracefully start and stop the individual threads.
    /// They compete for the colour of the button and the text in the console.
    /// As you start two threads you'll see that the coulours get mixed up and the message on the console gets mixed up.
    /// The kill button uses a depricated method to show why its depricated. The button is left a random colour. It then starts a simple toolbox timer to show how simle that is.
    /// </summary>
    public partial class Form1 : Form
    {
        //thread 1
        Flasher F1, F2;
        /// <summary>
        /// Snstantiate two flasher objects which run as two seperate threads.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            F1 = new Flasher(button1, Color.Red, Color.Yellow, "Hel","lo");
            F2 = new Flasher(button1, Color.Blue, Color.Green, "Good","bye");
            Console.WriteLine("Thead 1...main program");
        }


        /// <summary>
        /// Button 1 starts flasher 1.
        /// When it stops it is still running but has been told to stop its action. It stops gracefully by setting the button back to grey.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T1but_Click(object sender, EventArgs e)
        {
            if (F1.Running)
                F1.Stop();
            else
                F1.Start();
        }

        /// <summary>
        /// Button 2 starts/stops flasher two.
        /// When it stops it is still running but has been told to stop its action. It stops gracefully by setting the button back to grey.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T2but_Click(object sender, EventArgs e)
        {
            if (F2.Running)
                F2.Stop();
            else
                F2.Start();
        }

        /// <summary>
        /// This button calls the Kill method of Flasher which uses the horrible depricated Thread.Suspend() method. This results in the thread being shot in the head. It doesn't get a chance to set the button colour to grey.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBut_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Kill!");
            F1.Kill();
            F2.Kill();

            timer1.Enabled = true;  //Enabled timer

        }

        /// <summary>
        /// Used the timer from the toolbox to implement a very simple thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Tick ");
        }
    }
}
