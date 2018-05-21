using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в новом формате.");

        }
    }
}
