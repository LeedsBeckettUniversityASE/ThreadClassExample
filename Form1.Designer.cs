namespace ThreadClassExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.T1but = new System.Windows.Forms.Button();
            this.T2but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(341, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 149);
            this.button1.TabIndex = 0;
            this.button1.Text = "FLASH";
            this.button1.UseVisualStyleBackColor = false;
           
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(371, 342);
            this.ExitBut.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(128, 86);
            this.ExitBut.TabIndex = 1;
            this.ExitBut.Text = "Exit Thread";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // T1but
            // 
            this.T1but.Location = new System.Drawing.Point(61, 118);
            this.T1but.Name = "T1but";
            this.T1but.Size = new System.Drawing.Size(75, 23);
            this.T1but.TabIndex = 2;
            this.T1but.Text = "Thread1";
            this.T1but.UseVisualStyleBackColor = true;
            this.T1but.Click += new System.EventHandler(this.T1but_Click);
            // 
            // T2but
            // 
            this.T2but.Location = new System.Drawing.Point(61, 152);
            this.T2but.Name = "T2but";
            this.T2but.Size = new System.Drawing.Size(75, 23);
            this.T2but.TabIndex = 4;
            this.T2but.Text = "Thread2";
            this.T2but.UseVisualStyleBackColor = true;
            this.T2but.Click += new System.EventHandler(this.T2but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 598);
            this.Controls.Add(this.T2but);
            this.Controls.Add(this.T1but);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button T1but;
        private System.Windows.Forms.Button T2but;
    }
}

