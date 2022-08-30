using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileApp
{
    public static class JsonFileAction<T>
        where T : class
    {
        private static string FilePath = @"D:\For_HW1-12";

        public static void Write<T>(T instance, string fileName)
        {
            string FullPath = $@"{FilePath}/{fileName}";

            var jsonOption = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var jString = JsonSerializer.Serialize<T>(instance, jsonOption);

            File.AppendAllText(FullPath, jString);
        }

        public static T Read(string fileName)
        {
            var jsonOption = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string FullPath = $@"{FilePath}/{fileName}";

            var jString = File.ReadAllText(FullPath);

            var jInstance = JsonSerializer.Deserialize<T>(jString, jsonOption);

            return jInstance;
        }

        public static void Write(List<T> instances, string fileName)
        {
            var jsonOption = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var jStrings = JsonSerializer.Serialize(instances, jsonOption);

            string FullPath = $@"{FilePath}/{fileName}";

            File.AppendAllText(FullPath, jStrings);
        }

        public static List<T> ReadMany(string fileName)
        {
            var jsonOption = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string FullPath = $@"{FilePath}/{fileName}";

            var jStrings = File.ReadAllText(FullPath);

            var jInstances  = JsonSerializer.Deserialize<List<T>>(jStrings, jsonOption);
            
            return jInstances;
        }
    }
}
