using System;
using System.IO;

namespace targetFileGenerator
{
    class TempTargetPackage
    {
      
        public void MoveSelectedFilesToTargetProject(string addressOfSourceFile,string addressOfTargetPackage)
        {
             CreateTargetPackageFolder(addressOfTargetPackage);
             CopySourceFilesIntoTargetprojectDirectory(addressOfSourceFile,addressOfTargetPackage);
        }

        private static void CreateTargetPackageFolder(string addressOfTargetPackage)
        {
            try
            {
                 Directory.CreateDirectory(addressOfTargetPackage);
            }
            catch (Exception){}
               
        }

        private static void CopySourceFilesIntoTargetprojectDirectory(string addressOfSourceFile,string addressOfTargetPackage)
        {
                CopyDirectories(addressOfSourceFile, addressOfTargetPackage);
                CopyFiles(addressOfSourceFile, addressOfTargetPackage);
        }

        private static void CopyDirectories(string addressOfSourceFile, string addressOfTargetPackage)
        {
            try
            {
                foreach (string dirPath in Directory.GetDirectories(addressOfSourceFile, "*",
                                                                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(addressOfSourceFile, addressOfTargetPackage));
            }
            catch (Exception) { }
        }

        private static void CopyFiles(string addressOfSourceFile, string addressOfTargetPackage)
        {
            try
            {
                foreach (string newPath in Directory.GetFiles(addressOfSourceFile, "*.*",
                                                              SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(addressOfSourceFile, addressOfTargetPackage));

            }
            catch (Exception) { }
        }

    }
}
