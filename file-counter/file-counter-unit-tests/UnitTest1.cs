using file_counter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;


namespace file_counter_unit_tests
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 f = new Form1();
        [TestMethod]
        public void ParameterCheckDoesntThrowExceptionIfCorrect()
        {
            string parameterStr = "5";
            int parameter = Form1.ParseParameter(parameterStr);
        }

        [TestMethod]
        public void ParameterCheckThrowsExceptionIfHasIncorrectCharacters()
        {
            string parameterStr = "5a";
            Assert.ThrowsException<System.ArgumentException>(() => Form1.ParseParameter(parameterStr));
        }

        [TestMethod]
        public void ParameterCheckThrowsExceptionIfEmpty()
        {
            string parameterStr = "5a";
            Assert.ThrowsException<System.ArgumentException>(() => Form1.ParseParameter(parameterStr));
        }

        [TestMethod]
        public void DirectoryPathCheckThrowsExceptionIfDoesntExist()
        {
            string path = @":\Users\abc123";
            Assert.ThrowsException<System.ArgumentException>(() => Form1.CheckDirectoryPath(path));
        }

        [TestMethod]
        public void DirectoryPathCheckThrowsExceptionIfEmpty()
        {
            string path = "";
            Assert.ThrowsException<System.ArgumentException>(() => Form1.CheckDirectoryPath(path));
        }

        [TestMethod]
        public void DirectoryPathCheckThrowsExceptionIfHasIncorrectCharacters()
        {
            string path = @"C:\Users\abc12[]3";
            Assert.ThrowsException<System.ArgumentException>(() => Form1.CheckDirectoryPath(path));
        }

    }
}
