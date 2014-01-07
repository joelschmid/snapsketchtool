using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using NSubstitute;
using System.IO;
using System.Drawing;


namespace UnitTestSketchTool
{
    [TestClass]
    public class UnitTestGUI
    {

        [TestMethod]
        public void TestOpenPicture()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Create an test image
            String path = "..\\..\\img\\PictureTest.png";
            Image image = Image.FromFile(path);

            //Define the return of this method
            PictureManager.OpenPicture(path).Returns(image);
           
            //the 2 images should be equals
            Assert.AreEqual(image, controller.OpenPicture(path));
        }

        [TestMethod]
        public void TestOpenPictureWithException()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Throw exception
            PictureManager.When(x => x.OpenPicture(null)).Do(x => { throw new FileNotFoundException(); });

            try
            {
                controller.OpenPicture(null);
            }
            catch
            {
                //If an exception will be thrown the test is succesfully
                Assert.AreEqual(null, PictureManager.OpenPicture(null));
            }
        }


        [TestMethod]
        public void TestSavePicture()
        {
            //Create a subsitute from the interface
             var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Create an Image
            String path = "C:/Users/uadmin/Desktop/";
            String filename = "test.png";
            Image image = Image.FromFile("..\\..\\img\\PictureTest.png");

            //Define the return of this method
            PictureManager.SavePicture(path, filename, image).Returns(true);

            controller.SavePicture(path, filename, image);

            //savepicture should return a true value
            Assert.AreEqual(true, controller.SavePicture(path, filename, image));
        }


        [TestMethod]
        public void TestSavePictureWithException()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Throw Exception
            PictureManager
                .When(x => x.SavePicture(Arg.Any<string>(), Arg.Any<string>(), null))
                .Do(x => { throw new Exception(); });
            try
            {
                controller.SavePicture(null, null, null);
            }
            catch
            {
                ///If an exception will be thrown the test is succesfully
                Assert.AreEqual(null, PictureManager.SavePicture(null, null, null));
            }
        }

        [TestMethod]
        public void TestResizePicture()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Create an Test Image
            String PathTest = "..\\..\\img\\PictureTest.png";
            Image ImageTest = Image.FromFile(PathTest);

            //Define the return of this method
            PictureManager.ResizeImage(ImageTest, new Size(800, 400)).Returns(ImageTest);

            //check if the widht is equal
            Assert.AreEqual(ImageTest.Width, controller.ResizeImage(ImageTest, new Size(800, 400)).Width);

            //check if the height is equal
            Assert.AreEqual(ImageTest.Height, controller.ResizeImage(ImageTest, new Size(800, 400)).Height);

        }

        [TestMethod]
        public void TestResizePictureWithException()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Throw exception
            PictureManager.When(x => x.ResizeImage(null,new Size())).Do(x => { throw new Exception(); });

            try
            {
                controller.ResizeImage(null,new Size());
            }
            catch
            {
                //If an exception will be thrown the test is succesfully
                Assert.AreEqual(null, PictureManager.ResizeImage(null,new Size()));
            }
        }


        [TestMethod]
        public void TestDrawPicture()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Create an Test Image
            String PathTest = "..\\..\\img\\PictureTest.png";
            Image image = Image.FromFile(PathTest);

            Color color = Color.Black;

            //Define the return of this method
            PictureManager.DrawMouse(image, image, Arg.Any<int>(),Arg.Any<int>(), color, Arg.Any<int>()).Returns(image);

            //To 2 images should be equals
            Assert.AreEqual(image, controller.DrawMouse(image, image, Arg.Any<int>(),Arg.Any<int>(), color, Arg.Any<int>()));
          
        }

        [TestMethod]
        public void TestDrawPictureWithException()
        {
            //Create a subsitute
            var PictureManager = Substitute.For<IPictureManager>();

            //Create an instance of the controller
            PictureController controller = new PictureController(PictureManager);

            //Throw exception
            PictureManager.When(x => x.DrawMouse(null, null, 0, 0, Color.Black,0)).Do(x => { throw new Exception(); });

            try
            {
                controller.DrawMouse(null, null, 0, 0, Color.Black,0);
            }
            catch
            {
                //If an exception will be thrown the test is succesfully
                Assert.AreEqual(null, PictureManager.DrawMouse(null, null, 0, 0, Color.Black,0));
            }
        }

    }
}
