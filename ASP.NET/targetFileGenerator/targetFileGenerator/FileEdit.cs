using System.IO;

namespace targetFileGenerator
{
    public class FileEdit
    {
        private static StreamReader _StreamReader;
        private static StreamWriter _streamWriter;

        public static string ReadFile(string addressOfFile)
        {
            _StreamReader = new StreamReader(addressOfFile);
            string Text = _StreamReader.ReadToEnd();
            _StreamReader.Close();
            return Text;
        }
        public static void WriteFile(string addressOfFile, string Text)
        {
            _streamWriter = new StreamWriter(addressOfFile);
            _streamWriter.WriteLine(Text);
            _streamWriter.Close();
        }
    }
}
