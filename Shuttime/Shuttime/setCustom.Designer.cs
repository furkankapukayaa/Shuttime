
namespace Shuttime
{
    partial class setCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setCustom));
            this.timerStart = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.BackColor = System.Drawing.Color.Transparent;
            this.timerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerStart.FlatAppearance.BorderSize = 0;
            this.timerStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.timerStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.timerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.timerStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timerStart.ImageKey = "start.png";
            this.timerStart.ImageList = this.ımageList1;
            this.timerStart.Location = new System.Drawing.Point(79, 116);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(150, 46);
            this.timerStart.TabIndex = 0;
            this.timerStart.Text = "Start The Timer";
            this.timerStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timerStart.UseVisualStyleBackColor = false;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(94, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 33);
            this.title.TabIndex = 3;
            this.title.Text = "Shuttime";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtitle.Location = new System.Drawing.Point(31, 45);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(254, 15);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "After a few minutes the computer shuts down";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "start.png");
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(97, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 4;
            // 
            // setCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 174);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.timerStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "set custom";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}