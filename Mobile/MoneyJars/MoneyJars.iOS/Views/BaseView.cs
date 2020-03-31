using System;
using MoneyJars.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;

namespace MoneyJars.iOS.Views
{
    public class BaseView<T> : MvxViewController<T> where T : BaseViewModel
    {

        public BaseView(IntPtr handle) : base(handle)
        {

        }

        public BaseView()
        {

        }

    }

}
