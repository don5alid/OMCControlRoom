using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OMCControlRoomApplication
{
    class OMCControl
    {
        public static void HandleException(Exception ex)
        {
            Console.Beep();
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception: {0}", ex.Message);
                System.Diagnostics.Debug.WriteLine("Exception: {0}", ex.Message);
                Console.WriteLine();
                System.Diagnostics.Debug.WriteLine("");
                Console.WriteLine("Exception: {0}", ex.StackTrace);
                System.Diagnostics.Debug.WriteLine("Exception: {0}", ex.StackTrace);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                var dir = string.Format(@"d:\Exceptions\{0}\", LocalTime.ToString("yyyyMMdd"));
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                var path = string.Format(@"{0}{1}{2}.txt", dir, LocalTime.ToString("hhmmss"), LocalTime.Millisecond);
                if (File.Exists(path))
                    path = string.Format(@"{0}{1}{2}.txt", dir, LocalTime.ToString("hhmmss"), LocalTime.Millisecond);
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine(ex.Message);
                    file.WriteLine(ex.StackTrace);
                    file.WriteLine(ex.InnerException);
                    file.WriteLine(ex.Data);
                    file.WriteLine(ex.Source);
                }
                Log(LogType.ErrorLog, ex.Message);
            }
            catch { }
        }

        public static DateTime LocalTime
        {
            get
            {
               
                return DateTime.UtcNow.AddHours(3);
            }
        }

        public static string TraceCode([CallerFilePath] string path = null, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
        {
            var file = new System.IO.FileInfo(path);
            var filename = file.Name.Substring(0, file.Name.Length - file.Extension.Length);
            var s = string.Format(" --Running code is {2}, {0}@Line: {1}.", caller, lineNumber, filename);
            Console.WriteLine(s);
            System.Diagnostics.Debug.WriteLine(s);
            Logger _logger = LogManager.GetCurrentClassLogger();
            return s;
        }
        public static string Log(LogType Type, string LogMsg, [CallerFilePath] string path = null, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            var file = new System.IO.FileInfo(path);
            var filename = file.Name.Substring(0, file.Name.Length - file.Extension.Length);
            Console.WriteLine(LogMsg);
            var Msg = LogMsg;
            LogMsg = string.Format("Line: {0}@ {1}>{2}:       {3}", lineNumber, filename, caller, LogMsg);
            if (!string.IsNullOrEmpty(LogMsg))
                switch (Type)
                {
                    case LogType.WarnLog: logger.Warn(LogMsg); break;
                    case LogType.TraceLog: logger.Trace(LogMsg); break;
                    case LogType.DebugLog: logger.Debug(LogMsg); break;
                    case LogType.ErrorLog: logger.Error(LogMsg); break;
                    case LogType.FetalLog: logger.Fatal(LogMsg); break;
                    case LogType.InfoLog: logger.Info(LogMsg); break;
                }

            ///datetimg,file, method,line,type,lineNumber
       


            return Msg;
        }

        private static Random rand = new Random();
        public static int RandomNumber(int min, int max)
        {
            lock (new Object())
                return rand.Next(min, max);
        }


    }
}
