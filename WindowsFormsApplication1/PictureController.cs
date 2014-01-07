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
    public class PictureController
    {
        private readonly IPictureManager  manager;
        private Image image = null;

        public PictureController(IPictureManager manager)
        {
            this.manager = manager;
        }

        public Image OpenPicture(String path)
        {
            try
            {
                //get picture from filesystem
                Image NewImage = manager.OpenPicture(path);

                //check if the received image is null
                if (NewImage != null)
                {
                    this.image = NewImage;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Image can't be loaded from the filesystem");
            }

            return this.image;
        }

        public Boolean SavePicture(String path, String filename,Image image)
        {
            try
            {
                //try to save the new picture
                return manager.SavePicture(path, filename, image);
            }
            catch
            {
                Console.WriteLine("Image can't be saved");
                return false;
            }
        }

        public Image ResizeImage(Image imgToResize, Size size)
        {
            try
            {
                //try to resize the picture
                Image NewImage = manager.ResizeImage(imgToResize, size);
                //check if the received image is null
                if (NewImage != null)
                {
                    this.image = NewImage;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Image can't be resized");
            }

            return this.image;
        }

        public Image DrawMouse(Image Original, Image Second, int x, int y, Color color, int size)
        {
            try
            {
                //try to draw something in the picture
                Image NewImage = manager.DrawMouse(Original, Second,x,y,color,size);
                //check if the received image is null
                if (NewImage != null)
                {
                    this.image = NewImage;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Image can't be drawed");
            }

            return this.image;
        }
    }
}
