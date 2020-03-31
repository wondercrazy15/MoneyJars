using System;
namespace MoneyJars.Core.Interfaces
{
    public interface IDemoAPICall
    {
        void GetDetailAPI(Action<string> success, Action<Exception> error, string Param);
    }
}
