using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRecord 
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play melody.");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause melody.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop melody.");
        }

        public void Record()
        {
            Console.WriteLine("Start recording.");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Pause recording.");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording.");
        }
    }
}
