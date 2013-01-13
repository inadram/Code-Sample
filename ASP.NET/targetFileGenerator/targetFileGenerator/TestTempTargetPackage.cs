using System;
using System.IO;
using NUnit.Framework;

namespace targetFileGenerator
{
    [TestFixture]
    class TestTempTargetPackage
    {
        [SetUp]
        public void SetUp()
        {
            CreateTempSourceFiles();
        }

        [Test]
        public void Given_addressOfTargetPackage_and_SourceFile_when_MoveSelectedFilesToTargetProject_then_FilesShouldCopied()
        {
            var tempTargetPackage = new TempTargetPackage();
            CreateTempSourceFiles();

            tempTargetPackage.MoveSelectedFilesToTargetProject("TestSourceFile","TestTargetAddress");
            Assert.True(File.Exists("TestSourceFile/Temp1/Temp2/testsource.txt"));
        }

        private void CreateTempSourceFiles()
        {
            Directory.CreateDirectory("TestSourceFile/Temp1/Temp2");
            
            File.Create("TestSourceFile/testsource.txt");
            File.Create("TestSourceFile/Temp1/testsource.txt");
            File.Create("TestSourceFile/Temp1/temp1.txt");
            File.Create("TestSourceFile/Temp1/tempfile.tmp");
            File.Create("TestSourceFile/Temp1/Temp2/testsource.txt");
            File.Create("TestSourceFile/Temp1/Temp2/tempfile2.tmp");
            GC.Collect();
        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        [TearDown]
        public void TearDown()
        {
            DeleteDirectory("TestSourceFile");
            DeleteDirectory("TestTargetAddress");
        }
    }
}
