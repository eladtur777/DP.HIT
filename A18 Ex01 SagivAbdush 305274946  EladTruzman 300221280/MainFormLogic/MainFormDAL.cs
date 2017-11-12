using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.MainFormLogic
{
    public class MainFormDAL
    {
        public FacebookObjectCollection<Page> GetUserBooks()
        {
            FacebookObjectCollection<Page> books = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.books.ToString());
            dynamic actionsDataBooks = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.books.ToString());
            return books;
        }

        public FacebookObjectCollection<Page> GetUserMusic()
        {
            FacebookObjectCollection<Page> music = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.music.ToString());
            dynamic actionsDataMusic = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.music.ToString());
            return music;
        }

        public FacebookObjectCollection<Page> GetUserMovies()
        {
            FacebookObjectCollection<Page> movies = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.movies.ToString());
            dynamic actionsDataMovies = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.movies.ToString());
            return movies;
        }

        public FacebookObjectCollection<Page> GetUserFriends()
        {
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.E_MainTabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(GeneralEnum.E_MainTabType.friends.ToString());
            return friends;
        }

        public Dictionary<GeneralEnum.E_UserBasicDetails, string> GetUserBasicDetails()
        {         
            Dictionary<GeneralEnum.E_UserBasicDetails, string> m_UserDetails = new Dictionary<GeneralEnum.E_UserBasicDetails, string>();
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.UserImage, UserLoginInstance.LoggedInUser.PictureNormalURL);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.FirstName, UserLoginInstance.LoggedInUser.FirstName);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.LastName, UserLoginInstance.LoggedInUser.LastName);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.Birthday, UserLoginInstance.LoggedInUser.Birthday);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.Gender, UserLoginInstance.LoggedInUser.Gender.ToString());
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.Religion, UserLoginInstance.LoggedInUser.Religion);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.Email, UserLoginInstance.LoggedInUser.Email);
            m_UserDetails.Add(GeneralEnum.E_UserBasicDetails.PostMessage, UserLoginInstance.LoggedInUser.Posts[0].Message);
            return m_UserDetails;
        }

        public string InitializeFaceBookLogin()
        {
            string result = string.Empty;
            UserLoginInstance.Instance.initializeFaceBookLoginPermissions();
            if (UserLoginInstance.LoggedInUser != null && UserLoginInstance.LoggedInUser.Id != null)
            {
                result = "";
            }

            if (!string.IsNullOrEmpty(UserLoginInstance.Instance.ErrorMessageResult))
            {
                result = UserLoginInstance.Instance.ErrorMessageResult;
            }

            return result;
        }

        public string PublishPostOnWall(string i_PostToPublish)
        {
            string result = string.Empty;
            if (i_PostToPublish != string.Empty)
            {
                try
                {
                    UserLoginInstance.LoggedInUser.PostStatus(i_PostToPublish);

                }
                catch (Exception ePost)
                {
                    result = string.Format("Faild on Post to your wall:{0}", ePost.Message);
                }
            }

            return result;
        }

    }
}
