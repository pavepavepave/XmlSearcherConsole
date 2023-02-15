using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace XmlSearcherConsole
{
    internal class Program
    {
        static void Main()
        {
            string path = @"D:\Games\UniplayPW151\element\interfaces.pck.files\interfaces\version01";
            string searchAtributt = "Txt_Agreement";
            var fw = Directory.GetFiles(path,"*.xml" ,SearchOption.AllDirectories);
            foreach (var file in fw)
            {
                var openFiles = File.ReadAllText(file);
                if(openFiles.Contains(searchAtributt))
                    Console.WriteLine(file);

            }
        }
    }
}
