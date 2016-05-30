using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    class Logger
    {
        private static string _logFilePath;

        public static string FilePath
        {
            get { return _logFilePath; }
            set
            {
                if (value.Length > 0) Logger._logFilePath = value;
            }
        }

        public static void Flush()
        {
            File.WriteAllText(Logger.FilePath, string.Empty);
        }

        public static void Log(string msg)
        {
            if (msg.Length > 0)
            {
                using (StreamWriter sw = File.AppendText(Logger.FilePath))
                {
                    sw.WriteLine("{0} {1}: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), msg);
                    sw.Flush();
                }
            }
        }
    }
}