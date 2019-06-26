using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void SendTest()
        {
            //arrange
            Mod4.Model.BasicTransferManager mgr = new Mod4.Model.BasicTransferManager();
            Mod4.Model.IPackage pck = new Mod4.Model.BasicPackage();
            pck.Name = "Test1";
            pck.TrackingNumber = Guid.NewGuid();
            pck.Files.Add(new System.IO.FileInfo("c:\\test1.txt"));
            pck.Files.Add(new System.IO.FileInfo("c:\\test2.txt"));
            //act
            mgr.Send(pck, "c:\\dest");

            //assert
            System.IO.DirectoryInfo destDir = new System.IO.DirectoryInfo("c:\\dest");
            Assert.IsTrue(destDir.GetFiles().Length == 2);
        }
    }
}
