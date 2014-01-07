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
    public class ManagerController
    {
        private readonly IPictureManager  manager;
        private bool draw = false;
        private int size = 1;
        private Color color = Color.Black;
        Image Second = null;
        Image Original = null;
        Image PictureBox = null;
        String textBox3 = "";


        public ManagerController(IPictureManager manager)
        {
            this.manager = manager;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            //Get original Picture
            Original = PictureBox;
            //save a copy of the original save
            Second = PictureBox;

            //set a the draw boolean variable of true, because we are drawing
            draw = true;

            //call DrawMouse Mehtod in the manager to draw the picture
            Image DrawImage = manager.DrawMouse(Original, Second, e, color, size);

            //add the draw image to picture box
            PictureBox = DrawImage;
        }

        /**
        * This Method will be called by mouse up
        * @param object sender, MouseEventArgs
        */
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //set a the draw boolean variable of false, because we are finish with drawing
            draw = false;

        }

        /**
        * This Method will be called by mouse move
        * @param object sender, MouseEventArgs
        */
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //check if the draw variable true
            if (draw)
            {
                //Draw the linies to the picture
                Image DrawImage = manager.DrawMouse(Original, Second, e, color, size);
                //Save the draw image
                PictureBox = Second;
            }

        }

        /**
        * This Method will be called, to choose the colour
        * @param object sender, EventArgs e
        */
        private void btSketch_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Color newcolor = cd.Color;
            color = newcolor;
        }

        /**
        * This Method will be called, to save the picture
        * @param object sender, EventArgs e
        */
        private void btSave_Click(object sender, EventArgs e)
        {
            //check if the path is set
            if (!string.IsNullOrEmpty(textBox3) && !textBox3.Equals("Name mandatory"))
            {
                //Open File Open Dialog
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                if (fd.SelectedPath != null)
                {
                    string path = fd.SelectedPath;
                    string filename = textBox3;
                    Image savePicture = PictureBox;

                    //Save the picture
                    manager.SavePicture(path, filename, savePicture);

                }
            }
            else
            {
                textBox3 = "Name mandatory";
            }

        }

        /**
        * This Method will be called, to clear the file name
        * @param object sender, EventArgs e
        */
        private void btClear_Click(object sender, EventArgs e)
        {
            textBox3.ResetText();
        }

        /**
         * Track Bar Thickness set
         * @param object sender, EventArgs e
         */
        private void tbthickness_Scroll(object sender, EventArgs e)
        {
            lblIndicator.Text = thickness.Value.ToString();
            size = int.Parse(thickness.Value.ToString());
        }

        /**
         *  This Method will be called, to open a file
         * @param object sender, EventArgs e
         */
        private void btLoad_Click(object sender, EventArgs e)  // Open File
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.ShowDialog();
            string PathToImage = OpenDialog.FileName;

            //Open the picture
            PictureBox = manager.OpenPicture(PathToImage); ;
        }
    }
}
