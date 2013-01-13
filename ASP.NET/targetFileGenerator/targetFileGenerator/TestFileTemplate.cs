using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace targetFileGenerator
{
    [TestFixture]
    class TestFileTemplate
    {
        [Test]
        public void Given_addressOftemplateFile_and_TargetFile_extensionList_when_GenerateTemplate_then_targetFileShouldGenerated()
        {
            var fileTemplate = new FileTemplate();
             var excludeExtension = new List<string> { "txt", "temp" };
             var hashtable = new Hashtable { { "extention", excludeExtension } };
            string addressOftemplateFile = "../../src/TargetFileTemplate.txt";
            fileTemplate.GenerateTemplate(addressOftemplateFile, "fakeAddressOfTargetFile.targets", hashtable);
            Assert.True(File.Exists("fakeAddressOfTargetFile.targets"));
        }

        [Test]
        public void Given_addressOftemplateFile_and_TargetFile_extensionList_when_GenerateTemplate_then_targetFileShouldHaveExcludeListLine()
        {
            var fileTemplate = new FileTemplate();
            var excludeExtension = new List<string> { "txt", "temp" };
            var hashtable = new Hashtable { { "extention", excludeExtension } };
            string addressOftemplateFile = "../../src/TargetFileTemplate.txt";
            fileTemplate.GenerateTemplate(addressOftemplateFile, "fakeAddressOfTargetFile.targets", hashtable);
            var streamReader = new StreamReader("fakeAddressOfTargetFile.targets");
            string targetfilecontent = streamReader.ReadToEnd();
            streamReader.Close();

            string expectedContent = "TempTargetPackageFolderForGeneratingTargetFile/**/*.txt;TempTargetPackageFolderForGeneratingTargetFile/**/*.temp;";
            Assert.IsTrue(targetfilecontent.Contains(expectedContent));
        }

        [Test]
        public void Given_addressOftemplateFile_and_TargetFile_excludeList_when_GenerateTemplate_then_targetFileShouldHaveExcludeListLine()
        {
            var fileTemplate = new FileTemplate();
            var excludeExtension = new List<string> { "txt", "temp" };
            var excludestartWith = new List<string> { "starttemp", "t" };
            var excludeendWith = new List<string> { "endtemp", "p" };
            var hashtable = new Hashtable { { "extention", excludeExtension }, { "startWith", excludestartWith }, { "endWith", excludeendWith } };
            string addressOftemplateFile = "../../src/TargetFileTemplate.txt";
            fileTemplate.GenerateTemplate(addressOftemplateFile, "fakeAddressOfTargetFile.targets", hashtable);
            var streamReader = new StreamReader("fakeAddressOfTargetFile.targets");
            string targetfilecontent = streamReader.ReadToEnd();
            streamReader.Close();

            string expectedExtensionExclude = "TempTargetPackageFolderForGeneratingTargetFile/**/*.txt;TempTargetPackageFolderForGeneratingTargetFile/**/*.temp;";
            Assert.IsTrue(targetfilecontent.Contains(expectedExtensionExclude));

            string expectedstartwithExclude = "TempTargetPackageFolderForGeneratingTargetFile/**/starttemp*.*;TempTargetPackageFolderForGeneratingTargetFile/**/t*.*;";
            Assert.IsTrue(targetfilecontent.Contains(expectedstartwithExclude));

            string expectedendwithExclude = "TempTargetPackageFolderForGeneratingTargetFile/**/*endtemp.*;TempTargetPackageFolderForGeneratingTargetFile/**/*p.*;";
            Assert.IsTrue(targetfilecontent.Contains(expectedendwithExclude));

        }

    }
}
