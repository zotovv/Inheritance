using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " открыт.");
        }

        public void Craete()
        {
            Console.WriteLine(fileName + " создан.");
        }

        public void Chenge()
        {
            Console.WriteLine(fileName + " изменён.");
        }

        public abstract void Save();

    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранён в формате XML.");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранён в формате TXT.");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранён в формате DOC.");
        }
    }

}
