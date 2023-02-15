using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace XmlSearcherConsole
{
    internal class Program
    {
        static void Main()
        {
            int count = 0;
            Console.WriteLine("Укажите полный путь папки для поиска в ней ключевого значения:");
            string path = @Console.ReadLine();
            Console.WriteLine("Укажите слово для поиска в .xml файлах");
            string searchAtributt = Console.ReadLine();

            Console.WriteLine("\n"+"Ваш результат: " + "\n");
            var fw = Directory.GetFiles(path, "*.xml");
            foreach (var file in fw)
            {
                var fileInfo = new FileInfo(file);
                var openFiles = File.ReadAllText(file);
                if (openFiles.Contains(searchAtributt))
                {
                    Console.WriteLine(fileInfo.Name);
                    Logs.WriteText(fileInfo.Name);
                    count++;
                }


            }
            Console.WriteLine($"\nНайдено {count} совпадений. Результат записан в файл logs.");
        }
    }
}
