using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Interfaces
{
    public interface IЕlectronicDevice
    {
        void Start();

        void Stop();

        bool IsStarted();
    }
}
