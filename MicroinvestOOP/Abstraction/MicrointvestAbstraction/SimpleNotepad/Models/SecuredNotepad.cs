using SimpleNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.Models
{
    public class SecuredNotepad : INotepad
    {
        #region Declarations

        #endregion

        #region Initializations

        #endregion

        #region Properties

        #endregion

        #region Methods
        public void AddText(int pageNumber, string text)
        {
            throw new NotImplementedException();
        }

        public string BrowsePage()
        {
            throw new NotImplementedException();
        }

        public void DeleteText(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public void ReplaceText(int pageNumber, string text)
        {
            throw new NotImplementedException();
        }
        #endregion
        
    }
}
