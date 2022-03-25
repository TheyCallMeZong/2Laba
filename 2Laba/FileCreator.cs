using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace _2Laba
{
    public static class FileCreator
    {
        public static void Create(string name)
        {
            string filePath = @$"D:\ТиМП\2Laba\2Laba\{name}.cs";
            string[] text = new string[]
            {
                "namespace _2Laba" + "{",
                $"\tpublic class {name}" + "{",
                $"\t\tpublic {name}()" + "{",
                $"\t\t\tMessageBox.Show(\"Hello from {name}\");",
                "\t\t}",
                "\t}",
                "}"
            };

            Stream stream = File.OpenWrite(filePath);

            StreamWriter sw = new StreamWriter(stream);
            foreach (var item in text)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }
    }
}