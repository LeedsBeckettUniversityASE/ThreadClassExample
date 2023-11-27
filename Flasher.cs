using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLive
{
    
    class Flasher
    {
        private System.Windows.Forms.Button button;
        private Color col1, col2;
        private Boolean running = false;    //flag to signal to flash or not
        private Boolean flag = false;       //flag to signal the colour of the button
        private Boolean endThread = false;  //flag to tell the thread to exit
        private Thread thread;
        private String message;
        private String msg1, msg2;
        public Flasher(System.Windows.Forms.Button button, Color col1, Color col2, String msg1, String msg2) 
        {
            this.button = button;
            this.col1 = col1;
            this.col2 = col2;
            this.msg1 = msg1;
            this.msg2 = msg2;
           
            this.thread = new Thread(ThreadMethod);
            this.thread.Start();
        }

        public Boolean Running
        { get { return running; } }
        public void Start() 
        {
          
            running= true;
            
        }

        public void Stop() 
        { 
            running = false;
            this.button.BackColor = Color.Gray;
            //this.thread.Abort(); 
        }

        public void Kill()
        {
            this.thread.Suspend(); //this is depricated and should not be used as it could kill a thread halfway through an important task.
           
        }
        public void ThreadMethod()
        {
            while (endThread == false)           //should the thread continue executing?
            {
                if (running == false)           //should it flash the buton?
                    continue;                   //no? Do nothing but the thread is still running
                if (flag == false)
                {
                    this.button.BackColor = this.col1;
                    Console.Write(msg1);
                    flag = true;
                }
                else
                {
                    this.button.BackColor = this.col2;
                    flag = false;
                    Console.WriteLine(msg2);
                }
                Thread.Sleep(500);              //sleep for half a second to slow down the flash but remember nothing is being locked even without the sleep because the thrad is running in a timeslice
               
            }
        }
    }
}
