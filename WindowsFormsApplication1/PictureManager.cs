using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsFormsApplication1
{
    public class PictureManager : IPictureManager
    {
        private readonly IPictureManager  manager;

        public PictureManager(IPictureManager manager)
        {
            this.manager = manager;
        }

        public PictureManager()
        {

        }

        /**
        * This Method will be called to save the picture
        * @param String path, String filename, Image image
        */
        public bool SavePicture(String path, String filename, Image image)
        {
            Bitmap mp = new Bitmap(image);
            //Save the picture
            try
            {
                mp.Save(path + @"\" + filename + ".png", System.Drawing.Imaging.ImageFormat.Png);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("File can't be saved");
                return false;
            }
        }

        /**
        * This Method will be called to open the picture
        * @param String path
        * @return Image
        */
        public Image OpenPicture(String path)
        {

            try
            {

                //Get the picture
                Bitmap BitMapImage = new Bitmap(Image.FromFile(path));
                //Resize the picture
                Image DisplayImage = ResizeImage(BitMapImage, new Size(800, 400));
                return DisplayImage;
  
            }
            catch (Exception e)
            {
                return null;
            }  
        }

        /**
        * This Method will be called to resize image
        * @param Image imgToResize, Size size
        * @return Image
        */
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        /**
        * This Method will be called to draw the picture
        * @param Image Original, Image Second, MouseEventArgs e, Color color, int size
        * @return Image
        */
        public Image DrawMouse(Image Original, Image Second, int X, int Y, Color color, int size)
        {
            //Create a graphic object 
            Graphics g = Graphics.FromImage(Second);
            SolidBrush myBrush = new SolidBrush(color);
            //Draw linies 
            g.FillRectangle(myBrush, X, Y, size, size);
            g.Save();
            return Second;
        }

    

    }
}
