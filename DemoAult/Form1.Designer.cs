namespace DemoAult
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
            this.checkBoxShowRealTimeSnip = new System.Windows.Forms.CheckBox();
            this.pictureBoxRealtimeSnip = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstSnip = new System.Windows.Forms.PictureBox();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonDeleteCapture = new System.Windows.Forms.Button();
            this.buttonAutoRun = new System.Windows.Forms.Button();
            this.listBoxCapture = new System.Windows.Forms.ListBox();
            this.timerAutoRun = new System.Windows.Forms.Timer(this.components);
            this.lblconsole = new System.Windows.Forms.Label();
            this.lblconsole2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRealtimeSnip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSnip)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxShowRealTimeSnip
            // 
            this.checkBoxShowRealTimeSnip.AutoSize = true;
            this.checkBoxShowRealTimeSnip.Checked = true;
            this.checkBoxShowRealTimeSnip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowRealTimeSnip.Location = new System.Drawing.Point(753, 222);
            this.checkBoxShowRealTimeSnip.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowRealTimeSnip.Name = "checkBoxShowRealTimeSnip";
            this.checkBoxShowRealTimeSnip.Size = new System.Drawing.Size(119, 17);
            this.checkBoxShowRealTimeSnip.TabIndex = 10;
            this.checkBoxShowRealTimeSnip.Text = "ShowRealTimeSnip";
            this.checkBoxShowRealTimeSnip.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRealtimeSnip
            // 
            this.pictureBoxRealtimeSnip.Location = new System.Drawing.Point(753, 11);
            this.pictureBoxRealtimeSnip.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRealtimeSnip.Name = "pictureBoxRealtimeSnip";
            this.pictureBoxRealtimeSnip.Size = new System.Drawing.Size(211, 198);
            this.pictureBoxRealtimeSnip.TabIndex = 8;
            this.pictureBoxRealtimeSnip.TabStop = false;
            // 
            // pictureBoxFirstSnip
            // 
            this.pictureBoxFirstSnip.Location = new System.Drawing.Point(513, 11);
            this.pictureBoxFirstSnip.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFirstSnip.Name = "pictureBoxFirstSnip";
            this.pictureBoxFirstSnip.Size = new System.Drawing.Size(211, 198);
            this.pictureBoxFirstSnip.TabIndex = 9;
            this.pictureBoxFirstSnip.TabStop = false;
            // 
            // buttonCapture
            // 
            this.buttonCapture.Location = new System.Drawing.Point(405, 222);
            this.buttonCapture.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(92, 33);
            this.buttonCapture.TabIndex = 5;
            this.buttonCapture.Text = "Add Capture";
            this.buttonCapture.UseVisualStyleBackColor = true;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonDeleteCapture
            // 
            this.buttonDeleteCapture.Location = new System.Drawing.Point(300, 222);
            this.buttonDeleteCapture.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteCapture.Name = "buttonDeleteCapture";
            this.buttonDeleteCapture.Size = new System.Drawing.Size(92, 33);
            this.buttonDeleteCapture.TabIndex = 6;
            this.buttonDeleteCapture.Text = "Delete Capture";
            this.buttonDeleteCapture.UseVisualStyleBackColor = true;
            this.buttonDeleteCapture.Click += new System.EventHandler(this.buttonDeleteCapture_Click);
            // 
            // buttonAutoRun
            // 
            this.buttonAutoRun.Location = new System.Drawing.Point(195, 222);
            this.buttonAutoRun.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAutoRun.Name = "buttonAutoRun";
            this.buttonAutoRun.Size = new System.Drawing.Size(92, 33);
            this.buttonAutoRun.TabIndex = 7;
            this.buttonAutoRun.Text = "Auto Run";
            this.buttonAutoRun.UseVisualStyleBackColor = true;
            this.buttonAutoRun.Click += new System.EventHandler(this.buttonAutoRun_Click);
            // 
            // listBoxCapture
            // 
            this.listBoxCapture.FormattingEnabled = true;
            this.listBoxCapture.Location = new System.Drawing.Point(28, 11);
            this.listBoxCapture.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCapture.Name = "listBoxCapture";
            this.listBoxCapture.Size = new System.Drawing.Size(470, 199);
            this.listBoxCapture.TabIndex = 4;
            // 
            // timerAutoRun
            // 
            this.timerAutoRun.Interval = 5;
            this.timerAutoRun.Tick += new System.EventHandler(this.timerAutoRun_Tick);
            // 
            // lblconsole
            // 
            this.lblconsole.AutoSize = true;
            this.lblconsole.Location = new System.Drawing.Point(510, 232);
            this.lblconsole.Name = "lblconsole";
            this.lblconsole.Size = new System.Drawing.Size(44, 13);
            this.lblconsole.TabIndex = 11;
            this.lblconsole.Text = "console";
            // 
            // lblconsole2
            // 
            this.lblconsole2.AutoSize = true;
            this.lblconsole2.Location = new System.Drawing.Point(510, 250);
            this.lblconsole2.Name = "lblconsole2";
            this.lblconsole2.Size = new System.Drawing.Size(44, 13);
            this.lblconsole2.TabIndex = 12;
            this.lblconsole2.Text = "console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 272);
            this.Controls.Add(this.lblconsole2);
            this.Controls.Add(this.lblconsole);
            this.Controls.Add(this.checkBoxShowRealTimeSnip);
            this.Controls.Add(this.pictureBoxRealtimeSnip);
            this.Controls.Add(this.pictureBoxFirstSnip);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.buttonDeleteCapture);
            this.Controls.Add(this.buttonAutoRun);
            this.Controls.Add(this.listBoxCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRealtimeSnip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstSnip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowRealTimeSnip;
        private System.Windows.Forms.PictureBox pictureBoxRealtimeSnip;
        private System.Windows.Forms.PictureBox pictureBoxFirstSnip;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.Button buttonDeleteCapture;
        private System.Windows.Forms.Button buttonAutoRun;
        private System.Windows.Forms.ListBox listBoxCapture;
        private System.Windows.Forms.Timer timerAutoRun;
        private System.Windows.Forms.Label lblconsole;
        private System.Windows.Forms.Label lblconsole2;
    }
}

