using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Interfaces
{
    public interface IPage : IDeletable, IBrowsable
    {
        void AddText(string text);

        bool SearchWord(string word);

        bool ContainsDigits();
    }
}
