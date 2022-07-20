using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileApp
{
    public static class XmlGenericFileAction<T>
        where T : class
    {
        private static string FilePath = @"D:\For_HW1-12";

        public static T Read(string fileName)
        {
            var xdoc = new XmlDocument();

            string FullPath = $@"{FilePath}/{fileName}";

            if (File.Exists(FullPath))
            {
                using (var file = File.Open(FullPath, FileMode.Open))
                {
                    xdoc.Load(file);
                }

                var type = typeof(T);
                var obj = Activator.CreateInstance(type) as T;
                
                var root = xdoc.ChildNodes[0];
                var xdocNodes = root.ChildNodes;

                foreach (XmlElement xdocNode in xdocNodes)
                {
                    var props = type.GetProperties();

                    foreach (var prop in props)
                    {
                        if (prop.PropertyType.Name == typeof(int).Name)
                        {
                            prop.SetValue(obj, int.Parse(xdocNode[prop.Name].InnerText));
                        }
                        else if (prop.PropertyType.Name == typeof(double).Name)
                        {
                            prop.SetValue(obj, double.Parse(xdocNode[prop.Name].InnerText));
                        }
                        else if (prop.PropertyType.Name == typeof(bool).Name)
                        {
                            prop.SetValue(obj, bool.Parse(xdocNode[prop.Name].InnerText));
                        }
                        else if (prop.PropertyType.Name == typeof(string).Name)
                        {
                            prop.SetValue(obj, xdocNode[prop.Name].InnerText);
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                }

                return obj;
            }

            else return null;
        }

        public static List<T> ReadMany(string fileName)
        {
            var xdoc = new XmlDocument();

            string FullPath = $@"{FilePath}/{fileName}";

            if (File.Exists(FullPath))
            {
                using (var file = File.Open(FullPath, FileMode.Open))
                {
                    xdoc.Load(file);
                }

                var results = new List<T>();

                var type = typeof(T);
                var obj = Activator.CreateInstance(type) as T;

                var root = xdoc.ChildNodes[0];
                var xdocInstances = root.ChildNodes;

                foreach(XmlElement xdocInstance in xdocInstances)
                {
                    var xdocNodes = xdocInstance.ChildNodes;

                    foreach (XmlElement xdocNode in xdocNodes)
                    {
                        var props = type.GetProperties();

                        foreach (var prop in props)
                        {
                            if (prop.PropertyType.Name == typeof(int).Name)
                            {
                                prop.SetValue(obj, int.Parse(xdocNode[prop.Name].InnerText));
                            }
                            else if (prop.PropertyType.Name == typeof(double).Name)
                            {
                                prop.SetValue(obj, double.Parse(xdocNode[prop.Name].InnerText));
                            }
                            else if (prop.PropertyType.Name == typeof(bool).Name)
                            {
                                prop.SetValue(obj, bool.Parse(xdocNode[prop.Name].InnerText));
                            }
                            else if (prop.PropertyType.Name == typeof(string).Name)
                            {
                                prop.SetValue(obj, xdocNode[prop.Name].InnerText);
                            }
                            else
                            {
                                throw new FormatException();
                            }

                            results.Add(obj);
                        }
                    }
                }

                return results;
            }

            else return null;
        }
    }
}
