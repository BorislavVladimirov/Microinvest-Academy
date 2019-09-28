using SimpleNotepad.Common;
using SimpleNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleNotepad.Models
{
    public class Page : IPage
    {
        #region Declarations
        private string title;
        private StringBuilder stringBuilder;
        #endregion

        #region Initializations
        public Page(string title)
        {
            this.title = title;
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

        public StringBuilder Text
        {
            get => stringBuilder;

            private set
            {
                if (stringBuilder == null)
                {
                    this.stringBuilder = new StringBuilder();
                }
            }
        }

        #endregion

        #region Methods

        public void AddText(string text)
        {
            this.stringBuilder.AppendLine(text);
        }

        public string BrowsePage()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Title);
            sb.AppendLine(this.stringBuilder.ToString());

            return sb.ToString();
        }

        public void DeleteText()
        {
            this.stringBuilder = new StringBuilder();
        }
        #endregion

    }
}
