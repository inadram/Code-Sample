using System.Collections.Generic;

namespace targetFileGenerator
{
    class TargetFileDTO
    {
        public static string projectAddress { get; set; }
        public static string projectName { get; set; }
        public static string sourceAddress { get; set; }
        public static List<string> excludeExtensions { get; set; }
        public static List<string> excludeStartWith { get; set; }
        public static List<string> excludeEndWith { get; set; }
    }
}
