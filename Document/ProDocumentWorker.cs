using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Эксперт.");
        }
    }
}
