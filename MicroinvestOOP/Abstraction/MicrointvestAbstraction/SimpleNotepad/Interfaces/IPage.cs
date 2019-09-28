using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.Interfaces
{
    public interface IPage : IDeletable, IBrowsable
    {
        void AddText(string text);
    }
}
