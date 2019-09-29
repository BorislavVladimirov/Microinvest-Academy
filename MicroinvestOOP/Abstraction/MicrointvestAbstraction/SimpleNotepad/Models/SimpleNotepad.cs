using SimpleAndSecuredNotepad.Common;
using SimpleAndSecuredNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Models
{
    public class SimpleNotepad : INotepad
    {
        #region Declarations

        #endregion

        #region Initializations

        public SimpleNotepad(List<IPage> pages)
        {
            this.Pages = pages;
        }
        #endregion

        #region Properties

        public List<IPage> Pages { get; } = new List<IPage>();

        #endregion

        #region Methods

        public void AddText(int pageNumber, string text)
        {
            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].AddText(text);
        }

        public string BrowsePage()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var page in Pages)
            {
                sb.AppendLine(page.BrowsePage());
            }

            return sb.ToString();
        }

        public void DeleteText(int pageNumber)
        {
            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
        }

        public void ReplaceText(int pageNumber, string text)
        {
            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
            Pages[pageNumber - 1].AddText(text);
        }

        public string SearchWord(string word)
        {
            foreach (var page in this.Pages)
            {
                if (page.SearchWord(word))
                {
                    return GlobalConstants.PresentWord + Environment.NewLine;
                }
            }

            return GlobalConstants.WordNotPresent + Environment.NewLine;
        }

        public string PrintAllPagesWithDigits()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var page in this.Pages)
            {
                if (page.ContainsDigits())
                {
                    sb.AppendLine(page.BrowsePage());
                }
            }

            if (sb.Length == 0)
            {
                return GlobalConstants.NoDigitsPresent + Environment.NewLine;
            }

            return sb.ToString() + Environment.NewLine;
        }

        private void ValidatePageIndex(int pageNumber)
        {
            if (pageNumber <= 0 || pageNumber > Pages.Count)
            {
                throw new ArgumentException(GlobalConstants.InvalidPageNumber);
            }
        }

        #endregion
    }
}
