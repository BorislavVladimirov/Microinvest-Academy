using SimpleAndSecuredNotepad.Common;
using SimpleAndSecuredNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleAndSecuredNotepad.Models
{
    public class SecuredNotepad : ISecuredNotepad
    {
        #region Declarations

        private readonly string password;

        #endregion

        #region Initializations

        public SecuredNotepad(List<IPage> pages, string password)
        {
            this.password = password;

            ValidatePassword(this.password);

            this.Pages = pages;
        }

        #endregion

        #region Properties

        public List<IPage> Pages { get; } = new List<IPage>();

        #endregion

        #region Methods

        #region PublicMethods

        public void AddText(int pageNumber, string text, string password)
        {
            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].AddText(text);
        }
       
        public string BrowsePage(string password)
        {
            PasswordCheck(this.password, password);

            StringBuilder sb = new StringBuilder();

            foreach (var page in Pages)
            {
                sb.AppendLine(page.BrowsePage());
            }

            return sb.ToString();
        }

        public void DeleteText(int pageNumber, string password)
        {
            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
        }

        public void ReplaceText(int pageNumber, string text, string password)
        {
            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
            Pages[pageNumber - 1].AddText(text);
        }

        #endregion

        #region PrivateMethods

        private void ValidatePageIndex(int pageNumber)
        {
            if (pageNumber <= 0 || pageNumber > Pages.Count)
            {
                throw new ArgumentException(GlobalConstants.InvalidPageNumber);
            }
        }

        private void PasswordCheck(string originalPassword, string password)
        {
            if (password != originalPassword)
            {
                throw new ArgumentException(GlobalConstants.InvalidPassword);
            }
        }

        private void ValidatePassword(string password)
        {
            Regex length = new Regex("^.{5,}$");
            Regex digit = new Regex("\\d");
            Regex lowerChar = new Regex("[a-z]");
            Regex upperChar = new Regex("[A-Z]");


            if (!length.IsMatch(password) || !digit.IsMatch(password) 
                || !lowerChar.IsMatch(password) 
                || !upperChar.IsMatch(password))
            {
                throw new ArgumentException(GlobalConstants.PasswordNotStrongEnough);
            }
        }

        #endregion

        #endregion

    }
}
