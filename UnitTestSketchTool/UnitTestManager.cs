using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using NSubstitute;
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace UnitTestSketchTool
{
    [TestClass]
    public class UnitTestManager
    {

        [TestMethod]
        public void TestOpenPicture()
        {
            //Create a subsitute
            var IManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(IManager);

            //Create an test image
            String path = "..\\..\\img\\PictureResized.png";
            Image image = Image.FromFile(path);

            //Define the return of this method
            IManager.OpenPicture(path).Returns(image);

            //The choosen filename should be returned
            Assert.AreEqual(image.Width, controller.OpenPicture(path).Width);

            //check if the image height is equals
            Assert.AreEqual(image.Height, controller.OpenPicture(path).Height);
        }

        [TestMethod]
        public void TestOpenPictureWithException()
        {
            //Create a subsitute
            var IManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(IManager);

            //Throw Exception
            IManager.When(x => x.OpenPicture(null)).Do(x => { throw new Exception(); });

            try
            {
                controller.OpenPicture(null);
            }
            catch
            {
                //If the exception will be thrown the test is succesfully
                Assert.AreEqual(null, controller.OpenPicture(null));
            }
        }


        [TestMethod]
        public void TestSavePicture()
        {
            //Create a subsitute
            var IManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(IManager);

            //Create an test Image
            String path = "..\\..\\img\\";
            String filename = "PictureTest.png";
            Image image = Image.FromFile("..\\..\\img\\PictureTest.png");

            //Define the return of this method
            IManager.SavePicture(path, filename, image).Returns(true);

            controller.SavePicture(path, filename, image);

            //check if the image is iqual
            Assert.AreEqual(true, controller.SavePicture(path, filename, image));
        }


        [TestMethod]
        public void TestSavePictureWithException()
        {
            //Create a subsitute
            var IManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(IManager);

            //Create an test image
            String path = "..\\..\\img\\PictureTest.PNG";
            Image image = Image.FromFile(path);

            //Throw exception
            IManager.When(x => x.SavePicture(null, null,image)).Do(x => { throw new Exception(); });

            try
            {
                controller.SavePicture(null, null, image);
            }
            catch
            {
                //If the exception will be thrown the test is succesfully
                Assert.AreEqual(false, IManager.SavePicture(null, null, null));
            }
        }

        [TestMethod]
        public void TestResizePicture()
        {
            //Create a subsitute
            var IManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(IManager);

            //Create an Test Image
            String PathTest = "..\\..\\img\\PictureResized.png";
            Image ImageTest = Image.FromFile(PathTest);

            //Define the return of this method
            IManager.ResizeImage(ImageTest, new Size(800, 400)).Returns(ImageTest);

            //check if the width is equal
            Assert.AreEqual(ImageTest.Width, controller.ResizeImage(ImageTest, new Size(800, 400)).Width);

            //check if the height is equal
            Assert.AreEqual(ImageTest.Height, controller.ResizeImage(ImageTest, new Size(800, 400)).Height);

        }

        [TestMethod]
        public void TestDrawPicture()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureManager controller = new PictureManager(PictureManager);

            //Create an Test Image
            String PathTest = "..\\..\\img\\PictureTest.png";
            Image image = Image.FromFile(PathTest);

            Color color = Color.Black;

            //Define the return of this method
            PictureManager.DrawMouse(image, image, Arg.Any<int>(), Arg.Any<int>(), color, Arg.Any<int>()).Returns(image);

            //To image should be equal
            Assert.AreEqual(image, controller.DrawMouse(image, image, Arg.Any<int>(), Arg.Any<int>(), color, Arg.Any<int>()));

        }
    }
}
