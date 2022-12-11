namespace KursovayaCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pict = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.l1 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.l2 = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TrackBar();
            this.lRadius = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // pict
            // 
            this.pict.Location = new System.Drawing.Point(42, 26);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(475, 307);
            this.pict.TabIndex = 0;
            this.pict.TabStop = false;
            this.pict.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pict_MouseClick);
            this.pict.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pict_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(45, 353);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(164, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(45, 404);
            this.tb2.Maximum = 100;
            this.tb2.Minimum = 10;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(164, 45);
            this.tb2.TabIndex = 2;
            this.tb2.Value = 10;
            this.tb2.Scroll += new System.EventHandler(this.tb2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(45, 452);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(164, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(45, 506);
            this.trackBar4.Maximum = 50;
            this.trackBar4.Minimum = 10;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(164, 45);
            this.trackBar4.TabIndex = 4;
            this.trackBar4.Value = 10;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(215, 353);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(13, 15);
            this.l1.TabIndex = 5;
            this.l1.Text = "0";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(215, 452);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(13, 15);
            this.l3.TabIndex = 7;
            this.l3.Text = "0";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(215, 506);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(19, 15);
            this.l4.TabIndex = 8;
            this.l4.Text = "10";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 24;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(215, 404);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(19, 15);
            this.l2.TabIndex = 9;
            this.l2.Text = "10";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(413, 374);
            this.tbRadius.Maximum = 500;
            this.tbRadius.Minimum = 10;
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(104, 45);
            this.tbRadius.TabIndex = 10;
            this.tbRadius.Value = 10;
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Location = new System.Drawing.Point(504, 353);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(13, 15);
            this.lRadius.TabIndex = 11;
            this.lRadius.Text = "0";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(45, 335);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(91, 15);
            this.txt1.TabIndex = 12;
            this.txt1.Text = "Мин. скорость ";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(45, 386);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(95, 15);
            this.txt2.TabIndex = 13;
            this.txt2.Text = "Маск. скорость ";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(46, 434);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(116, 15);
            this.txt3.TabIndex = 14;
            this.txt3.Text = "Количество частиц ";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Location = new System.Drawing.Point(45, 488);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(99, 15);
            this.txt4.TabIndex = 15;
            this.txt4.Text = "Радиус эмиттера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 622);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pict);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pict;
        private TrackBar trackBar1;
        private TrackBar tb2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label l1;
        private Label l3;
        private Label l4;
        private System.Windows.Forms.Timer timer;
        private Label l2;
        private TrackBar tbRadius;
        private Label lRadius;
        private Label txt1;
        private Label txt2;
        private Label txt3;
        private Label txt4;
    }
}