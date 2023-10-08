using System.Globalization;
using System.Text;



public class Log
{
    public static void WriteLine(string format, params object[] args)
    {
        string filename = "log.txt";
        bool needAppend = true;
        FileInfo fileInfo = new FileInfo(filename);
        if (fileInfo.Exists && fileInfo.Length > 2 * 1024 * 1024)
        {
            needAppend = false;
        }
        StreamWriter stream;
        stream = new StreamWriter(filename, needAppend, Encoding.Default);
        string msg = string.Format(CultureInfo.InvariantCulture, format, args);
        stream.WriteLine(DateTime.Now.ToString() + ": " + msg);
        stream.Flush();
        stream.Dispose();
    }
}