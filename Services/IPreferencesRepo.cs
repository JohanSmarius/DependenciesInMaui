using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPreferencesRepo
    {
        string GetSetting(string key);

        void SetSetting(string key, string value);
    }
}
