using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfileBook.ViewModels
{
    public class SignInViewModel : ViewModelBase
    {
        #region AuthorizationInfo
        private AuthorizationInfo authorizationInfo;
        public AuthorizationInfo AuthorizationInfo
        {
            get { return this.authorizationInfo; }
            set { this.authorizationInfo = value; }
        }
        #endregion

        public SignInViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Signing In";
            this.authorizationInfo = new AuthorizationInfo();
        }
    }
}
