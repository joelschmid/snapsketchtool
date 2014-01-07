using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public interface IPictureManager
    {
        bool SavePicture(String path, String filename, Image image);

        Image OpenPicture(String path);

        Image ResizeImage(Image imgToResize, Size size);

        Image DrawMouse(Image Original, Image Second, int X, int Y, Color color, int size);

    }
}
