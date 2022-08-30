using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileApp
{
    public static class XmlFileAction
    {
        private static string FilePath = @"D:\For_HW1-12";

        public static void Write(Deposit deposit, string fileName)
        {
            string FullPath = $@"{FilePath}/{fileName}";

            var xdoc = new XmlDocument();

            var root = xdoc.CreateElement("Deposit");

            var nameElement = xdoc.CreateElement("Name");
            var durationElement = xdoc.CreateElement("Duration");
            var percentProfitElement = xdoc.CreateElement("PercentProfit");
            var isMonthlyCapitalizedElement = xdoc.CreateElement("IsMonthlyCapitalized");

            var nameElementValue = xdoc.CreateTextNode(deposit.Name);
            nameElement.AppendChild(nameElementValue);

            var durationElementValue = xdoc.CreateTextNode(deposit.Duration.ToString());
            durationElement.AppendChild(durationElementValue);

            var percentProfitElementValue = xdoc.CreateTextNode(deposit.PercentProfit.ToString());
            percentProfitElement.AppendChild(percentProfitElementValue);

            var isMonthlyCapElementValue = xdoc.CreateTextNode(deposit.IsMonthlyCapitalized.ToString());
            isMonthlyCapitalizedElement.AppendChild(isMonthlyCapElementValue);

            root.AppendChild(nameElement);
            root.AppendChild(durationElement);
            root.AppendChild(percentProfitElement);
            root.AppendChild(isMonthlyCapitalizedElement);

            xdoc.AppendChild(root);

            using (var file = File.Create(FullPath))
            {
                xdoc.Save(file);
            }

        }

        public static Deposit Read(string fileName)
        {
            var xdoc = new XmlDocument();

            string FullPath = $@"{FilePath}/{fileName}";

            using (var file = File.Open(FullPath, FileMode.Open))
            {
                xdoc.Load(file);
            }
            var depositObject = new Deposit();

            var deposit = xdoc.ChildNodes[0];

            depositObject.Name = deposit["Name"].InnerText;
            depositObject.Duration = int.Parse(deposit["Duration"].InnerText);
            depositObject.PercentProfit = double.Parse(deposit["PercentProfit"].InnerText);
            depositObject.IsMonthlyCapitalized = bool.Parse(deposit["IsMonthlyCapitalized"].InnerText);
            
            return depositObject;
        }

        public static void Write(List<Deposit> deposits, string fileName)
        {
            string FullPath = $@"{FilePath}/{fileName}";

            var xdoc = new XmlDocument();

            var root = xdoc.CreateElement("ArrayOfDeposits");

            foreach (var deposit in deposits)
            {
                var instance = xdoc.CreateElement("Deposit");

                var nameElement = xdoc.CreateElement("Name");
                var durationElement = xdoc.CreateElement("Duration");
                var percentProfitElement = xdoc.CreateElement("PercentProfit");
                var isMonthlyCapitalizedElement = xdoc.CreateElement("IsMonthlyCapitalized");

                var nameElementValue = xdoc.CreateTextNode(deposit.Name);
                nameElement.AppendChild(nameElementValue);

                var durationElementValue = xdoc.CreateTextNode(deposit.Duration.ToString());
                durationElement.AppendChild(durationElementValue);

                var percentProfitElementValue = xdoc.CreateTextNode(deposit.PercentProfit.ToString());
                percentProfitElement.AppendChild(percentProfitElementValue);

                var isMonthlyCapElementValue = xdoc.CreateTextNode(deposit.IsMonthlyCapitalized.ToString());
                isMonthlyCapitalizedElement.AppendChild(isMonthlyCapElementValue);

                instance.AppendChild(nameElement);
                instance.AppendChild(durationElement);
                instance.AppendChild(percentProfitElement);
                instance.AppendChild(isMonthlyCapitalizedElement);

                root.AppendChild(instance);
            }
            xdoc.AppendChild(root);

            using (var file = File.Create(FullPath))
            {
                xdoc.Save(file);
            }
        }

        public static List<Deposit> ReadMany(string fileName)
        {
            var xdoc = new XmlDocument();

            string FullPath = $@"{FilePath}/{fileName}";

            using (var file = File.Open(FullPath, FileMode.Open))
            {
                xdoc.Load(file);
            }
            
            var results = new List<Deposit>();

            var depositObject = new Deposit();

            var depositsArray = xdoc.ChildNodes[0];

            var deposits = depositsArray.ChildNodes;

            foreach(XmlElement deposit in deposits)
            {
                depositObject.Name = deposit["Name"].InnerText;
                depositObject.Duration = int.Parse(deposit["Duration"].InnerText);
                depositObject.PercentProfit = double.Parse(deposit["PercentProfit"].InnerText);
                depositObject.IsMonthlyCapitalized = bool.Parse(deposit["IsMonthlyCapitalized"].InnerText);
                
                results.Add(depositObject);
            }

            return results;
        }
    }
}
