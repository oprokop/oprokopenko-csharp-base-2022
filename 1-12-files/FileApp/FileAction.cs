using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApp
{
    public static class FileAction
    {
        private static string FilePath = @"D:\For_HW1-12";

        public static void Write<T>(string fileName, T data)
            where T : class
        {
            string FullPath = $@"{FilePath}/{fileName}";

            using (var file = File.Create(FullPath))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.Write(data);
                }
            }
        }

        public static T Read<T>(string fileName, Func<string, T> createInstance)
            where T : class
        {
            string FullPath = $@"{FilePath}/{fileName}";


            if (File.Exists(FullPath))
            {
                using (var reader = new StreamReader(File.Open(FullPath, FileMode.Open)))
                {
                    var line = reader.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        return createInstance(line);
                    }
                    else return null;
                }
            }
            else return null;
        }

        public static void Write<T>(string fileName, List<T> data)
            where T: class
        {
            string FullPath = $@"{FilePath}/{fileName}";

            using (var file = File.Create(FullPath))
            {
                using (var writer = new StreamWriter(file))
                {
                    foreach(var item in data)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }

        public static List<T> ReadMany<T>(string fileName, Func<string, T> createInstance)
            where T: class
        {
            string FullPath = $@"{FilePath}/{fileName}";

            if (File.Exists(FullPath))
            {
                var listOfInstances = new List<T>();

                using (var reader = new StreamReader(File.Open(FullPath, FileMode.Open)))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                            break;
                        if (!string.IsNullOrEmpty(line))
                        {
                            var instance = createInstance(line);

                            listOfInstances.Add(instance);
                        }
                    }
                }
                return listOfInstances;
            }
            else return null;
        }
    }
}
