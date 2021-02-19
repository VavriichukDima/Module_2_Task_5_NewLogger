using System.IO;

namespace Module_2_Task_1
{
    public class FileService
    {
        public void Write(string path, string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
