using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SildeShowImage
{
    public partial class FormSlide : Form
    {
        private int imageNumber = 1;

        public FormSlide()
        {
            InitializeComponent();
        }

        private void loadNextImage()
        {
            if (imageNumber > 10)
            {
                imageNumber = 1;
            }
            
            int image_trai = imageNumber-1;
            if (image_trai < 1)
            {
                image_trai = 10;
            }
            int image_trai2 = imageNumber - 2;
            if (image_trai2 < 0 )
            {
                image_trai2 = 9;
            }
            if (image_trai2 == 0)
            {
                image_trai2 = 10;
            }

            int image_phai = imageNumber+1;
            if (image_phai > 10)
            {
                image_phai = 1;
            }
            int image_phai2 = imageNumber + 2;
            if (image_phai2 == 11)
            {
                image_phai2 = 1;
            }
            if (image_phai2 > 11)
            {
                image_phai2 = 2;
            }

            pic_slide.ImageLocation = string.Format(@"anh\anh{0}.jpg", imageNumber);
            alexgiua.ImageLocation = string.Format(@"anh\anh{0}.jpg", imageNumber);
            alextrai2.ImageLocation = string.Format(@"anh\anh{0}.jpg", image_trai2);
            alextrai.ImageLocation = string.Format(@"anh\anh{0}.jpg", image_trai);
            alexphai.ImageLocation = string.Format(@"anh\anh{0}.jpg", image_phai);
            alexphai2.ImageLocation = string.Format(@"anh\anh{0}.jpg", image_phai2);
            imageNumber++;
        }

        private void Timer_slide_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void Pic_center_Click(object sender, EventArgs e)
        {

        }

        private void Pic_right_Click(object sender, EventArgs e)
        {

        }

        private void Pic_left_Click(object sender, EventArgs e)
        {

        }

        private void Pic_slide_Click(object sender, EventArgs e)
        {

        }
    }
}
