using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class Redactor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format.ToLower())
            {
                case ".txt": handler = new TXTHandler(fileName);
                    break;
                case ".xml": handler = new XMLHandler(fileName);
                    break;
                case ".doc": handler = new DOCHandler(fileName);
                    break;
                default: Console.WriteLine("Неопознанный формат.");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Create()
        {
            handler.Craete();
        }

        public void Change()
        {
            handler.Chenge();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}
