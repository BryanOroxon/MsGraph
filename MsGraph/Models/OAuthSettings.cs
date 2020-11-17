using System;
namespace MsGraph.Models
{
    public static class OAuthSettings
    {
        public const string ApplicationId = "884456ee-2703-4f7c-9aea-e5b3f9143f23";
        //public const string ApplicationId = "eebd664f-27a5-42d0-a8f3-0e30b933217f";
        public const string Scopes = "User.Read Calendars.Read";
        public const string RedirectUri = "msauth://com.companyname.GraphTutorial";
    }
}
