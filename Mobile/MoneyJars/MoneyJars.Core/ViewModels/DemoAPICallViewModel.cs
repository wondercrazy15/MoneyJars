using System;
using System.Windows.Input;
using MoneyJars.Core.Interfaces;
using MvvmCross;
using MvvmCross.Commands;

namespace MoneyJars.Core.ViewModels
{
    public class DemoAPICallViewModel : BaseViewModel
    {

        private readonly IDemoAPICall _DemoAPICallServices;
        public string Param { get; set; }
        public string userResponse;

        public bool isSuccess { get; set; }
        public Exception Error { get; set; }

        public DemoAPICallViewModel()
        {
            _DemoAPICallServices = Mvx.IoCProvider.Resolve<IDemoAPICall>();
        }


        //API Is Loading
        private bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { _isLoading = value; RaisePropertyChanged(() => IsLoading); }
        }


        //API get GuestLogin property

        private bool _getCallProperty;
        public bool GetCallProperty
        {
            get => _getCallProperty;
            set
            {
                _getCallProperty = value;
                RaisePropertyChanged(() => GetCallProperty);
                // take any additional actions here which are required when MyProperty is updated
            }
        }

        //Get GuestLogin API Command
        private MvxCommand _getAPICommand;
        public ICommand GetAddedPlaceAPICommand
        {
            get
            {
                _getAPICommand = _getAPICommand ?? new MvxCommand(GetAPICall);
                return _getAPICommand;
            }
        }

        //API Calling Method
        private void GetAPICall()
        {
            IsLoading = true;
            _DemoAPICallServices.GetDetailAPI(OnSuccessGuestLogIn, OnErrorGuestLogIn, Param);
        }

        //API Success
        private void OnSuccessGuestLogIn(string response)
        {
            //isSuccess = response.result;
            userResponse = response;
            //this.error = new Exception(response.message);
            //GetAddedPlaceProperty = true;

            //IsLoading = false;

        }

        //API Failure
        private void OnErrorGuestLogIn(Exception error)
        {
            // not reported for now
            isSuccess = false;
            this.Error = error;

            IsLoading = false;
        }


    }
}
