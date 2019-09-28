using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.Interfaces
{
    public interface INotepad : IBrowsable
    {
        void AddText(int pageNumber, string text);

        void ReplaceText(int pageNumber, string text);

        void DeleteText(int pageNumber);
    }
}
