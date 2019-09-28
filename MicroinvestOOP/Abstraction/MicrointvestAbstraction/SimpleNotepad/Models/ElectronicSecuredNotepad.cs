using SimpleAndSecuredNotepad.Common;
using SimpleAndSecuredNotepad.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAndSecuredNotepad.Models
{
    public class ElectronicSecuredNotepad : IЕlectronicDevice, ISecuredNotepad
    {
        #region Declarations

        private bool isDeviceWorking;
        private List<IPage> pages;
        private  readonly string password;

        #endregion

        #region Initializations

        public ElectronicSecuredNotepad(List<IPage> pages, string password)
        {
            this.Pages = pages;
            this.password = password;
        }
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

        #region PublicMethods

        public bool IsStarted()
        {
            return this.isDeviceWorking;
        }

        public void Start()
        {
            this.isDeviceWorking = true;
        }

        public void Stop()
        {
            this.isDeviceWorking = false;
        }

        public void AddText(int pageNumber, string text, string password)
        {
            CheckIsDeviceSwitchedOn(isDeviceWorking);

            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].AddText(text);
        }             

        public string BrowsePage(string password)
        {
            CheckIsDeviceSwitchedOn(isDeviceWorking);

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
            CheckIsDeviceSwitchedOn(isDeviceWorking);

            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
        }

        public void ReplaceText(int pageNumber, string text, string password)
        {
            CheckIsDeviceSwitchedOn(isDeviceWorking);

            PasswordCheck(this.password, password);

            ValidatePageIndex(pageNumber);

            Pages[pageNumber - 1].DeleteText();
            Pages[pageNumber - 1].AddText(text);
        }
        #endregion

        #region PrivateMethods

        private void ValidatePageIndex(int pageNumber)
        {
            if (pageNumber <= 0 || pageNumber > pages.Count - 1)
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

        private void CheckIsDeviceSwitchedOn(bool isDeviceWorking)
        {
            if (!isDeviceWorking)
            {
                throw new ArgumentException(GlobalConstants.DevideNotSwitchedOn + Environment.NewLine);
            }
        }

        #endregion     

        #endregion
    }
}
