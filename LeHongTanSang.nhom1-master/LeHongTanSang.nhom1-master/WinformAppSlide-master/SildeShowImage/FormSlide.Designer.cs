namespace SildeShowImage
{
    partial class FormSlide
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
            this.panel_slide = new System.Windows.Forms.Panel();
            this.pic_slide = new System.Windows.Forms.PictureBox();
            this.panel_controll = new System.Windows.Forms.Panel();
            this.alexphai2 = new System.Windows.Forms.PictureBox();
            this.alextrai2 = new System.Windows.Forms.PictureBox();
            this.alexphai = new System.Windows.Forms.PictureBox();
            this.alextrai = new System.Windows.Forms.PictureBox();
            this.alexgiua = new System.Windows.Forms.PictureBox();
            this.timer_slide = new System.Windows.Forms.Timer(this.components);
            this.panel_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_slide)).BeginInit();
            this.panel_controll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alexphai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alextrai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexphai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alextrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexgiua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_slide
            // 
            this.panel_slide.Controls.Add(this.pic_slide);
            this.panel_slide.Controls.Add(this.panel_controll);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(784, 381);
            this.panel_slide.TabIndex = 0;
            // 
            // pic_slide
            // 
            this.pic_slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_slide.Location = new System.Drawing.Point(0, 0);
            this.pic_slide.Name = "pic_slide";
            this.pic_slide.Size = new System.Drawing.Size(784, 328);
            this.pic_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_slide.TabIndex = 1;
            this.pic_slide.TabStop = false;
            this.pic_slide.Click += new System.EventHandler(this.Pic_slide_Click);
            // 
            // panel_controll
            // 
            this.panel_controll.Controls.Add(this.alexphai2);
            this.panel_controll.Controls.Add(this.alextrai2);
            this.panel_controll.Controls.Add(this.alexphai);
            this.panel_controll.Controls.Add(this.alextrai);
            this.panel_controll.Controls.Add(this.alexgiua);
            this.panel_controll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_controll.Location = new System.Drawing.Point(0, 328);
            this.panel_controll.Name = "panel_controll";
            this.panel_controll.Size = new System.Drawing.Size(784, 53);
            this.panel_controll.TabIndex = 0;
            // 
            // alexphai2
            // 
            this.alexphai2.Location = new System.Drawing.Point(530, 12);
            this.alexphai2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alexphai2.Name = "alexphai2";
            this.alexphai2.Size = new System.Drawing.Size(59, 32);
            this.alexphai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alexphai2.TabIndex = 4;
            this.alexphai2.TabStop = false;
            // 
            // alextrai2
            // 
            this.alextrai2.Location = new System.Drawing.Point(211, 11);
            this.alextrai2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alextrai2.Name = "alextrai2";
            this.alextrai2.Size = new System.Drawing.Size(59, 32);
            this.alextrai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alextrai2.TabIndex = 3;
            this.alextrai2.TabStop = false;
            // 
            // alexphai
            // 
            this.alexphai.Location = new System.Drawing.Point(456, 13);
            this.alexphai.Name = "alexphai";
            this.alexphai.Size = new System.Drawing.Size(60, 30);
            this.alexphai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alexphai.TabIndex = 2;
            this.alexphai.TabStop = false;
            this.alexphai.Click += new System.EventHandler(this.Pic_right_Click);
            // 
            // alextrai
            // 
            this.alextrai.Location = new System.Drawing.Point(285, 12);
            this.alextrai.Name = "alextrai";
            this.alextrai.Size = new System.Drawing.Size(60, 32);
            this.alextrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alextrai.TabIndex = 1;
            this.alextrai.TabStop = false;
            this.alextrai.Click += new System.EventHandler(this.Pic_left_Click);
            // 
            // alexgiua
            // 
            this.alexgiua.Location = new System.Drawing.Point(361, 8);
            this.alexgiua.Name = "alexgiua";
            this.alexgiua.Size = new System.Drawing.Size(80, 40);
            this.alexgiua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alexgiua.TabIndex = 0;
            this.alexgiua.TabStop = false;
            this.alexgiua.Click += new System.EventHandler(this.Pic_center_Click);
            // 
            // timer_slide
            // 
            this.timer_slide.Enabled = true;
            this.timer_slide.Interval = 2000;
            this.timer_slide.Tick += new System.EventHandler(this.Timer_slide_Tick);
            // 
            // FormSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.panel_slide);
            this.Name = "FormSlide";
            this.Text = "Form_Slide";
            this.panel_slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_slide)).EndInit();
            this.panel_controll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alexphai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alextrai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexphai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alextrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alexgiua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.PictureBox pic_slide;
        private System.Windows.Forms.Panel panel_controll;
        private System.Windows.Forms.Timer timer_slide;
        private System.Windows.Forms.PictureBox alexphai;
        private System.Windows.Forms.PictureBox alextrai;
        private System.Windows.Forms.PictureBox alexgiua;
        private System.Windows.Forms.PictureBox alextrai2;
        private System.Windows.Forms.PictureBox alexphai2;
    }
}

