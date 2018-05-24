using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRecord
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
