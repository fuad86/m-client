using System;
using mClient.Constants;

namespace mClient
{
    public static class Config
    {
        public static string Login;
        public static string Password;
        public static string Host;
        public static WoWVersion Version;
        public static long LogFilter;
        public static bool Retail;
        public static bool LogToFile;

        static Config()
        {
            Login = "JUSTMAKU";
            Password = "ORZECH";
            //Host = "logon.unitedwow.com";
            //Host = "eu.logon.worldofwarcraft.com";
            Host = "realm.neverendless-wow.com";
            //Host = "localhost";

            Version.major = 3;
            Version.minor = 1;
            Version.update = 3;
            Version.build = 9947;


            Retail = false;

            LogFilter = 0x0000000011000000;
            LogToFile = true;
        }
    }
}
