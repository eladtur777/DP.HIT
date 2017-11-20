using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    public static class GeneralEnum
    {
        public enum eMainTabType {
            music = 1,
            television,
            movies,
            books,
            friends,
            PhotosTaggedIn
        };

        public enum eUserBasicDetails {
            UserImage = 1,
            FirstName,
            LastName,
            Birthday,
            Gender,
            Religion,
            Email,
            PostMessage
        };

        public enum eLocationSearch
        {
            City = 1,
            Country,
            State,
            Street,
            Zip
        };

        public enum eFbTripAdvisorAttributesSetting
        {
            SearchFromList = 1,
            SearchFromFreeTExt          
        };

        public enum eFormTypes
        {
            FbTripAdvisor = 1,
            FbClipSearch
        };    
    }
}
