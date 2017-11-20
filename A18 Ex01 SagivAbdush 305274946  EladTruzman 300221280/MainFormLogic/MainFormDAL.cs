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
            FacebookObjectCollection<Page> books = FacebookService.GetCollection<Page>(GeneralEnum.eMainTabType.books.ToString());
            dynamic actionsDataBooks = FacebookService.GetDynamicData(GeneralEnum.eMainTabType.books.ToString());
            return books;
        }

        public FacebookObjectCollection<Page> GetUserMusic()
        {
            FacebookObjectCollection<Page> music = FacebookService.GetCollection<Page>(GeneralEnum.eMainTabType.music.ToString());
            dynamic actionsDataMusic = FacebookService.GetDynamicData(GeneralEnum.eMainTabType.music.ToString());
            return music;
        }

        public FacebookObjectCollection<Page> GetUserMovies()
        {
            FacebookObjectCollection<Page> movies = FacebookService.GetCollection<Page>(GeneralEnum.eMainTabType.movies.ToString());
            dynamic actionsDataMovies = FacebookService.GetDynamicData(GeneralEnum.eMainTabType.movies.ToString());
            return movies;
        }

        public FacebookObjectCollection<Page> GetUserFriends()
        {
            FacebookObjectCollection<Page> friends = FacebookService.GetCollection<Page>(GeneralEnum.eMainTabType.friends.ToString());
            dynamic actionsDataFriends = FacebookService.GetDynamicData(GeneralEnum.eMainTabType.friends.ToString());
            return friends;
        }

        public Dictionary<GeneralEnum.eUserBasicDetails, string> GetUserBasicDetails()
        {         
            Dictionary<GeneralEnum.eUserBasicDetails, string> m_UserDetails = new Dictionary<GeneralEnum.eUserBasicDetails, string>();
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.UserImage, UserLoginInstance.LoggedInUser.PictureNormalURL);
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.FirstName, UserLoginInstance.LoggedInUser.FirstName);
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.LastName, UserLoginInstance.LoggedInUser.LastName);
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.Birthday, UserLoginInstance.LoggedInUser.Birthday);
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.Gender, UserLoginInstance.LoggedInUser.Gender.ToString());
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.Religion, UserLoginInstance.LoggedInUser.Religion);
            m_UserDetails.Add(GeneralEnum.eUserBasicDetails.Email, UserLoginInstance.LoggedInUser.Email);
            if (UserLoginInstance.LoggedInUser.Posts.Count > 0)
            {
                m_UserDetails.Add(GeneralEnum.eUserBasicDetails.PostMessage, UserLoginInstance.LoggedInUser.Posts[0].Message);
            }
                return m_UserDetails;
        }

        public string InitializeFaceBookLogin(string i_AppId)
        {
            string result = string.Empty;
            UserLoginInstance.Instance.initializeFaceBookLoginPermissions(i_AppId);
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
