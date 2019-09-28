using SimpleNotepad.Common;
using SimpleNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.Models
{
    public abstract class NotePad : INotepad
    {
        #region Declarations
        private List<IPage> pages;
        #endregion

        #region Initializations
        #endregion

        #region Properties
        public List<IPage> Pages
        {
            get => pages;

            private set
            {
                if (pages == null)
                {
                    pages = new List<IPage>();
                }

                pages = value;
            }
        }
        #endregion

        #region Methods

        public void AddText(int pageNumber, string text)
        {
            ValidatePageIndex(pageNumber);

            pages[pageNumber - 1].AddText(text);
        }

        public string BrowsePage()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var page in pages)
            {
                sb.AppendLine(page.BrowsePage());
            }

            return sb.ToString();
        }

        public void DeleteText(int pageNumber)
        {
            ValidatePageIndex(pageNumber);

            pages[pageNumber - 1].DeleteText();
        }

        public void ReplaceText(int pageNumber, string text)
        {
            ValidatePageIndex(pageNumber);

            pages[pageNumber - 1].DeleteText();
            pages[pageNumber - 1].AddText(text);
        }

        private void ValidatePageIndex(int pageNumber)
        {
            if (pageNumber <= 0 || pageNumber > pages.Count - 1)
            {
                throw new ArgumentException(GlobalConstants.InvalidPageNumber);
            }
        }
        #endregion
    }
}
