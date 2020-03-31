using System;
using MvvmCross.ViewModels;

namespace MoneyJars.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            base.Initialize();

            //Mvx.IoCProvider.RegisterType<IGetUserService, GetUserService>();
            RegisterCustomAppStart<MyCustomStart>();

        }

    }
}
