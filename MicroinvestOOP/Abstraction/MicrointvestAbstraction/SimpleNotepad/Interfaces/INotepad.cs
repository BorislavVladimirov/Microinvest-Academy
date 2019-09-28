using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Interfaces
{
    public interface INotepad : IBrowsable
    {
        void AddText(int pageNumber, string text);

        void ReplaceText(int pageNumber, string text);

        void DeleteText(int pageNumber);

        string SearchWord(string word);

        string PrintAllPagesWithDigits();
    }
}
