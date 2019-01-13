using System;

using MemoryWPF.DataHelpers;

namespace MemoryWPF
{
    public static class UserSettings
    {
        public static Language Language
        {
            get
            {
                return Enum.TryParse(Properties.Settings.Default.Language, out Language language) ? language : Language.English;
            }
            set
            {
                Properties.Settings.Default.Language = value.ToString();
                Properties.Settings.Default.Save();
            }
        }
    }
}
