using System;
using System.IO;

namespace ScheduleLogic.Helpers
{
    public static class FileSaver
    {
        public static bool SaveFile(string path, byte[] data, bool overwrite = false)
        {
            try
            {
                if (overwrite && File.Exists(path))
                    throw new Exception($"File Exists: {path}");

                using (var fs = new FileStream(path, FileMode.CreateNew))
                using (var bs = new BufferedStream(fs))
                using (var sw = new StreamWriter(bs))
                {
                    sw.Write(data);
                    sw.Flush();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}