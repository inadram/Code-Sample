using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace targetFileGenerator
{
    class FileTemplate
    {
        private string _template;

        public void GenerateTemplate(string addressOftemplateFile, string addressOfTargetFile, Hashtable excludList)
        {
            MakeDefaultTemplateFile(addressOftemplateFile, addressOfTargetFile);
            string startWithString = GetStartWithString(excludList);
            string endWithString = GetEndWithString(excludList);
            string extensionString = GetExtensionString(excludList);

            string excludeListString = startWithString + endWithString + extensionString;
            AddExcludeExtensionListToTemplateFile(excludeListString, addressOfTargetFile);
        }

        
        private void MakeDefaultTemplateFile(string addressOftemplateFile, string addressOfTargetFile)
        {
            _template = FileEdit.ReadFile(addressOftemplateFile);
            FileEdit.WriteFile(addressOfTargetFile, _template);
           
        }

        private void AddExcludeExtensionListToTemplateFile(string extensionString, string addressOfTargetFile)
        {
            var RegexExcludeFile = new Regex("ExcFile");
            _template = RegexExcludeFile.Replace(_template, extensionString);
            FileEdit.WriteFile(addressOfTargetFile, _template);
        }

        
        private static string GetStartWithString(Hashtable excludeList)
        {
            string startWithString = string.Empty;
            try
            {
                var startWithList = excludeList["startWith"] as List<string>;
                    startWithString = startWithList.Aggregate(string.Empty, (current, excludeStartWith) => current + ("TempTargetPackageFolderForGeneratingTargetFile/**/"+excludeStartWith+"*.*;"));
            }
            catch (Exception) { }
            return startWithString;
        }

        private static string GetEndWithString(Hashtable excludeList)
        {
            string endWithString = string.Empty;
            try
            {
                var endWithList = excludeList["endWith"] as List<string>;
                    endWithString = endWithList.Aggregate(string.Empty, (current, excludeEndWith) => current + ("TempTargetPackageFolderForGeneratingTargetFile/**/*" + excludeEndWith + ".*;"));

            }
            catch (Exception) { }
            return endWithString;
        }

        private static string GetExtensionString(Hashtable excludeList)
        {
            string extensionString = string.Empty;
            try
            {
                var extensionList = excludeList["extention"] as List<string>;
                    extensionString = extensionList.Aggregate(string.Empty, (current, excludeExtension) => current + ("TempTargetPackageFolderForGeneratingTargetFile/**/*." + excludeExtension + ";"));
           
            }
            catch (Exception){}
            return extensionString;
        }

       
      
    }
}
