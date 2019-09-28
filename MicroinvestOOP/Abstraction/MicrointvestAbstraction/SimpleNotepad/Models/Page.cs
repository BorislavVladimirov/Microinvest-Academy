using SimpleAndSecuredNotepad.Common;
using SimpleAndSecuredNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAndSecuredNotepad.Models
{
    public class Page : IPage
    {
        #region Declarations

        private string title;

        #endregion

        #region Initializations

        public Page(string title)
        {
            this.Title = title;
            this.Text = new StringBuilder();
        }
        #endregion

        #region Properties

        public string Title
        {
            get => title;

            private set
            {
                if (value == title)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidTitle);
                }

                title = value;
            }
        }

        public StringBuilder Text { get; set; }

        #endregion

        #region Methods

        public void AddText(string text)
        {
            Text.AppendLine(text);
        }

        public string BrowsePage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Title);
            sb.AppendLine(this.Text.ToString());

            return sb.ToString();
        }

        public void DeleteText()
        {
            this.Text = new StringBuilder();
        }

        public bool SearchWord(string word)
        {
            if (this.Text.ToString().Contains(word))
            {
                return true;
            }

            return false;
        }

        public bool ContainsDigits()
        {
            if (this.Text.ToString().Any(c => char.IsDigit(c)))
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
