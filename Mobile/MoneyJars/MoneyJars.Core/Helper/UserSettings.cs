using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MoneyJars.Core.Helper
{
    public static class UserSettings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string currentUserGuestId
        {
            get => AppSettings.GetValueOrDefault(nameof(currentUserGuestId), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(currentUserGuestId), value);
        }

    }
}
