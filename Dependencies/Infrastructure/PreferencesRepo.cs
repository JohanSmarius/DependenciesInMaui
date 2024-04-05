using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies.Infrastructure
{
    internal class PreferencesRepo : IPreferencesRepo
    {
        public PreferencesRepo()
        {
            
        }

        public string GetSetting(string key)
        {
            return Preferences.Default.Get(key, string.Empty);
        }

        public void SetSetting(string key, string value)
        {
            Preferences.Default.Set(key, value);
        }
    }
}
