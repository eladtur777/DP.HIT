using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public static class GeneralEnum
    {
        public enum E_MainTabType {
            music = 1,
            television,
            movies,
            books,
            friends
        };

        public enum E_UserBasicDetails {
            UserImage = 1,
            FirstName,
            LastName,
            Birthday,
            Gender,
            Religion,
            Email,
            PostMessage
        };

        public enum E_LocationSearch
        {
            City = 1,
            Country,
            State,
            Street,
            Zip
        };
    }
}
