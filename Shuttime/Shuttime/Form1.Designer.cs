
namespace Shuttime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.minute15 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minute30 = new System.Windows.Forms.Button();
            this.minute45 = new System.Windows.Forms.Button();
            this.hours1 = new System.Windows.Forms.Button();
            this.setCustom = new System.Windows.Forms.Button();
            this.turnOffActiveTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtitle.Location = new System.Drawing.Point(99, 42);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(224, 15);
            this.subtitle.TabIndex = 0;
            this.subtitle.Text = "Choose when the computer shuts down.";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(148, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 33);
            this.title.TabIndex = 1;
            this.title.Text = "Shuttime";
            // 
            // minute15
            // 
            this.minute15.BackColor = System.Drawing.Color.Transparent;
            this.minute15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minute15.FlatAppearance.BorderSize = 0;
            this.minute15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minute15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minute15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minute15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minute15.ImageKey = "15-minutes.png";
            this.minute15.ImageList = this.ımageList1;
            this.minute15.Location = new System.Drawing.Point(37, 99);
            this.minute15.Name = "minute15";
            this.minute15.Size = new System.Drawing.Size(88, 59);
            this.minute15.TabIndex = 2;
            this.minute15.Text = "15 minutes";
            this.minute15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minute15.UseVisualStyleBackColor = false;
            this.minute15.Click += new System.EventHandler(this.minute15_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "15-minutes.png");
            this.ımageList1.Images.SetKeyName(1, "30-minutes.png");
            this.ımageList1.Images.SetKeyName(2, "45-minutes.png");
            this.ımageList1.Images.SetKeyName(3, "earth-hour.png");
            this.ımageList1.Images.SetKeyName(4, "equalizer.png");
            this.ımageList1.Images.SetKeyName(5, "stopwatch.png");
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.Location = new System.Drawing.Point(171, 63);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(67, 18);
            this.time.TabIndex = 8;
            this.time.Text = "loading..";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minute30
            // 
            this.minute30.BackColor = System.Drawing.Color.Transparent;
            this.minute30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minute30.FlatAppearance.BorderSize = 0;
            this.minute30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minute30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minute30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minute30.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.minute30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minute30.ImageKey = "30-minutes.png";
            this.minute30.ImageList = this.ımageList1;
            this.minute30.Location = new System.Drawing.Point(131, 99);
            this.minute30.Name = "minute30";
            this.minute30.Size = new System.Drawing.Size(88, 59);
            this.minute30.TabIndex = 9;
            this.minute30.Text = "30 minutes";
            this.minute30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minute30.UseVisualStyleBackColor = false;
            this.minute30.Click += new System.EventHandler(this.minute30_Click);
            // 
            // minute45
            // 
            this.minute45.BackColor = System.Drawing.Color.Transparent;
            this.minute45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minute45.FlatAppearance.BorderSize = 0;
            this.minute45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minute45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minute45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minute45.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.minute45.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minute45.ImageKey = "45-minutes.png";
            this.minute45.ImageList = this.ımageList1;
            this.minute45.Location = new System.Drawing.Point(225, 99);
            this.minute45.Name = "minute45";
            this.minute45.Size = new System.Drawing.Size(90, 59);
            this.minute45.TabIndex = 10;
            this.minute45.Text = "45 minutes";
            this.minute45.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minute45.UseVisualStyleBackColor = false;
            this.minute45.Click += new System.EventHandler(this.minute45_Click);
            // 
            // hours1
            // 
            this.hours1.BackColor = System.Drawing.Color.Transparent;
            this.hours1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hours1.FlatAppearance.BorderSize = 0;
            this.hours1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hours1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hours1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.hours1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hours1.ImageKey = "earth-hour.png";
            this.hours1.ImageList = this.ımageList1;
            this.hours1.Location = new System.Drawing.Point(321, 99);
            this.hours1.Name = "hours1";
            this.hours1.Size = new System.Drawing.Size(82, 59);
            this.hours1.TabIndex = 11;
            this.hours1.Text = "1 hours";
            this.hours1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hours1.UseVisualStyleBackColor = false;
            this.hours1.Click += new System.EventHandler(this.hours1_Click);
            // 
            // setCustom
            // 
            this.setCustom.BackColor = System.Drawing.Color.Transparent;
            this.setCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCustom.FlatAppearance.BorderSize = 0;
            this.setCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCustom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.setCustom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.setCustom.ImageKey = "equalizer.png";
            this.setCustom.ImageList = this.ımageList1;
            this.setCustom.Location = new System.Drawing.Point(81, 190);
            this.setCustom.Name = "setCustom";
            this.setCustom.Size = new System.Drawing.Size(93, 63);
            this.setCustom.TabIndex = 12;
            this.setCustom.Text = "set custom";
            this.setCustom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setCustom.UseVisualStyleBackColor = false;
            this.setCustom.Click += new System.EventHandler(this.setCustom_Click);
            // 
            // turnOffActiveTimer
            // 
            this.turnOffActiveTimer.BackColor = System.Drawing.Color.Transparent;
            this.turnOffActiveTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnOffActiveTimer.FlatAppearance.BorderSize = 0;
            this.turnOffActiveTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.turnOffActiveTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.turnOffActiveTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOffActiveTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.turnOffActiveTimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.turnOffActiveTimer.ImageKey = "stopwatch.png";
            this.turnOffActiveTimer.ImageList = this.ımageList1;
            this.turnOffActiveTimer.Location = new System.Drawing.Point(225, 190);
            this.turnOffActiveTimer.Name = "turnOffActiveTimer";
            this.turnOffActiveTimer.Size = new System.Drawing.Size(158, 63);
            this.turnOffActiveTimer.TabIndex = 13;
            this.turnOffActiveTimer.Text = "Turn Off Active Timer";
            this.turnOffActiveTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.turnOffActiveTimer.UseVisualStyleBackColor = false;
            this.turnOffActiveTimer.Click += new System.EventHandler(this.turnOffActiveTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 265);
            this.Controls.Add(this.turnOffActiveTimer);
            this.Controls.Add(this.setCustom);
            this.Controls.Add(this.hours1);
            this.Controls.Add(this.minute45);
            this.Controls.Add(this.minute30);
            this.Controls.Add(this.time);
            this.Controls.Add(this.minute15);
            this.Controls.Add(this.title);
            this.Controls.Add(this.subtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shuttime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button minute15;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button minute30;
        private System.Windows.Forms.Button minute45;
        private System.Windows.Forms.Button hours1;
        private System.Windows.Forms.Button setCustom;
        private System.Windows.Forms.Button turnOffActiveTimer;
    }
}

