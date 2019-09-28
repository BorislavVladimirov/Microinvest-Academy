using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Interfaces
{
    public interface ISecuredNotepad
    {
        string BrowsePage(string passWord);

        void AddText(int pageNumber, string text, string passWord);

        void ReplaceText(int pageNumber, string text, string passWord);

        void DeleteText(int pageNumber, string passWord);
    }
}
