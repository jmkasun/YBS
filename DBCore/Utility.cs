using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DBCore
{

    public enum AppSetting { BgImage }
    public enum UserLevel { SystemUser = 0, SystemUser_I = 1, SystemUser_IUD = 2, SystemAdmin = 3 };
    public enum MemberType { Youth = 1, Upasthana = 2, Other = 3 }

    public class Utility
    {

        public static string GetConnectionString()
        {
            return string.Concat(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb;Persist Security Info=True;Jet OLEDB:Database Password=";

        }

        public static string GetAppsetting(AppSetting key)
        {
            return ConfigurationManager.AppSettings[key.ToString()];
        }
    }
}
